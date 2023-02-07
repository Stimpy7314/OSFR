using Gateway.Login;
using Gateway.NonGameRelatedManagers;
using SOE;
using SOE.Core;
using SOE.Interfaces;


namespace Gateway.GameManager
{
    internal class NPCManager2
    {
        public static void SendPlayerUpdatePacketAddNpc(SOEClient soeClient)
        {

            var Snibug = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Snibug.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Snibug.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Snibug.AddHostInt32(432135); // Name ID
            Snibug.AddHostInt32(65); // Model ID
            Snibug.AddBoolean(false); // Unknown4
            Snibug.AddHostInt32(408679); // Unknown5
            Snibug.AddHostInt32(13951728); // Unknown6
            Snibug.AddHostInt32(1); // Unknown7
            Snibug.AddFloat(1.0f); // Unknown8

            // Position
            Snibug.AddFloat(-362.3488f);
            Snibug.AddFloat(-83.14504f);
            Snibug.AddFloat(2400.63f);
            Snibug.AddFloat(1.0f);

            //Rotation
            Snibug.AddFloat(-.558622f);
            Snibug.AddFloat(0f);
            Snibug.AddFloat(-0.8294224f);
            Snibug.AddFloat(0f);

            Snibug.AddHostInt32(1); // Unknown11

            Snibug.AddHostInt32(0); // CharacterAttachmentDataCount
            Snibug.AddHostInt32(1); // Unknown12

            Snibug.AddASCIIString(""); // TextureAlias
            Snibug.AddASCIIString(""); // TintAlias
            Snibug.AddHostInt32(0); // TintId
            Snibug.AddBoolean(true); // Unknown16
            Snibug.AddFloat(0f); // Unknown17
            Snibug.AddHostInt32(0); // Unknown18
            Snibug.AddHostInt32(0); // Unknown19
            Snibug.AddASCIIString("Lieutenant Snibug"); // Custom Name
            Snibug.AddBoolean(false); // NameDisabled
            Snibug.AddHostInt32(0); // Unknown22
            Snibug.AddFloat(0.0f); // Unknown23
            Snibug.AddFloat(0.0f); // Unknown24
            Snibug.AddHostInt32(0); // Unknown25
            Snibug.AddBoolean(false); // Unknown26
            Snibug.AddFloat(0.0f); // Unknown27
            Snibug.AddBoolean(false); // Unknown28
            Snibug.AddHostInt32(100); // Unknown29
            Snibug.AddHostInt32(-1); // Unknown
            Snibug.AddHostInt32(-1); // Unknown
            Snibug.AddHostInt32(-1); // Unknown
            Snibug.AddBoolean(false); // Unknown
            Snibug.AddBoolean(false); // Unknown
            Snibug.AddHostInt32(-1); // Unknown
            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddHostInt32(0); // Unknown

            Snibug.AddHostInt32(0); // EffectTagsCount

            Snibug.AddBoolean(false); // Unknown
            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddBoolean(false); // Unknown
            Snibug.AddBoolean(false); // Unknown
            Snibug.AddBoolean(false); // Unknown
            Snibug.AddBoolean(false); // Unknown

            Snibug.AddHostInt32(0); // UnknownStruct2
            Snibug.AddASCIIString("");
            Snibug.AddASCIIString("");
            Snibug.AddHostInt32(0);
            Snibug.AddASCIIString("");

            Snibug.AddFloat(0.0f);
            Snibug.AddFloat(0.0f);
            Snibug.AddFloat(0.0f);
            Snibug.AddFloat(0.0f);

            Snibug.AddHostInt32(0);
            Snibug.AddHostInt32(-1);
            Snibug.AddHostInt32(0);
            Snibug.AddBoolean(true);
            Snibug.AddHostUInt64(0);
            Snibug.AddHostInt32(2);
            Snibug.AddFloat(0.0f);

            Snibug.AddHostInt32(0); // Target

            Snibug.AddHostInt32(0); // CharacterVariables

            Snibug.AddHostInt32(0);
            Snibug.AddFloat(0.0f);

            Snibug.AddFloat(0.0f); // Unknown54, float[4]
            Snibug.AddFloat(0.0f);
            Snibug.AddFloat(0.0f);
            Snibug.AddFloat(0.0f);

            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddFloat(0.0f); // Unknown
            Snibug.AddFloat(0.0f); // Unknown
            Snibug.AddFloat(0.0f); // Unknown
            Snibug.AddASCIIString(""); // Unknown
            Snibug.AddASCIIString(""); // Unknown
            Snibug.AddASCIIString(""); // Unknown
            Snibug.AddBoolean(false); // Unknown
            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddHostInt32(8); // Unknown
            Snibug.AddHostInt32(0); // Unknown
            Snibug.AddHostInt32(3442); // Unknown
            Snibug.AddFloat(0.0f); // Unknown
            Snibug.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Snibug.GetRaw());

