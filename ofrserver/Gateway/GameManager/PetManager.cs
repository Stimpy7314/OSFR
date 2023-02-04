using Gateway.Login;
using Gateway.Player;
using SOE;
using SOE.Core;
using SOE.Interfaces;
using System;
using Gateway.NonGameRelatedManagers;

namespace Gateway.GameManager
{
    internal class PetManager
    {
        public static void HandlePetBasePacket(SOEClient soeClient, SOEReader reader)
        {
            var subOpcode = reader.ReadByte();
            switch (subOpcode)
            {
                case (byte)PetBasePackets.PetSummonRecallPacket:
                    {
                        int petId = reader.ReadHostInt32();
                        byte petStatus = reader.ReadByte();

                        if (petStatus == 1)
                        {
                            HandleActivatePet(soeClient, petId);
                        }
                        else
                        {
                            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                                return;

                            SendPetDeactivatePacket(soeClient);
                            SendPlayerUpdatePacketRemovePlayer(player);
                            player.activePet.PetGUID = 0;
                            player.activePet.PetId = 0;
                        }
                    }
                    break;

                default:
                    //var data = reader.ReadToEnd();

                    //LoginManager._log.Info($"PetSummonRecallPacket OpCode: 53 {subOpcode}\n{BitConverter.ToString(data).Replace("-", "")}");
                    break;

            }
        }

        public static void SendPetDeactivatePacket(SOEClient soeClient)
        {
            var petActiveData = new SOEWriter((ushort)BasePackets.PetBasePacket, true);
            petActiveData.AddByte((byte)PetBasePackets.PetActivePacket);
            petActiveData.AddHostInt32(0);
            petActiveData.AddHostUInt64(0);
            LoginManager.SendTunneledClientPacket(soeClient, petActiveData.GetRaw());
        }

        public static void HandleActivatePet(SOEClient soeClient, int petId)
        {
            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;

            var newGUID = GUIDRandomizer.RandomGUID();
            var activePet = player.activePet;
            activePet.PetId = petId;
            activePet.PetGUID = newGUID;

            for (int i = 0; i < player.position.Length; i++)
            {
                activePet.Position[i] = player.position[i];
            }
            for (int i = 0; i < player.rotation.Length; i++)
            {
                activePet.Rotation[i] = player.rotation[i];
            }

            var petData = player.pets.Find(x => x.PetId == petId);

            SendPlayerUpdatePacketAddNpc(player, petData, activePet);

            //SendPetActivePacket
            var petActiveData = new SOEWriter((ushort)BasePackets.PetBasePacket, true);
            petActiveData.AddByte((byte)PetBasePackets.PetActivePacket);
            petActiveData.AddHostInt32(activePet.PetId);
            petActiveData.AddHostUInt64(activePet.PetGUID);
            LoginManager.SendTunneledClientPacket(soeClient, petActiveData.GetRaw());

            //SendPetStatusPacket
            var petStatus = new SOEWriter((ushort)BasePackets.PetBasePacket, true);
            petStatus.AddByte((byte)PetBasePackets.PetStatusPacket);
            petStatus.AddHostInt32(activePet.PetId);
            petStatus.AddFloat(petData.Food);
            petStatus.AddFloat(petData.Groom);
            petStatus.AddFloat(petData.Exercise);
            petStatus.AddFloat(petData.Happiness);
            LoginManager.SendTunneledClientPacket(soeClient, petStatus.GetRaw());


            //SendPlayerUpdatePacketUpdateOwner
            var updateOwner = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            updateOwner.AddByte((byte)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateOwner);
            updateOwner.AddBoolean(false);
            updateOwner.AddHostUInt64(activePet.PetGUID);
            updateOwner.AddHostInt32(0);
            updateOwner.AddBoolean(false);
            BroadcastManager.BroadcastToPlayers(updateOwner.GetRaw());

            //PlayerUpdatePacketPlayCompositeEffect
            var soeWriter = new SOEWriter((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketPlayCompositeEffect, true);
            soeWriter.AddHostUInt64(activePet.PetGUID);
            soeWriter.AddHostUInt32(34);
            soeWriter.AddHostUInt32(9546096);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(46);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(0);
            soeWriter.AddHostUInt32(1065353216);
            soeWriter.AddByte(1);
            BroadcastManager.BroadcastToPlayers(soeWriter.GetRaw());


            //SendPlayerUpdatePacketUpdateCharacterState
            var updateCharacterState = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            updateCharacterState.AddByte((byte)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateCharacterState);
            updateCharacterState.AddBoolean(false);
            updateCharacterState.AddHostUInt64(activePet.PetGUID);
            updateCharacterState.AddHostInt32(1);
            BroadcastManager.BroadcastToPlayers(updateCharacterState.GetRaw());
        }

        public static void SendPlayerUpdatePacketAddNpc(PlayerCharacter player, ClientPcData.UnknownPetStruct petData, ActivePet activePet)
        {
            var petItemDef = LoginManager.ClientItemDefinitions.Find(x => x.Id == petData.PetItemDefinitionID);
            var petItem = player.CharacterData.ClientItems.Find(cItem => cItem.Definition == petItemDef.Id);

            var addPet = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);

            addPet.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);

