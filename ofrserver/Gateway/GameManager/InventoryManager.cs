using SOE.Core;
using SOE.Interfaces;
using SOE;
using Gateway.Login;
using static Gateway.Login.ClientPcData;
using System;
using System.Security.Cryptography;
using System.Linq;

namespace Gateway.GameManager
{
    internal class InventoryManager
    {
        public static void HandleBaseInventoryPacket(SOEClient soeClient, SOEReader reader)
        {

            var OpCode = reader.ReadHostUInt16();

            switch (OpCode)
            {
                case (ushort)BaseInventoryPackets.InventoryPacketEquipByGuid:
                    if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                        return;

                    //var clientItem = player.CharacterData.ClientItems.Find(cItem => cItem.Guid == reader.ReadHostInt32());
                    //var clientItemDef = LoginManager.ClientItemDefinitions.Find(cItemDef => cItemDef.Id == clientItem.Definition);

                    SendClientUpdatePacketEquipItem(soeClient, reader);

                    break;

                case (ushort)BaseInventoryPackets.InventoryPacketEquippedRemove:
                    SendInventoryPacketEquippedRemove(soeClient, reader);
                    break;

                default:
                    break;
            }
        }

        private static void SendClientUpdatePacketEquipItem(SOEClient soeClient, SOEReader reader)
        {
            var GUID = reader.ReadHostInt32();
            var Class = reader.ReadHostInt32();
            var Slot = reader.ReadHostInt32();

            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;

            var clientItem = player.CharacterData.ClientItems.Find(cItem => cItem.Guid == GUID);
            var clientItemDef = LoginManager.ClientItemDefinitions.Find(cItemDef => cItemDef.Id == clientItem.Definition);
            var currentJob = player.CharacterData.ClientPcProfiles.Find(x => x.JobGUID == Class);

            for (int i = 0; i < currentJob.Items.Count; i++)
            {
                if (currentJob.Items.ElementAt(i).Item2.Category == Slot)
                {
                    currentJob.Items.ElementAt(i).Item2.ItemGUID = GUID;
                } else
                {
                    continue;
                }
            }

            var clientEquip = new SOEWriter((ushort)BasePackets.BaseClientUpdatePacket, true);
            clientEquip.AddHostUInt16((ushort)BaseClientUpdatePackets.ClientUpdatePacketEquipItem);
            clientEquip.AddHostInt32(GUID);
            clientEquip.AddASCIIString(clientItemDef.ModelName);
            clientEquip.AddASCIIString(clientItemDef.TextureAlias);
            clientEquip.AddASCIIString(clientItemDef.TintAlias);

            if (clientItem.Tint == 0)
            {
                clientEquip.AddHostInt32(clientItemDef.IconData.TintId);
            }
            else
            {
                clientEquip.AddHostInt32(clientItem.Tint);
            }

            clientEquip.AddHostInt32(clientItemDef.CompositeEffectId);
            clientEquip.AddHostInt32(Slot);
            clientEquip.AddHostInt32(Class);
            clientEquip.AddHostInt32(clientItemDef.Type);
            clientEquip.AddBoolean(true);

            LoginManager.SendTunneledClientPacket(soeClient, clientEquip.GetRaw());

            var playerEquip = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            playerEquip.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketEquipItemChange);
            playerEquip.AddHostUInt64(player.playerGUID);
            playerEquip.AddHostInt32(clientItem.Guid);
            playerEquip.AddASCIIString(clientItemDef.ModelName);
            playerEquip.AddASCIIString(clientItemDef.TextureAlias);
            playerEquip.AddASCIIString(clientItemDef.TintAlias);

            if (clientItem.Tint == 0)
            {
                playerEquip.AddHostInt32(clientItemDef.IconData.TintId);
            }
            else
            {
                playerEquip.AddHostInt32(clientItem.Tint);
            }

            playerEquip.AddHostInt32(clientItemDef.CompositeEffectId);
            playerEquip.AddHostInt32(Slot);
            playerEquip.AddHostInt32(Class);
            playerEquip.AddHostInt32(clientItemDef.Class);
            playerEquip.AddHostInt32(0);

            BroadcastManager.BroadcastToPlayers(playerEquip.GetRaw());
        }