            var Tran = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Tran.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Tran.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Tran.AddHostInt32(432135); // Name ID
            Tran.AddHostInt32(468); // Model ID
            Tran.AddBoolean(false); // Unknown4
            Tran.AddHostInt32(408679); // Unknown5
            Tran.AddHostInt32(13951728); // Unknown6
            Tran.AddHostInt32(1); // Unknown7
            Tran.AddFloat(1.0f); // Unknown8

            // Position
            Tran.AddFloat(-57.96939f);
            Tran.AddFloat(51.76924f);
            Tran.AddFloat(1026.983f);
            Tran.AddFloat(1.0f);

            //Rotation
            Tran.AddFloat(0.9191048f);
            Tran.AddFloat(0f);
            Tran.AddFloat(-0.3940132f);
            Tran.AddFloat(0f);

            Tran.AddHostInt32(1); // Unknown11

            Tran.AddHostInt32(0); // CharacterAttachmentDataCount
            Tran.AddHostInt32(1); // Unknown12

            Tran.AddASCIIString("base_02"); // TextureAlias
            Tran.AddASCIIString("mahogany"); // TintAlias
            Tran.AddHostInt32(0); // TintId
            Tran.AddBoolean(true); // Unknown16
            Tran.AddFloat(0f); // Unknown17
            Tran.AddHostInt32(0); // Unknown18
            Tran.AddHostInt32(0); // Unknown19
            Tran.AddASCIIString("Tran"); // Custom Name
            Tran.AddBoolean(false); // NameDisabled
            Tran.AddHostInt32(0); // Unknown22
            Tran.AddFloat(0.0f); // Unknown23
            Tran.AddFloat(0.0f); // Unknown24
            Tran.AddHostInt32(0); // Unknown25
            Tran.AddBoolean(false); // Unknown26
            Tran.AddFloat(0.0f); // Unknown27
            Tran.AddBoolean(false); // Unknown28
            Tran.AddHostInt32(100); // Unknown29
            Tran.AddHostInt32(-1); // Unknown
            Tran.AddHostInt32(-1); // Unknown
            Tran.AddHostInt32(-1); // Unknown
            Tran.AddBoolean(false); // Unknown
            Tran.AddBoolean(false); // Unknown
            Tran.AddHostInt32(-1); // Unknown
            Tran.AddHostInt32(0); // Unknown
            Tran.AddHostInt32(0); // Unknown

            Tran.AddHostInt32(0); // EffectTagsCount

            Tran.AddBoolean(false); // Unknown
            Tran.AddHostInt32(0); // Unknown
            Tran.AddBoolean(false); // Unknown
            Tran.AddBoolean(false); // Unknown
            Tran.AddBoolean(false); // Unknown
            Tran.AddBoolean(false); // Unknown

            Tran.AddHostInt32(0); // UnknownStruct2
            Tran.AddASCIIString("");
            Tran.AddASCIIString("");
            Tran.AddHostInt32(0);
            Tran.AddASCIIString("");

            Tran.AddFloat(0.0f);
            Tran.AddFloat(0.0f);
            Tran.AddFloat(0.0f);
            Tran.AddFloat(0.0f);

