using Gateway.GameManager;
using Gateway.Login;
using log4net;
using Newtonsoft.Json;
using SOE;
using SOE.Core;
using SOE.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using static Gateway.Login.ClientPcData;

namespace Gateway.Player
{
    public class PlayerCharacter : IDisposable
    {
        public readonly SOEClient client;
        public readonly uint playerGUID;

        public float[] position;
        public float[] rotation;
        public byte characterState;
        public byte unknown;

        public bool ClientIsReady;

        public float[] lastBroadcastedPosition;
        public int lastBroadcastedTime;

        public List<PacketMountInfo> mounts;

        public ClientPcDatas CharacterData;

        public List<UnknownPetStruct> pets;

        public ActivePet activePet;

        public PlayerCharacter(SOEClient soeClient, ClientPcDatas characterData)
        {
            client = soeClient;
            playerGUID = (uint)characterData.PlayerGUID;

            position = new float[3];
            for (int i = 0; i < position.Length; i++)
                position[i] = characterData.PlayerPosition[i];

            rotation = new float[3];
            for (int i = 0; i < rotation.Length; i++)
                rotation[i] = characterData.CameraRotation[i];

            characterState = 0x01;
            unknown = 0x00;

            lastBroadcastedPosition = new float[3];
            for (int i = 0; i < lastBroadcastedPosition.Length; i++)
                lastBroadcastedPosition[i] = 0;

            lastBroadcastedTime = 0;
            mounts = new List<PacketMountInfo>();
            for (int i = 0; i < characterData.Mounts.Count; i++)
            {
                mounts.Add(characterData.Mounts[i]);
            }

            pets = characterData.Pets;
            activePet = new ActivePet();

            CharacterData = characterData;
        }

        public void Dispose()
        {
            LoginManager._log.Debug($"Attempting to dispose of \"{CharacterData.FirstName} {CharacterData.LastName}\"");

            var removePlayer = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            removePlayer.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketRemovePlayer);

            removePlayer.AddHostUInt16(1);
            removePlayer.AddHostUInt64(playerGUID); // Player GUID

            removePlayer.AddBoolean(false);
            removePlayer.AddHostInt32(0);
            removePlayer.AddHostInt32(0);
            removePlayer.AddHostInt32(46);
            removePlayer.AddHostInt32(1000);

            BroadcastManager.BroadcastToPlayers(removePlayer.GetRaw());
        }

        public void SpawnPcFor(SOEClient target)
        {
            LoginManager._log.Debug($"Attempting to spawn \"{CharacterData.FirstName} {CharacterData.LastName}\" (#{client.GetClientID()}) for Client #{target.GetClientID()}");

            var addPc = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);