        //private static void SendItemFlairEffect(SOEClient soeClient, int flairGuid, int flairEffect)
        //{
        //    if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
        //        return;
        //
        //    var weapon = player.CharacterData.ClientPcProfiles[0].Items.Find(x => x.Item2.Category == 7);
        //    var weaponItem = player.CharacterData.ClientItems.Find(wItem => wItem.Guid == weapon.Item2.ItemGUID);
        //    var weaponItemDef = LoginManager.ClientItemDefinitions.Find(wItemDef => wItemDef.Id == weaponItem.Definition);
        //
        //    var equippedFlair = player.CharacterData.ClientPcProfiles[0].Items.Find(x => x.Item2.Category == 13);
        //
        //    var packet = new SOEWriter((ushort)BasePackets.BaseClientUpdatePacket, true);
        //    packet.AddHostUInt16((ushort)BaseClientUpdatePackets.ClientUpdatePacketEquipItem);
        //    packet.AddHostInt64(PlayerData.PlayerGUID);
        //    packet.AddHostInt32(weaponItem.Guid);
        //    packet.AddASCIIString(weaponItemDef.ModelName);
        //    packet.AddASCIIString(weaponItemDef.TextureAlias);
        //    packet.AddASCIIString(weaponItemDef.TintAlias);
        //
        //    if (weaponItem.Tint == 0)
        //    {
        //        packet.AddHostInt32(weaponItemDef.IconData.TintId);
        //    }
        //    else
        //    {
        //        packet.AddHostInt32(weaponItem.Tint);
        //    }
        //
        //    packet.AddHostInt32(flairEffect);
        //    packet.AddHostInt32(weaponItemDef.Slot);
        //
        //    packet.AddHostInt32(PlayerData.Class);
        //    packet.AddHostInt32(weaponItemDef.Class);
        //    packet.AddBoolean(true);
        //
        //    equippedFlair.Item2.ItemGUID = flairGuid;
        //    weaponItemDef.CompositeEffectId = flairEffect;
        //
        //    SendTunneledClientPacket(soeClient, packet.GetRaw());
        //    SendFlairEquip(soeClient, flairGuid);
        //    SendClientUpdatePacketEquipItem(soeClient, weaponItem.Guid);
        //} 

        //private static void SendFlairEquip(SOEClient soeClient, int guid)
        //{
        //    if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
        //        return;
        //
        //    var flairItem = player.CharacterData.ClientItems.Find(fItem => fItem.Guid == guid);
        //    var flairItemDef = LoginManager.ClientItemDefinitions.Find(fItemDef => fItemDef.Id == flairItem.Definition);
        //
        //    var packet = new SOEWriter((ushort)BasePackets.BaseClientUpdatePacket, true);
        //    packet.AddHostUInt16((ushort)BaseClientUpdatePackets.ClientUpdatePacketEquipItem);
        //    packet.AddHostInt64(player.playerGUID);
        //    packet.AddHostInt32(flairItem.Guid);
        //    packet.AddASCIIString(flairItemDef.ModelName);
        //    packet.AddASCIIString(flairItemDef.TextureAlias);
        //    packet.AddASCIIString(flairItemDef.TintAlias);
        //
        //    if (flairItem.Tint == 0)
        //    {
        //        packet.AddHostInt32(flairItemDef.IconData.TintId);
        //    }
        //    else
        //    {
        //        packet.AddHostInt32(flairItem.Tint);
        //    }
        //
        //    packet.AddHostInt32(flairItemDef.CompositeEffectId);
        //    packet.AddHostInt32(flairItemDef.Slot);
        //
        //    packet.AddHostInt32(PlayerData.Class);
        //    packet.AddHostInt32(flairItemDef.Class);
        //    packet.AddBoolean(true);
        //
        //    SendTunneledClientPacket(soeClient, packet.GetRaw());
        //    SendClientUpdatePacketEquipItem(soeClient, flairItem.Guid);
        //
        //}

        private static void SendInventoryPacketEquippedRemove(SOEClient soeClient, SOEReader reader)
        {
            var Slot = reader.ReadHostInt32();
            var Class = reader.ReadHostInt32();

            if (!LoginManager.PlayerCharacters.TryGetValue(soeClient.GetClientID(), out var player))
                return;

            var currentJob = player.CharacterData.ClientPcProfiles.Find(x => x.JobGUID == Class);

            for (int i = 0; i < currentJob.Items.Count; i++)
            {
                if (currentJob.Items.ElementAt(i).Item2.Category == Slot)
                {
                    currentJob.Items.ElementAt(i).Item2.ItemGUID = 0;
                }
                else
                {
                    continue;
                }
            }

            var clientUnequip = new SOEWriter((ushort)BasePackets.BaseClientUpdatePacket, true);
            clientUnequip.AddHostUInt16((ushort)BaseClientUpdatePackets.ClientUpdatePacketUnequipSlot);
            clientUnequip.AddHostInt32(Slot);
            clientUnequip.AddHostInt32(Class);
            LoginManager.SendTunneledClientPacket(soeClient, clientUnequip.GetRaw());

            var playerEquip = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            playerEquip.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketEquipItemChange);
            playerEquip.AddHostUInt64(player.playerGUID);
            playerEquip.AddHostInt32(0);
            playerEquip.AddASCIIString("");
            playerEquip.AddASCIIString("");
            playerEquip.AddASCIIString("");
            playerEquip.AddHostInt32(0);
            playerEquip.AddHostInt32(0);
            playerEquip.AddHostInt32(Slot);
            playerEquip.AddHostInt32(Class);
            playerEquip.AddHostInt32(0);
            playerEquip.AddHostInt32(0);

            BroadcastManager.BroadcastToPlayers(playerEquip.GetRaw());
        }
    }
}