            Tran.AddHostInt32(0);
            Tran.AddHostInt32(-1);
            Tran.AddHostInt32(0);
            Tran.AddBoolean(true);
            Tran.AddHostUInt64(0);
            Tran.AddHostInt32(2);
            Tran.AddFloat(0.0f);

            Tran.AddHostInt32(0); // Target

            Tran.AddHostInt32(0); // CharacterVariables

            Tran.AddHostInt32(0);
            Tran.AddFloat(0.0f);

            Tran.AddFloat(0.0f); // Unknown54, float[4]
            Tran.AddFloat(0.0f);
            Tran.AddFloat(0.0f);
            Tran.AddFloat(0.0f);

            Tran.AddHostInt32(0); // Unknown
            Tran.AddFloat(0.0f); // Unknown
            Tran.AddFloat(0.0f); // Unknown
            Tran.AddFloat(0.0f); // Unknown
            Tran.AddASCIIString(""); // Unknown
            Tran.AddASCIIString(""); // Unknown
            Tran.AddASCIIString(""); // Unknown
            Tran.AddBoolean(false); // Unknown
            Tran.AddHostInt32(0); // Unknown
            Tran.AddHostInt32(0); // Unknown
            Tran.AddHostInt32(0); // Unknown
            Tran.AddHostInt32(8); // Unknown
            Tran.AddHostInt32(0); // Unknown
            Tran.AddHostInt32(3442); // Unknown
            Tran.AddFloat(0.0f); // Unknown
            Tran.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Tran.GetRaw());

            var Diggy = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Diggy.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Diggy.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Diggy.AddHostInt32(432135); // Name ID
            Diggy.AddHostInt32(773); // Model ID
            Diggy.AddBoolean(false); // Unknown4
            Diggy.AddHostInt32(408679); // Unknown5
            Diggy.AddHostInt32(13951728); // Unknown6
            Diggy.AddHostInt32(1); // Unknown7
            Diggy.AddFloat(1.0f); // Unknown8

            // Position
            Diggy.AddFloat(-381.9044f);
            Diggy.AddFloat(-24.73721f);
            Diggy.AddFloat(-1242.068f);
            Diggy.AddFloat(1.0f);

            //Rotation
            Diggy.AddFloat(-0.9989412f);
            Diggy.AddFloat(0f);
            Diggy.AddFloat(-0.04600667f);
            Diggy.AddFloat(0f);

            Diggy.AddHostInt32(1); // Unknown11

            Diggy.AddHostInt32(0); // CharacterAttachmentDataCount
            Diggy.AddHostInt32(1); // Unknown12

            Diggy.AddASCIIString(""); // TextureAlias
            Diggy.AddASCIIString(""); // TintAlias
            Diggy.AddHostInt32(0); // TintId
            Diggy.AddBoolean(true); // Unknown16
            Diggy.AddFloat(0f); // Unknown17
            Diggy.AddHostInt32(0); // Unknown18
            Diggy.AddHostInt32(0); // Unknown19
            Diggy.AddASCIIString("Diggy"); // Custom Name
            Diggy.AddBoolean(false); // NameDisabled
            Diggy.AddHostInt32(0); // Unknown22
            Diggy.AddFloat(0.0f); // Unknown23
            Diggy.AddFloat(0.0f); // Unknown24
            Diggy.AddHostInt32(0); // Unknown25
            Diggy.AddBoolean(false); // Unknown26
            Diggy.AddFloat(0.0f); // Unknown27
            Diggy.AddBoolean(false); // Unknown28
            Diggy.AddHostInt32(100); // Unknown29
            Diggy.AddHostInt32(-1); // Unknown
            Diggy.AddHostInt32(-1); // Unknown
            Diggy.AddHostInt32(-1); // Unknown
            Diggy.AddBoolean(false); // Unknown
            Diggy.AddBoolean(false); // Unknown
            Diggy.AddHostInt32(-1); // Unknown
            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddHostInt32(0); // Unknown

            Diggy.AddHostInt32(0); // EffectTagsCount