            addPc.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddPc);
            addPc.AddHostUInt64(playerGUID); // Player GUID

            addPc.AddHostInt32(0); // DisplayInformation.Unknown1
            addPc.AddHostInt32(0); // DisplayInformation.Unknown2
            addPc.AddHostInt32(0); // DisplayInformation.Unknown3

            addPc.AddASCIIString(CharacterData.FirstName);
            addPc.AddASCIIString(CharacterData.LastName);

            addPc.AddHostInt32(CharacterData.PlayerModel);
            addPc.AddHostInt32(408679); // Unknown3
            addPc.AddHostInt32(13951728); // MountGUID
            addPc.AddHostInt32(1); // Unknown5

            for (var i = 0; i < position.Length; i++) // Position
                addPc.AddFloat(position[i]);
            addPc.AddFloat(1.0f);

            for (var i = 0; i < rotation.Length; i++) // Rotation
                addPc.AddFloat(rotation[i]);
            addPc.AddFloat(0.0f);

            var clientPcProfile = CharacterData.ClientPcProfiles.Find(x => x.JobGUID == CharacterData.Class);
            if (clientPcProfile == null)
                return;
            List<ClientItemDefinition> equippedItems = new List<ClientItemDefinition>();
            foreach ((int, ProfileItem) item in clientPcProfile.Items)
            {
                int itemGUID = item.Item2.ItemGUID;

                var clientItem = CharacterData.ClientItems.Find(x => x.Guid == itemGUID);

                if (clientItem == null)
                    continue;

                ClientItemDefinition itemDefintion = LoginManager.ClientItemDefinitions.Find(x => x.Id == clientItem.Definition);

                if (itemDefintion != null)
                {
                    if (clientItem.Tint != 0)
                        itemDefintion.IconData.TintId = clientItem.Tint;

                    equippedItems.Add(itemDefintion);
                }
            }

            addPc.AddHostInt32(equippedItems.Count);
            for (var i = 0; i < equippedItems.Count; i++)
            {
                ClientItemDefinition item = equippedItems[i];
                addPc.AddASCIIString(item.ModelName);
                addPc.AddASCIIString(item.TextureAlias);
                addPc.AddASCIIString(item.TintAlias);
                addPc.AddHostInt32(item.IconData.TintId);
                addPc.AddHostInt32(item.CompositeEffectId);
                addPc.AddHostInt32(item.Slot);
            }

            addPc.AddASCIIString(CharacterData.PlayerHead);
            addPc.AddASCIIString(CharacterData.PlayerHair);
            addPc.AddHostInt32(CharacterData.HairColor);
            addPc.AddHostInt32(CharacterData.EyeColor);
            addPc.AddHostInt32(0); // Unknown12
            addPc.AddASCIIString(CharacterData.Skintone);
            addPc.AddASCIIString(CharacterData.FacePaint);
            addPc.AddASCIIString(CharacterData.HumanBeardsPixieWings);

            addPc.AddHostInt32(1090519040); // Unknown16
            addPc.AddBoolean(false); // Unknown17

            addPc.AddBoolean(true); // Unknown18
            addPc.AddBoolean(false); // Unknown19

            addPc.AddHostInt32(0); // Unknown20

            addPc.AddHostInt32(0); // GuildGUID Count
            // TODO: Guilds

            addPc.AddHostInt32(CharacterData.Class); // Class

            addPc.AddHostInt32(0); // PlayerTitle.GUID
            addPc.AddHostInt32(0); // PlayerTitle.Unknown2
            addPc.AddHostInt32(0); // PlayerTitle.NameId
            addPc.AddHostInt32(0); // PlayerTitle.MountGUID

            addPc.AddHostInt32(CharacterData.EffectTags.Count); // EffectTagCount
            foreach ((int, ClientEffectTag) effectTag in CharacterData.EffectTags)
            {
                addPc.AddHostInt32(effectTag.Item2.Unknown); // EffectTag.PetId
                addPc.AddHostInt32(effectTag.Item2.Unknown2); // EffectTag.Unknown2
                addPc.AddHostInt32(effectTag.Item2.Unknown3); // EffectTag.Unknown3

                addPc.AddHostInt32(effectTag.Item2.Unknown4); // EffectTag.MountGUID
                addPc.AddHostInt32(effectTag.Item2.Unknown5); // EffectTag.Unknown5
                addPc.AddHostInt32(effectTag.Item2.Unknown6); // EffectTag.Unknown6
                addPc.AddHostInt32(effectTag.Item2.Unknown7); // EffectTag.Unknown7

                addPc.AddBoolean(effectTag.Item2.Unknown8); // EffectTag.Unknown8

                addPc.AddHostInt64(effectTag.Item2.Unknown9); // EffectTag.Unknown9
                addPc.AddHostInt32(effectTag.Item2.Unknown10); // EffectTag.Unknown10, Stored as long, epoch time?
                addPc.AddHostInt32(effectTag.Item2.Unknown11); // EffectTag.Unknown11, Stored as long, epoch time?

                addPc.AddHostInt32(effectTag.Item2.Unknown12); // EffectTag.Unknown12
                addPc.AddHostInt32(effectTag.Item2.Unknown13); // EffectTag.Unknown13
                addPc.AddHostInt64(effectTag.Item2.Unknown14); // EffectTag.Unknown14
                addPc.AddHostInt32(effectTag.Item2.Unknown15); // EffectTag.Unknown15
                addPc.AddHostInt32(effectTag.Item2.Unknown16); // EffectTag.Unknown16

                addPc.AddBoolean(effectTag.Item2.Unknown17); // EffectTag.Unknown17
                addPc.AddBoolean(effectTag.Item2.Unknown18); // EffectTag.Unknown18
                addPc.AddBoolean(effectTag.Item2.Unknown19); // EffectTag.Unknown19
            }

            addPc.AddHostInt64(0); // Unknown22
            addPc.AddHostInt32(-1); // Unknown23
            addPc.AddHostInt32(-1); // Unknown24
            addPc.AddFloat(0); // Unknown25
            addPc.AddHostInt32(0); // Character Animation
            addPc.AddFloat(0); // Unknown27
            addPc.AddHostInt32(0); // Unknown28
            addPc.AddHostInt32(0); // Unknown29
            addPc.AddHostInt32(0); // Unknown30

            LoginManager.SendTunneledClientPacket(target, addPc.GetRaw());
        }

        public void SendPacketMountResponse(SOEClient target)
        {
            var mount = mounts.Find(x => x.MountGUID != 0);

            if (mount == null)
                return;

            var mountItemDef = LoginManager.ClientItemDefinitions.Find(mItemDef => mItemDef.Id == mount.MountItemDefinitionID);

            var addMount = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);

            addMount.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            addMount.AddHostUInt64(mount.MountGUID);
            addMount.AddHostInt32(mount.MountName);
            addMount.AddHostInt32(mount.MountModelID);
            addMount.AddBoolean(false);
            addMount.AddHostInt32(408679);
            addMount.AddHostInt32(13951728);
            addMount.AddHostInt32(1);
            addMount.AddFloat(1.0f);

            addMount.AddFloat(position[0]);
            addMount.AddFloat(position[1]);
            addMount.AddFloat(position[2]);
            addMount.AddFloat(1.0f);

            addMount.AddFloat(rotation[0]);
            addMount.AddFloat(rotation[1]);
            addMount.AddFloat(rotation[2]);
            addMount.AddFloat(0f);

            addMount.AddHostInt32(1);
            addMount.AddHostInt32(0); // CharacterAttachmentDataCount
            addMount.AddHostInt32(1);

            addMount.AddASCIIString(mountItemDef.TextureAlias);
            addMount.AddASCIIString(mount.MountTintAlias);
            addMount.AddHostInt32(mount.MountTintId);
            addMount.AddBoolean(true);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);
            addMount.AddASCIIString(""); // Custom Name
            addMount.AddBoolean(true); // NameDisabled
            addMount.AddHostInt32(0);
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);
            addMount.AddHostInt32(0);
            addMount.AddBoolean(false);
            addMount.AddFloat(0f);
            addMount.AddBoolean(false);
            addMount.AddHostInt32(100);
            addMount.AddHostInt32(-1);
            addMount.AddHostInt32(-1);
            addMount.AddHostInt32(-1);
            addMount.AddBoolean(false);
            addMount.AddBoolean(false);
            addMount.AddHostInt32(-1);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);

            addMount.AddHostInt32(0); // EffectTagsCount

            addMount.AddBoolean(false);
            addMount.AddHostInt32(0);
            addMount.AddBoolean(false);
            addMount.AddBoolean(false);
            addMount.AddBoolean(false);
            addMount.AddBoolean(false);

            addMount.AddHostInt32(1); // UnknownStruct2
            addMount.AddASCIIString("");
            addMount.AddASCIIString("");
            addMount.AddHostInt32(0);
            addMount.AddASCIIString("");

            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);

            addMount.AddHostInt32(0);
            addMount.AddHostInt32(-1);
            addMount.AddHostInt32(mount.MountIcon);
            addMount.AddBoolean(true);
            addMount.AddHostInt64(0);
            addMount.AddHostInt32(2);
            addMount.AddFloat(0.0f);

            addMount.AddHostInt32(0); // Target

            addMount.AddHostInt32(0); // CharacterVariables

            addMount.AddHostInt32(0);
            addMount.AddFloat(0.0f);

            addMount.AddFloat(0.0f); // Unknown54, float[4]
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);

            addMount.AddHostInt32(0);
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);
            addMount.AddFloat(0.0f);
            addMount.AddASCIIString("");
            addMount.AddASCIIString("");
            addMount.AddASCIIString("");
            addMount.AddBoolean(false);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(0);
            addMount.AddHostInt32(3442);
            addMount.AddFloat(0.0f);
            addMount.AddHostInt32(0);

            LoginManager.SendTunneledClientPacket(target, addMount.GetRaw());

            var mountResponse = new SOEWriter((ushort)BasePackets.MountBasePacket, true);

            mountResponse.AddByte((byte)MountBasePackets.PacketMountResponse);

            mountResponse.AddHostInt64(playerGUID);
            mountResponse.AddHostUInt64(mount.MountGUID); // MountGuid
            mountResponse.AddHostInt32(0);
            mountResponse.AddHostInt32(1); // Queue Position
            mountResponse.AddHostInt32(1);
            mountResponse.AddHostInt32(46);
            mountResponse.AddHostInt32(0);

            LoginManager.SendTunneledClientPacket(target, mountResponse.GetRaw());
        }
    }
}






 