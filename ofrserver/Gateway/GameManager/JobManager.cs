using Gateway.Login;
using Gateway.Player;
using log4net;
using SOE;
using SOE.Core;
using SOE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Gateway.GameManager
{
    internal class JobManger
    {
        public static void HandleJob(SOEClient soeClient, SOEReader reader)
        {

            var subOpcode = reader.ReadByte();
            //LoginManager._log.Info($"JobHandler op:{subOpcode}");


            switch (subOpcode)
            {
                case (byte)BaseCommandPackets.CommandPacketSetProfile:
                    {
                        _ = reader.ReadBoolean();
                        var JobSlotGuID = reader.ReadHostInt32();
                        HandleCommandPacketSetProfile(soeClient, JobSlotGuID);
                    }
                    break;
                default:
                    //var data = reader.ReadToEnd();
                    //LoginManager._log.Info($"HandleJob OpCode: {BasePackets.BaseCommandPacket} {subOpcode}\n{BitConverter.ToString(data).Replace("-", "")}");
                    break;
            }
        }

        public static void SendClientUpdatepacketStat(SOEClient soeClient)
        {
            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;

            var updatePacketUpdateStat = new SOEWriter((ushort)BasePackets.BaseClientUpdatePacket, true);

            updatePacketUpdateStat.AddHostUInt16((ushort)BaseClientUpdatePackets.ClientUpdatePacketUpdateStat);

            updatePacketUpdateStat.AddHostUInt64(player.playerGUID);

            //CharacterStat Count
            updatePacketUpdateStat.AddHostInt32(4);

            //Health 
            updatePacketUpdateStat.AddHostInt32(1);
            updatePacketUpdateStat.AddHostInt32(0);
            updatePacketUpdateStat.AddHostInt32(1000);

            //Health Refill
            updatePacketUpdateStat.AddHostInt32(4);
            updatePacketUpdateStat.AddHostInt32(0);
            updatePacketUpdateStat.AddFloat(4f);

            //Defense
            updatePacketUpdateStat.AddHostInt32(7);
            updatePacketUpdateStat.AddHostInt32(0);
            updatePacketUpdateStat.AddHostInt32(1000);

            //skill
            updatePacketUpdateStat.AddHostInt32(14);
            updatePacketUpdateStat.AddHostInt32(0);
            updatePacketUpdateStat.AddHostInt32(1);


            //LoginManager._log.Info("update stats");
            LoginManager.SendTunneledClientPacket(soeClient, updatePacketUpdateStat.GetRaw());

        }
        public static void ClientUpdatePacketActivateProfile(SOEClient soeClient, int jobId)
        {
            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;

            player.CharacterData.Class = jobId;

            var job = player.CharacterData.ClientPcProfiles.Find(x => x.JobGUID == jobId);
            var itemDefinitions = LoginManager.ClientItemDefinitions;

            var ClientUpdatePacketActivateProfile = new SOEWriter((ushort)BasePackets.BaseClientUpdatePacket, true);

            ClientUpdatePacketActivateProfile.AddHostUInt16((ushort)BaseClientUpdatePackets.ClientUpdatePacketActivateProfile);

            var profile = new SOEWriter();
            profile.AddHostInt32(job.JobGUID);
            profile.AddHostInt32(job.JobName);
            profile.AddHostInt32(job.JobDescription);
            profile.AddHostInt32(job.EnableAbility);
            profile.AddHostInt32(job.JobIcon);
            profile.AddHostInt32(job.Unknown6);
            profile.AddHostInt32(job.JobBadgeBorder);
            profile.AddHostInt32(job.JobBadge);
            profile.AddBoolean(job.MembersOnly);
            profile.AddHostInt32(job.IsCombat);
            profile.AddHostInt32(job.ItemClassData.Count);

            for (int i = 0; i < job.ItemClassData.Count; i++)
            {
                profile.AddHostInt32(job.ItemClassData.ElementAt(i).Item1);
                profile.AddHostInt32(job.ItemClassData.ElementAt(i).Item2.Unknown);
                profile.AddHostInt32(job.ItemClassData.ElementAt(i).Item2.Unknown2);
            }

            profile.AddBoolean(job.Unknown11);
            profile.AddHostInt32(job.Unknown12);
            profile.AddHostInt32(job.Unknown13);
            profile.AddBoolean(job.Unknown14);
            profile.AddHostInt32(job.Unknown15);
            profile.AddHostInt32(job.JobLevel);
            profile.AddHostInt32(job.JobLevelXP);
            profile.AddHostInt32(job.JobLevelTotalXP);
            profile.AddHostInt32(job.Unknown19);
            profile.AddHostInt32(job.Unknown20);
            profile.AddHostInt32(job.Items.Count);
            for (int i = 0; i < job.Items.Count; i++)
            {
                profile.AddHostInt32(job.Items.ElementAt(i).Item1);
                profile.AddHostInt32(job.Items.ElementAt(i).Item2.ItemGUID);
                profile.AddHostInt32(job.Items.ElementAt(i).Item2.Category);
            }
            profile.AddHostInt32(job.Unknown21);


            profile.AddHostInt32(job.AbilitySet.Count);
            profile.AddHostInt32(job.AbilitySet[0].Unknown);
            profile.AddHostInt32(job.AbilitySet[1].Unknown);
            profile.AddHostInt32(job.AbilitySet[2].Unknown);
            profile.AddHostInt32(job.AbilitySet[3].Unknown);
            profile.AddHostInt32(job.AbilitySet[4].Unknown);
            profile.AddHostInt32(job.AbilitySet[5].Unknown);
            profile.AddHostInt32(job.AbilitySet[6].Unknown);
            profile.AddHostInt32(job.AbilitySet[7].Unknown);
            // profile.AddHostInt32(job.Items.ElementAt(i).Item1);

            profile.AddHostInt32(0); //unknow set

            var rawBytes = profile.GetRaw();

            ClientUpdatePacketActivateProfile.AddHostInt32(rawBytes.Length);

            ClientUpdatePacketActivateProfile.AddBytes(rawBytes);


            ClientUpdatePacketActivateProfile.AddHostInt32(job.Items.Count);
            for (int i = 0; i < job.Items.Count; i++)
            {
                var clientItem = player.CharacterData.ClientItems.Find(x => x.Guid == job.Items.ElementAt(i).Item2.ItemGUID);

                if (clientItem == null)
                {
                    ClientUpdatePacketActivateProfile.AddASCIIString("");
                    ClientUpdatePacketActivateProfile.AddASCIIString("");
                    ClientUpdatePacketActivateProfile.AddASCIIString("");
                    ClientUpdatePacketActivateProfile.AddHostInt32(0);
                    ClientUpdatePacketActivateProfile.AddHostInt32(0);
                    ClientUpdatePacketActivateProfile.AddHostInt32(0);
                } else
                {
                    ClientItemDefinition item = LoginManager.ClientItemDefinitions.Find(x => x.Id == clientItem.Definition);

                    ClientUpdatePacketActivateProfile.AddASCIIString(item.ModelName);
                    ClientUpdatePacketActivateProfile.AddASCIIString(item.TextureAlias);
                    ClientUpdatePacketActivateProfile.AddASCIIString(item.TintAlias);
                    if (clientItem.Tint == 0)
                    {
                        ClientUpdatePacketActivateProfile.AddHostInt32(item.IconData.TintId);
                    }
                    else
                    {
                        ClientUpdatePacketActivateProfile.AddHostInt32(clientItem.Tint);
                    }

                    ClientUpdatePacketActivateProfile.AddHostInt32(item.CompositeEffectId);
                    ClientUpdatePacketActivateProfile.AddHostInt32(item.Slot);
                }

            }

            //unknown constant
            ClientUpdatePacketActivateProfile.AddHostInt32(0xBB9);
            ClientUpdatePacketActivateProfile.AddHostInt32(0xFA5);
            //unknown varaiable
            ClientUpdatePacketActivateProfile.AddHostInt32(0);
            //var data = ClientUpdatePacketActivateProfile.GetRaw();
            //LoginManager._log.Info($"ClientUpdatePacketActivateProfile \n{BitConverter.ToString(data).Replace("-", "")}");

            LoginManager.SendTunneledClientPacket(soeClient, ClientUpdatePacketActivateProfile.GetRaw());

            var equippedItems = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);

            equippedItems.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketEquippedItemsChange);
            equippedItems.AddHostUInt64(player.playerGUID);

            equippedItems.AddHostInt32(job.Items.Count);
            for (int i = 0; i < job.Items.Count; i++)
            {
                var clientItem = player.CharacterData.ClientItems.Find(x => x.Guid == job.Items.ElementAt(i).Item2.ItemGUID);

                if (clientItem == null)
                {
                    equippedItems.AddASCIIString("");
                    equippedItems.AddASCIIString("");
                    equippedItems.AddASCIIString("");
                    equippedItems.AddHostInt32(0);
                    equippedItems.AddHostInt32(0);
                    equippedItems.AddHostInt32(0);
                }
                else
                {
                    ClientItemDefinition item = LoginManager.ClientItemDefinitions.Find(x => x.Id == clientItem.Definition);

                    equippedItems.AddASCIIString(item.ModelName);
                    equippedItems.AddASCIIString(item.TextureAlias);
                    equippedItems.AddASCIIString(item.TintAlias);
                    if (clientItem.Tint == 0)
                    {
                        equippedItems.AddHostInt32(item.IconData.TintId);
                    }
                    else
                    {
                        equippedItems.AddHostInt32(clientItem.Tint);
                    }

                    equippedItems.AddHostInt32(item.CompositeEffectId);
                    equippedItems.AddHostInt32(item.Slot);
                }
            }
            equippedItems.AddHostInt32(0);

            BroadcastManager.BroadcastToPlayers(equippedItems.GetRaw());

            if (job.JobGUID == 2)
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(9);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
            else if (job.JobGUID == 12)
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(10);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
            else if (job.JobGUID == 35)
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(11);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
            else if (job.JobGUID == 32)
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(12);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
            else if (job.JobGUID == 43)
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(13);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
            else if (job.JobGUID == 11)
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(14);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
            else
            {
                var updateWieldType = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
                updateWieldType.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketUpdateActiveWieldType);
                updateWieldType.AddHostUInt64(player.playerGUID);
                updateWieldType.AddHostInt32(0);
                BroadcastManager.BroadcastToPlayers(updateWieldType.GetRaw());
            }
        }
        public static void AbilityPacketSetDefinition(SOEClient soeClient, int jobid)
        {
            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;

            var job = player.CharacterData.ClientPcProfiles.Find(x => x.JobGUID == jobid);

            var AbilityPacketSetDefinition = new SOEWriter((ushort)BasePackets.BaseAbilityPacket, true);

            AbilityPacketSetDefinition.AddHostUInt16((ushort)BaseAbilityPackets.AbilityPacketSetDefinition);
            AbilityPacketSetDefinition.AddHostInt32(jobid);
            AbilityPacketSetDefinition.AddUInt32(8);

            AbilityPacketSetDefinition.AddHostInt32(3); // Unknown1
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown2
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown3
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown4
            AbilityPacketSetDefinition.AddHostInt32(419883); // Unknown5
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown6
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown7
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown8
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown9
            AbilityPacketSetDefinition.AddHostInt32(0); // Unknown10
            AbilityPacketSetDefinition.AddByte(1); // Unknown11
            AbilityPacketSetDefinition.AddHostInt32(0);
            AbilityPacketSetDefinition.AddHostInt32(0);
            AbilityPacketSetDefinition.AddHostInt32(0);
            AbilityPacketSetDefinition.AddHostInt32(0);
            AbilityPacketSetDefinition.AddHostInt32(0);
            AbilityPacketSetDefinition.AddHostInt32(0);
            AbilityPacketSetDefinition.AddHostInt32(0);

            //for (int i = 0; i < job.AbilitySet.Count; i++)
            //{
            //    AbilityPacketSetDefinition.AddHostInt32(3); // Unknown1
            //    AbilityPacketSetDefinition.AddHostInt32(4895); // Unknown2
            //    AbilityPacketSetDefinition.AddHostInt32(0); // Unknown3
            //    AbilityPacketSetDefinition.AddHostInt32(0); // Unknown4
            //    AbilityPacketSetDefinition.AddHostInt32(4335); // Unknown5
            //    AbilityPacketSetDefinition.AddHostInt32(419883); // Unknown6
            //    AbilityPacketSetDefinition.AddHostInt32(4); // Unknown7
            //    AbilityPacketSetDefinition.AddHostInt32(1084227584); // Unknown8
            //    AbilityPacketSetDefinition.AddHostInt32(1); // Unknown9
            //    AbilityPacketSetDefinition.AddHostInt32(4895); // Unknown10
            //    AbilityPacketSetDefinition.AddHostInt32(0); // Unknown11
            //    AbilityPacketSetDefinition.AddBoolean(true); // Unknown12
            //}

            LoginManager.SendTunneledClientPacket(soeClient, AbilityPacketSetDefinition.GetRaw());
        }

        public static void PlayerUpdatePacketSetAnimation(SOEClient soeClient, int jobid)
        {
            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;
            //PlayerUpdatePacketSetAnimation

            var anime = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            anime.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketSetAnimation);
            anime.AddHostUInt64(player.playerGUID);
            anime.AddUInt32(22);
            anime.AddUInt32(0);
            anime.AddByte(2);
            LoginManager.SendTunneledClientPacket(soeClient, anime.GetRaw());
        }

        public static void HandleCommandPacketSetProfile(SOEClient soeClient, int JobId)
        {

            PlayerUpdatePacketSetAnimation(soeClient, JobId);
            //ClientUpdatePacketUpdateStat
            SendClientUpdatepacketStat(soeClient);
            //ClientUpdatePacketActivateProfile
            ClientUpdatePacketActivateProfile(soeClient, JobId);
            //AbilityPacketSetDefinition
            AbilityPacketSetDefinition(soeClient, JobId);

        }
    }
}