            addPet.AddHostUInt64(activePet.PetGUID);
            addPet.AddHostInt32(petData.Unknown10); // Name ID 
            addPet.AddHostInt32(petData.PetModelID);
            addPet.AddBoolean(false);
            addPet.AddHostInt32(408679);
            addPet.AddHostInt32(13951728);
            addPet.AddHostInt32(1);
            addPet.AddFloat(1.0f);

            addPet.AddFloat(player.position[0] + 2f);
            addPet.AddFloat(player.position[1]);
            addPet.AddFloat(player.position[2]);
            addPet.AddFloat(1.0f);

            addPet.AddFloat(player.rotation[0]);
            addPet.AddFloat(player.rotation[1]);
            addPet.AddFloat(player.rotation[2]);
            addPet.AddFloat(0f);

            addPet.AddHostInt32(1);
            addPet.AddHostInt32(0); // CharacterAttachmentDataCount

            addPet.AddHostInt32(1);

            addPet.AddASCIIString(petItemDef.TextureAlias);
            addPet.AddASCIIString(petData.TextureAlias);
            if (petItem.Tint == 0)
            {
                addPet.AddHostInt32(petItemDef.Tint);
            } else
            {
            addPet.AddHostInt32(petData.TintID);
            }
            addPet.AddBoolean(true);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);
            addPet.AddASCIIString(petData.PetName); // Custom Name
            addPet.AddBoolean(false); // NameDisabled
            addPet.AddHostInt32(0);
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);
            addPet.AddHostInt32(0);
            addPet.AddBoolean(false);
            addPet.AddFloat(6.0f);
            addPet.AddBoolean(false);
            addPet.AddHostInt32(100);
            addPet.AddHostInt32(-1);
            addPet.AddHostInt32(-1);
            addPet.AddHostInt32(-1);
            addPet.AddBoolean(false);
            addPet.AddBoolean(false);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);

            addPet.AddHostInt32(0); // EffectTagsCount

            addPet.AddBoolean(false);
            addPet.AddHostInt32(0);
            addPet.AddBoolean(false);
            addPet.AddBoolean(false);
            addPet.AddBoolean(false);
            addPet.AddBoolean(false);

            addPet.AddHostInt32(0); // UnknownStruct2
            addPet.AddHostInt32(0);
            addPet.AddASCIIString("");
            addPet.AddASCIIString("");
            addPet.AddHostInt32(0);
            addPet.AddASCIIString("");

            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);

            addPet.AddHostInt32(-1);
            addPet.AddHostInt32(petData.IconId);
            addPet.AddBoolean(true);
            addPet.AddHostInt64(0);
            addPet.AddHostInt32(2);
            addPet.AddFloat(0.0f);

            addPet.AddHostInt32(0); // Target

            addPet.AddHostInt32(0); // CharacterVariables

            addPet.AddHostInt32(0);
            addPet.AddFloat(0.0f);

            addPet.AddFloat(0.0f); // Unknown54, float[4]
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);

            addPet.AddHostInt32(0);
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);
            addPet.AddFloat(0.0f);
            addPet.AddASCIIString("");
            addPet.AddASCIIString("");
            addPet.AddASCIIString("");
            addPet.AddBoolean(false);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(8);
            addPet.AddHostInt32(0);
            addPet.AddHostInt32(0);
            addPet.AddFloat(0.0f);
            addPet.AddHostInt32(0);

            BroadcastManager.BroadcastToPlayers(addPet.GetRaw());
        }

        public static void SendPlayerUpdatePacketRemovePlayer(PlayerCharacter player)
        {
            var removePet = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);

            removePet.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketRemovePlayer);

            removePet.AddHostUInt16(1);
            removePet.AddHostUInt64(player.activePet.PetGUID);

            removePet.AddBoolean(false);
            removePet.AddHostInt32(0);
            removePet.AddHostInt32(0);
            removePet.AddHostInt32(46);
            removePet.AddHostInt32(1000);

            BroadcastManager.BroadcastToPlayers(removePet.GetRaw());
        }

        public static void SendUpdatePosition(PlayerCharacter player)
        {
            var activePet = player.activePet;
            if (activePet.PetGUID != 0)
            {
                var petData = player.pets.Find(x => x.PetId == activePet.PetId);
                var soeWriter = new SOEWriter((ushort)BasePackets.PlayerUpdatePacketUpdatePosition, true);
                soeWriter.AddHostUInt64(activePet.PetGUID);

                for (var i = 0; i < 3; i++)
                    soeWriter.AddFloat(player.position[i] + 1.3f);

                for (var i = 0; i < 3; i++)
                    soeWriter.AddFloat(player.rotation[i]);

                soeWriter.AddByte(player.characterState);
                soeWriter.AddByte(player.unknown);

                BroadcastManager.BroadcastToPlayers(soeWriter.GetRaw());
            }
        }
    }
}