            Diggy.AddBoolean(false); // Unknown
            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddBoolean(false); // Unknown
            Diggy.AddBoolean(false); // Unknown
            Diggy.AddBoolean(false); // Unknown
            Diggy.AddBoolean(false); // Unknown

            Diggy.AddHostInt32(0); // UnknownStruct2
            Diggy.AddASCIIString("");
            Diggy.AddASCIIString("");
            Diggy.AddHostInt32(0);
            Diggy.AddASCIIString("");

            Diggy.AddFloat(0.0f);
            Diggy.AddFloat(0.0f);
            Diggy.AddFloat(0.0f);
            Diggy.AddFloat(0.0f);

            Diggy.AddHostInt32(0);
            Diggy.AddHostInt32(-1);
            Diggy.AddHostInt32(0);
            Diggy.AddBoolean(true);
            Diggy.AddHostUInt64(0);
            Diggy.AddHostInt32(2);
            Diggy.AddFloat(0.0f);

            Diggy.AddHostInt32(0); // Target

            Diggy.AddHostInt32(0); // CharacterVariables

            Diggy.AddHostInt32(0);
            Diggy.AddFloat(0.0f);

            Diggy.AddFloat(0.0f); // Unknown54, float[4]
            Diggy.AddFloat(0.0f);
            Diggy.AddFloat(0.0f);
            Diggy.AddFloat(0.0f);

            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddFloat(0.0f); // Unknown
            Diggy.AddFloat(0.0f); // Unknown
            Diggy.AddFloat(0.0f); // Unknown
            Diggy.AddASCIIString(""); // Unknown
            Diggy.AddASCIIString(""); // Unknown
            Diggy.AddASCIIString(""); // Unknown
            Diggy.AddBoolean(false); // Unknown
            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddHostInt32(8); // Unknown
            Diggy.AddHostInt32(0); // Unknown
            Diggy.AddHostInt32(3442); // Unknown
            Diggy.AddFloat(0.0f); // Unknown
            Diggy.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Diggy.GetRaw());

            var RoyalGuard = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            RoyalGuard.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            RoyalGuard.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            RoyalGuard.AddHostInt32(432135); // Name ID
            RoyalGuard.AddHostInt32(345); // Model ID
            RoyalGuard.AddBoolean(false); // Unknown4
            RoyalGuard.AddHostInt32(408679); // Unknown5
            RoyalGuard.AddHostInt32(13951728); // Unknown6
            RoyalGuard.AddHostInt32(1); // Unknown7
            RoyalGuard.AddFloat(1.0f); // Unknown8

            // Position
            RoyalGuard.AddFloat(-1223.167f);
            RoyalGuard.AddFloat(2.821261f);
            RoyalGuard.AddFloat(301.6066f);
            RoyalGuard.AddFloat(1.0f);

            //Rotation
            RoyalGuard.AddFloat(-0.9906564f);
            RoyalGuard.AddFloat(0f);
            RoyalGuard.AddFloat(0.1363817f);
            RoyalGuard.AddFloat(0f);

            RoyalGuard.AddHostInt32(0); // Unknown11

            RoyalGuard.AddHostInt32(0); // CharacterAttachmentDataCount
            RoyalGuard.AddHostInt32(1); // Unknown12

            RoyalGuard.AddASCIIString(""); // TextureAlias
            RoyalGuard.AddASCIIString(""); // TintAlias
            RoyalGuard.AddHostInt32(0); // TintId
            RoyalGuard.AddBoolean(true); // Unknown16
            RoyalGuard.AddFloat(-0.1f); // Unknown17
            RoyalGuard.AddHostInt32(0); // Unknown18
            RoyalGuard.AddHostInt32(0); // Unknown19
            RoyalGuard.AddASCIIString(""); // Custom Name
            RoyalGuard.AddBoolean(true); // NameDisabled
            RoyalGuard.AddHostInt32(0); // Unknown22
            RoyalGuard.AddFloat(0.0f); // Unknown23
            RoyalGuard.AddFloat(0.0f); // Unknown24
            RoyalGuard.AddHostInt32(0); // Unknown25
            RoyalGuard.AddBoolean(false); // Unknown26
            RoyalGuard.AddFloat(0.0f); // Unknown27
            RoyalGuard.AddBoolean(false); // Unknown28
            RoyalGuard.AddHostInt32(100); // Unknown29
            RoyalGuard.AddHostInt32(-1); // Unknown
            RoyalGuard.AddHostInt32(-1); // Unknown
            RoyalGuard.AddHostInt32(-1); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddHostInt32(-1); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown

            RoyalGuard.AddHostInt32(0); // EffectTagsCount

            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown

            RoyalGuard.AddHostInt32(0); // UnknownStruct2
            RoyalGuard.AddASCIIString("");
            RoyalGuard.AddASCIIString("");
            RoyalGuard.AddHostInt32(0);
            RoyalGuard.AddASCIIString("");

            RoyalGuard.AddFloat(0.0f);
            RoyalGuard.AddFloat(0.0f);
            RoyalGuard.AddFloat(0.0f);
            RoyalGuard.AddFloat(0.0f);

            RoyalGuard.AddHostInt32(0);
            RoyalGuard.AddHostInt32(-1);
            RoyalGuard.AddHostInt32(0);
            RoyalGuard.AddBoolean(true);
            RoyalGuard.AddHostUInt64(0);
            RoyalGuard.AddHostInt32(2);
            RoyalGuard.AddFloat(0.0f);

            RoyalGuard.AddHostInt32(0); // Target

            RoyalGuard.AddHostInt32(0); // CharacterVariables

            RoyalGuard.AddHostInt32(0);
            RoyalGuard.AddFloat(0.0f);

            RoyalGuard.AddFloat(0.0f); // Unknown54, float[4]
            RoyalGuard.AddFloat(0.0f);
            RoyalGuard.AddFloat(0.0f);
            RoyalGuard.AddFloat(0.0f);

            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddFloat(0.0f); // Unknown
            RoyalGuard.AddFloat(0.0f); // Unknown
            RoyalGuard.AddFloat(0.0f); // Unknown
            RoyalGuard.AddASCIIString(""); // Unknown
            RoyalGuard.AddASCIIString(""); // Unknown
            RoyalGuard.AddASCIIString(""); // Unknown
            RoyalGuard.AddBoolean(false); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddHostInt32(8); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown
            RoyalGuard.AddHostInt32(3442); // Unknown
            RoyalGuard.AddFloat(0.0f); // Unknown
            RoyalGuard.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, RoyalGuard.GetRaw());

            var RoyalGuard1 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            RoyalGuard1.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            RoyalGuard1.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            RoyalGuard1.AddHostInt32(432135); // Name ID
            RoyalGuard1.AddHostInt32(345); // Model ID
            RoyalGuard1.AddBoolean(false); // Unknown4
            RoyalGuard1.AddHostInt32(408679); // Unknown5
            RoyalGuard1.AddHostInt32(13951728); // Unknown6
            RoyalGuard1.AddHostInt32(1); // Unknown7
            RoyalGuard1.AddFloat(1.0f); // Unknown8

            // Position
            RoyalGuard1.AddFloat(-1223.848f);
            RoyalGuard1.AddFloat(2.887377f);
            RoyalGuard1.AddFloat(314.1966f);
            RoyalGuard1.AddFloat(1.0f);

            //Rotation
            RoyalGuard1.AddFloat(-0.996483f);
            RoyalGuard1.AddFloat(0f);
            RoyalGuard1.AddFloat(-0.08444295f);
            RoyalGuard1.AddFloat(0f);

            RoyalGuard1.AddHostInt32(0); // Unknown11

            RoyalGuard1.AddHostInt32(0); // CharacterAttachmentDataCount
            RoyalGuard1.AddHostInt32(1); // Unknown12

            RoyalGuard1.AddASCIIString(""); // TextureAlias
            RoyalGuard1.AddASCIIString(""); // TintAlias
            RoyalGuard1.AddHostInt32(0); // TintId
            RoyalGuard1.AddBoolean(true); // Unknown16
            RoyalGuard1.AddFloat(-0.1f); // Unknown17
            RoyalGuard1.AddHostInt32(0); // Unknown18
            RoyalGuard1.AddHostInt32(0); // Unknown19
            RoyalGuard1.AddASCIIString(""); // Custom Name
            RoyalGuard1.AddBoolean(true); // NameDisabled
            RoyalGuard1.AddHostInt32(0); // Unknown22
            RoyalGuard1.AddFloat(0.0f); // Unknown23
            RoyalGuard1.AddFloat(0.0f); // Unknown24
            RoyalGuard1.AddHostInt32(0); // Unknown25
            RoyalGuard1.AddBoolean(false); // Unknown26
            RoyalGuard1.AddFloat(0.0f); // Unknown27
            RoyalGuard1.AddBoolean(false); // Unknown28
            RoyalGuard1.AddHostInt32(100); // Unknown29
            RoyalGuard1.AddHostInt32(-1); // Unknown
            RoyalGuard1.AddHostInt32(-1); // Unknown
            RoyalGuard1.AddHostInt32(-1); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddHostInt32(-1); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown

            RoyalGuard1.AddHostInt32(0); // EffectTagsCount

            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown

            RoyalGuard1.AddHostInt32(0); // UnknownStruct2
            RoyalGuard1.AddASCIIString("");
            RoyalGuard1.AddASCIIString("");
            RoyalGuard1.AddHostInt32(0);
            RoyalGuard1.AddASCIIString("");

            RoyalGuard1.AddFloat(0.0f);
            RoyalGuard1.AddFloat(0.0f);
            RoyalGuard1.AddFloat(0.0f);
            RoyalGuard1.AddFloat(0.0f);

            RoyalGuard1.AddHostInt32(0);
            RoyalGuard1.AddHostInt32(-1);
            RoyalGuard1.AddHostInt32(0);
            RoyalGuard1.AddBoolean(true);
            RoyalGuard1.AddHostUInt64(0);
            RoyalGuard1.AddHostInt32(2);
            RoyalGuard1.AddFloat(0.0f);

            RoyalGuard1.AddHostInt32(0); // Target

            RoyalGuard1.AddHostInt32(0); // CharacterVariables

            RoyalGuard1.AddHostInt32(0);
            RoyalGuard1.AddFloat(0.0f);

            RoyalGuard1.AddFloat(0.0f); // Unknown54, float[4]
            RoyalGuard1.AddFloat(0.0f);
            RoyalGuard1.AddFloat(0.0f);
            RoyalGuard1.AddFloat(0.0f);

            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddFloat(0.0f); // Unknown
            RoyalGuard1.AddFloat(0.0f); // Unknown
            RoyalGuard1.AddFloat(0.0f); // Unknown
            RoyalGuard1.AddASCIIString(""); // Unknown
            RoyalGuard1.AddASCIIString(""); // Unknown
            RoyalGuard1.AddASCIIString(""); // Unknown
            RoyalGuard1.AddBoolean(false); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddHostInt32(8); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown
            RoyalGuard1.AddHostInt32(3442); // Unknown
            RoyalGuard1.AddFloat(0.0f); // Unknown
            RoyalGuard1.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, RoyalGuard1.GetRaw());

            var SgFairy2 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            SgFairy2.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            SgFairy2.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            SgFairy2.AddHostInt32(432135); // Name ID
            SgFairy2.AddHostInt32(468); // Model ID
            SgFairy2.AddBoolean(false); // Unknown4
            SgFairy2.AddHostInt32(408679); // Unknown5
            SgFairy2.AddHostInt32(13951728); // Unknown6
            SgFairy2.AddHostInt32(1); // Unknown7
            SgFairy2.AddFloat(1.0f); // Unknown8

            // Position
            SgFairy2.AddFloat(27.68476f);
            SgFairy2.AddFloat(38.69981f);
            SgFairy2.AddFloat(1059.56f);
            SgFairy2.AddFloat(1.0f);

            //Rotation
            SgFairy2.AddFloat(-0.9640236f);
            SgFairy2.AddFloat(0f);
            SgFairy2.AddFloat(-0.2658164f);
            SgFairy2.AddFloat(0f);

            SgFairy2.AddHostInt32(1); // Unknown11

            SgFairy2.AddHostInt32(0); // CharacterAttachmentDataCount
            SgFairy2.AddHostInt32(1); // Unknown12

            SgFairy2.AddASCIIString("base_03"); // TextureAlias
            SgFairy2.AddASCIIString("olive"); // TintAlias
            SgFairy2.AddHostInt32(0); // TintId
            SgFairy2.AddBoolean(true); // Unknown16
            SgFairy2.AddFloat(0f); // Unknown17
            SgFairy2.AddHostInt32(0); // Unknown18
            SgFairy2.AddHostInt32(0); // Unknown19
            SgFairy2.AddASCIIString(""); // Custom Name
            SgFairy2.AddBoolean(true); // NameDisabled
            SgFairy2.AddHostInt32(0); // Unknown22
            SgFairy2.AddFloat(0.0f); // Unknown23
            SgFairy2.AddFloat(0.0f); // Unknown24
            SgFairy2.AddHostInt32(0); // Unknown25
            SgFairy2.AddBoolean(false); // Unknown26
            SgFairy2.AddFloat(0.0f); // Unknown27
            SgFairy2.AddBoolean(false); // Unknown28
            SgFairy2.AddHostInt32(100); // Unknown29
            SgFairy2.AddHostInt32(-1); // Unknown
            SgFairy2.AddHostInt32(-1); // Unknown
            SgFairy2.AddHostInt32(-1); // Unknown
            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddHostInt32(-1); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown

            SgFairy2.AddHostInt32(0); // EffectTagsCount

            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddBoolean(false); // Unknown

            SgFairy2.AddHostInt32(0); // UnknownStruct2
            SgFairy2.AddASCIIString("");
            SgFairy2.AddASCIIString("");
            SgFairy2.AddHostInt32(0);
            SgFairy2.AddASCIIString("");

            SgFairy2.AddFloat(0.0f);
            SgFairy2.AddFloat(0.0f);
            SgFairy2.AddFloat(0.0f);
            SgFairy2.AddFloat(0.0f);

            SgFairy2.AddHostInt32(0);
            SgFairy2.AddHostInt32(-1);
            SgFairy2.AddHostInt32(0);
            SgFairy2.AddBoolean(true);
            SgFairy2.AddHostUInt64(0);
            SgFairy2.AddHostInt32(2);
            SgFairy2.AddFloat(0.0f);

            SgFairy2.AddHostInt32(0); // Target

            SgFairy2.AddHostInt32(0); // CharacterVariables

            SgFairy2.AddHostInt32(0);
            SgFairy2.AddFloat(0.0f);

            SgFairy2.AddFloat(0.0f); // Unknown54, float[4]
            SgFairy2.AddFloat(0.0f);
            SgFairy2.AddFloat(0.0f);
            SgFairy2.AddFloat(0.0f);

            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddFloat(0.0f); // Unknown
            SgFairy2.AddFloat(0.0f); // Unknown
            SgFairy2.AddFloat(0.0f); // Unknown
            SgFairy2.AddASCIIString(""); // Unknown
            SgFairy2.AddASCIIString(""); // Unknown
            SgFairy2.AddASCIIString(""); // Unknown
            SgFairy2.AddBoolean(false); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddHostInt32(8); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown
            SgFairy2.AddHostInt32(3442); // Unknown
            SgFairy2.AddFloat(0.0f); // Unknown
            SgFairy2.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, SgFairy2.GetRaw());

            var SgFairy = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            SgFairy.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            SgFairy.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            SgFairy.AddHostInt32(432135); // Name ID
            SgFairy.AddHostInt32(468); // Model ID
            SgFairy.AddBoolean(false); // Unknown4
            SgFairy.AddHostInt32(408679); // Unknown5
            SgFairy.AddHostInt32(13951728); // Unknown6
            SgFairy.AddHostInt32(1); // Unknown7
            SgFairy.AddFloat(1.0f); // Unknown8

            // Position
            SgFairy.AddFloat(25.58148f);
            SgFairy.AddFloat(38.72248f);
            SgFairy.AddFloat(1058.786f);
            SgFairy.AddFloat(1.0f);

            //Rotation
            SgFairy.AddFloat(0.9529561f);
            SgFairy.AddFloat(0f);
            SgFairy.AddFloat(0.3031081f);
            SgFairy.AddFloat(0f);

            SgFairy.AddHostInt32(1); // Unknown11

            SgFairy.AddHostInt32(0); // CharacterAttachmentDataCount
            SgFairy.AddHostInt32(1); // Unknown12

            SgFairy.AddASCIIString("base_02"); // TextureAlias
            SgFairy.AddASCIIString("mahogany"); // TintAlias
            SgFairy.AddHostInt32(0); // TintId
            SgFairy.AddBoolean(true); // Unknown16
            SgFairy.AddFloat(0f); // Unknown17
            SgFairy.AddHostInt32(0); // Unknown18
            SgFairy.AddHostInt32(0); // Unknown19
            SgFairy.AddASCIIString(""); // Custom Name
            SgFairy.AddBoolean(true); // NameDisabled
            SgFairy.AddHostInt32(0); // Unknown22
            SgFairy.AddFloat(0.0f); // Unknown23
            SgFairy.AddFloat(0.0f); // Unknown24
            SgFairy.AddHostInt32(0); // Unknown25
            SgFairy.AddBoolean(false); // Unknown26
            SgFairy.AddFloat(0.0f); // Unknown27
            SgFairy.AddBoolean(false); // Unknown28
            SgFairy.AddHostInt32(100); // Unknown29
            SgFairy.AddHostInt32(-1); // Unknown
            SgFairy.AddHostInt32(-1); // Unknown
            SgFairy.AddHostInt32(-1); // Unknown
            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddHostInt32(-1); // Unknown
            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddHostInt32(0); // Unknown

            SgFairy.AddHostInt32(0); // EffectTagsCount

            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddBoolean(false); // Unknown

            SgFairy.AddHostInt32(0); // UnknownStruct2
            SgFairy.AddASCIIString("");
            SgFairy.AddASCIIString("");
            SgFairy.AddHostInt32(0);
            SgFairy.AddASCIIString("");

            SgFairy.AddFloat(0.0f);
            SgFairy.AddFloat(0.0f);
            SgFairy.AddFloat(0.0f);
            SgFairy.AddFloat(0.0f);

            SgFairy.AddHostInt32(0);
            SgFairy.AddHostInt32(-1);
            SgFairy.AddHostInt32(0);
            SgFairy.AddBoolean(true);
            SgFairy.AddHostUInt64(0);
            SgFairy.AddHostInt32(2);
            SgFairy.AddFloat(0.0f);

            SgFairy.AddHostInt32(0); // Target

            SgFairy.AddHostInt32(0); // CharacterVariables

            SgFairy.AddHostInt32(0);
            SgFairy.AddFloat(0.0f);

            SgFairy.AddFloat(0.0f); // Unknown54, float[4]
            SgFairy.AddFloat(0.0f);
            SgFairy.AddFloat(0.0f);
            SgFairy.AddFloat(0.0f);

            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddFloat(0.0f); // Unknown
            SgFairy.AddFloat(0.0f); // Unknown
            SgFairy.AddFloat(0.0f); // Unknown
            SgFairy.AddASCIIString(""); // Unknown
            SgFairy.AddASCIIString(""); // Unknown
            SgFairy.AddASCIIString(""); // Unknown
            SgFairy.AddBoolean(false); // Unknown
            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddHostInt32(8); // Unknown
            SgFairy.AddHostInt32(0); // Unknown
            SgFairy.AddHostInt32(3442); // Unknown
            SgFairy.AddFloat(0.0f); // Unknown
            SgFairy.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, SgFairy.GetRaw());

        }
    }
}
