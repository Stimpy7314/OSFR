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

            RoyalGuard.AddHostInt32(1); // Unknown11

            RoyalGuard.AddHostInt32(0); // CharacterAttachmentDataCount
            RoyalGuard.AddHostInt32(1); // Unknown12

            RoyalGuard.AddASCIIString(""); // TextureAlias
            RoyalGuard.AddASCIIString(""); // TintAlias
            RoyalGuard.AddHostInt32(0); // TintId
            RoyalGuard.AddBoolean(true); // Unknown16
            RoyalGuard.AddFloat(0f); // Unknown17
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

            RoyalGuard1.AddHostInt32(1); // Unknown11

            RoyalGuard1.AddHostInt32(0); // CharacterAttachmentDataCount
            RoyalGuard1.AddHostInt32(1); // Unknown12

            RoyalGuard1.AddASCIIString(""); // TextureAlias
            RoyalGuard1.AddASCIIString(""); // TintAlias
            RoyalGuard1.AddHostInt32(0); // TintId
            RoyalGuard1.AddBoolean(true); // Unknown16
            RoyalGuard1.AddFloat(0f); // Unknown17
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

            var Cow = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Cow.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Cow.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Cow.AddHostInt32(432135); // Name ID
            Cow.AddHostInt32(3238); // Model ID
            Cow.AddBoolean(false); // Unknown4
            Cow.AddHostInt32(408679); // Unknown5
            Cow.AddHostInt32(13951728); // Unknown6
            Cow.AddHostInt32(1); // Unknown7
            Cow.AddFloat(1.0f); // Unknown8

            // Position
            Cow.AddFloat(-60.71404f);
            Cow.AddFloat(3.801707f);
            Cow.AddFloat(313.341f);
            Cow.AddFloat(1.0f);

            //Rotation
            Cow.AddFloat(0.3939879f);
            Cow.AddFloat(0f);
            Cow.AddFloat(-0.9191157f);
            Cow.AddFloat(0f);

            Cow.AddHostInt32(1); // Unknown11

            Cow.AddHostInt32(0); // CharacterAttachmentDataCount
            Cow.AddHostInt32(1); // Unknown12

            Cow.AddASCIIString(""); // TextureAlias
            Cow.AddASCIIString(""); // TintAlias
            Cow.AddHostInt32(0); // TintId
            Cow.AddBoolean(true); // Unknown16
            Cow.AddFloat(0f); // Unknown17
            Cow.AddHostInt32(0); // Unknown18
            Cow.AddHostInt32(0); // Unknown19
            Cow.AddASCIIString("Cow"); // Custom Name
            Cow.AddBoolean(false); // NameDisabled
            Cow.AddHostInt32(0); // Unknown22
            Cow.AddFloat(0.0f); // Unknown23
            Cow.AddFloat(0.0f); // Unknown24
            Cow.AddHostInt32(0); // Unknown25
            Cow.AddBoolean(false); // Unknown26
            Cow.AddFloat(0.0f); // Unknown27
            Cow.AddBoolean(false); // Unknown28
            Cow.AddHostInt32(100); // Unknown29
            Cow.AddHostInt32(-1); // Unknown
            Cow.AddHostInt32(-1); // Unknown
            Cow.AddHostInt32(-1); // Unknown
            Cow.AddBoolean(false); // Unknown
            Cow.AddBoolean(false); // Unknown
            Cow.AddHostInt32(-1); // Unknown
            Cow.AddHostInt32(0); // Unknown
            Cow.AddHostInt32(0); // Unknown

            Cow.AddHostInt32(0); // EffectTagsCount

            Cow.AddBoolean(false); // Unknown
            Cow.AddHostInt32(0); // Unknown
            Cow.AddBoolean(false); // Unknown
            Cow.AddBoolean(false); // Unknown
            Cow.AddBoolean(false); // Unknown
            Cow.AddBoolean(false); // Unknown

            Cow.AddHostInt32(0); // UnknownStruct2
            Cow.AddASCIIString("");
            Cow.AddASCIIString("");
            Cow.AddHostInt32(0);
            Cow.AddASCIIString("");

            Cow.AddFloat(0.0f);
            Cow.AddFloat(0.0f);
            Cow.AddFloat(0.0f);
            Cow.AddFloat(0.0f);

            Cow.AddHostInt32(0);
            Cow.AddHostInt32(-1);
            Cow.AddHostInt32(0);
            Cow.AddBoolean(true);
            Cow.AddHostUInt64(0);
            Cow.AddHostInt32(2);
            Cow.AddFloat(0.0f);

            Cow.AddHostInt32(0); // Target

            Cow.AddHostInt32(0); // CharacterVariables

            Cow.AddHostInt32(0);
            Cow.AddFloat(0.0f);

            Cow.AddFloat(0.0f); // Unknown54, float[4]
            Cow.AddFloat(0.0f);
            Cow.AddFloat(0.0f);
            Cow.AddFloat(0.0f);

            Cow.AddHostInt32(0); // Unknown
            Cow.AddFloat(0.0f); // Unknown
            Cow.AddFloat(0.0f); // Unknown
            Cow.AddFloat(0.0f); // Unknown
            Cow.AddASCIIString(""); // Unknown
            Cow.AddASCIIString(""); // Unknown
            Cow.AddASCIIString(""); // Unknown
            Cow.AddBoolean(false); // Unknown
            Cow.AddHostInt32(0); // Unknown
            Cow.AddHostInt32(0); // Unknown
            Cow.AddHostInt32(0); // Unknown
            Cow.AddHostInt32(8); // Unknown
            Cow.AddHostInt32(0); // Unknown
            Cow.AddHostInt32(3442); // Unknown
            Cow.AddFloat(0.0f); // Unknown
            Cow.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Cow.GetRaw());

            var HumanChild = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            HumanChild.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            HumanChild.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            HumanChild.AddHostInt32(432135); // Name ID
            HumanChild.AddHostInt32(7); // Model ID
            HumanChild.AddBoolean(false); // Unknown4
            HumanChild.AddHostInt32(408679); // Unknown5
            HumanChild.AddHostInt32(13951728); // Unknown6
            HumanChild.AddHostInt32(1); // Unknown7
            HumanChild.AddFloat(1.0f); // Unknown8

            // Position
            HumanChild.AddFloat(-449.6471f);
            HumanChild.AddFloat(-43.23875f);
            HumanChild.AddFloat(-1281.403f);
            HumanChild.AddFloat(1.0f);

            //Rotation
            HumanChild.AddFloat(0.5853468f);
            HumanChild.AddFloat(0f);
            HumanChild.AddFloat(-0.810783f);
            HumanChild.AddFloat(0f);

            HumanChild.AddHostInt32(1); // Unknown11

            HumanChild.AddHostInt32(0); // CharacterAttachmentDataCount
            HumanChild.AddHostInt32(1); // Unknown12

            HumanChild.AddASCIIString(""); // TextureAlias
            HumanChild.AddASCIIString(""); // TintAlias
            HumanChild.AddHostInt32(0); // TintId
            HumanChild.AddBoolean(true); // Unknown16
            HumanChild.AddFloat(0f); // Unknown17
            HumanChild.AddHostInt32(0); // Unknown18
            HumanChild.AddHostInt32(0); // Unknown19
            HumanChild.AddASCIIString("Ryanna"); // Custom Name
            HumanChild.AddBoolean(false); // NameDisabled
            HumanChild.AddHostInt32(0); // Unknown22
            HumanChild.AddFloat(0.0f); // Unknown23
            HumanChild.AddFloat(0.0f); // Unknown24
            HumanChild.AddHostInt32(0); // Unknown25
            HumanChild.AddBoolean(false); // Unknown26
            HumanChild.AddFloat(0.0f); // Unknown27
            HumanChild.AddBoolean(false); // Unknown28
            HumanChild.AddHostInt32(100); // Unknown29
            HumanChild.AddHostInt32(-1); // Unknown
            HumanChild.AddHostInt32(-1); // Unknown
            HumanChild.AddHostInt32(-1); // Unknown
            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddHostInt32(-1); // Unknown
            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddHostInt32(0); // Unknown

            HumanChild.AddHostInt32(0); // EffectTagsCount

            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddBoolean(false); // Unknown

            HumanChild.AddHostInt32(0); // UnknownStruct2
            HumanChild.AddASCIIString("");
            HumanChild.AddASCIIString("");
            HumanChild.AddHostInt32(0);
            HumanChild.AddASCIIString("");

            HumanChild.AddFloat(0.0f);
            HumanChild.AddFloat(0.0f);
            HumanChild.AddFloat(0.0f);
            HumanChild.AddFloat(0.0f);

            HumanChild.AddHostInt32(0);
            HumanChild.AddHostInt32(-1);
            HumanChild.AddHostInt32(0);
            HumanChild.AddBoolean(true);
            HumanChild.AddHostUInt64(0);
            HumanChild.AddHostInt32(2);
            HumanChild.AddFloat(0.0f);

            HumanChild.AddHostInt32(0); // Target

            HumanChild.AddHostInt32(0); // CharacterVariables

            HumanChild.AddHostInt32(0);
            HumanChild.AddFloat(0.0f);

            HumanChild.AddFloat(0.0f); // Unknown54, float[4]
            HumanChild.AddFloat(0.0f);
            HumanChild.AddFloat(0.0f);
            HumanChild.AddFloat(0.0f);

            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddFloat(0.0f); // Unknown
            HumanChild.AddFloat(0.0f); // Unknown
            HumanChild.AddFloat(0.0f); // Unknown
            HumanChild.AddASCIIString(""); // Unknown
            HumanChild.AddASCIIString(""); // Unknown
            HumanChild.AddASCIIString(""); // Unknown
            HumanChild.AddBoolean(false); // Unknown
            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddHostInt32(8); // Unknown
            HumanChild.AddHostInt32(0); // Unknown
            HumanChild.AddHostInt32(3442); // Unknown
            HumanChild.AddFloat(0.0f); // Unknown
            HumanChild.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, HumanChild.GetRaw());

            var HumanChild1 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            HumanChild1.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            HumanChild1.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            HumanChild1.AddHostInt32(432135); // Name ID
            HumanChild1.AddHostInt32(8); // Model ID
            HumanChild1.AddBoolean(false); // Unknown4
            HumanChild1.AddHostInt32(408679); // Unknown5
            HumanChild1.AddHostInt32(13951728); // Unknown6
            HumanChild1.AddHostInt32(1); // Unknown7
            HumanChild1.AddFloat(1.0f); // Unknown8

            // Position
            HumanChild1.AddFloat(-446.2711f);
            HumanChild1.AddFloat(-42.8582f);
            HumanChild1.AddFloat(-1280.999f);
            HumanChild1.AddFloat(1.0f);

            //Rotation
            HumanChild1.AddFloat(-0.526507f);
            HumanChild1.AddFloat(0f);
            HumanChild1.AddFloat(-0.8501708f);
            HumanChild1.AddFloat(0f);

            HumanChild1.AddHostInt32(1); // Unknown11

            HumanChild1.AddHostInt32(0); // CharacterAttachmentDataCount
            HumanChild1.AddHostInt32(1); // Unknown12

            HumanChild1.AddASCIIString(""); // TextureAlias
            HumanChild1.AddASCIIString(""); // TintAlias
            HumanChild1.AddHostInt32(0); // TintId
            HumanChild1.AddBoolean(true); // Unknown16
            HumanChild1.AddFloat(0f); // Unknown17
            HumanChild1.AddHostInt32(0); // Unknown18
            HumanChild1.AddHostInt32(0); // Unknown19
            HumanChild1.AddASCIIString("Leime"); // Custom Name
            HumanChild1.AddBoolean(false); // NameDisabled
            HumanChild1.AddHostInt32(0); // Unknown22
            HumanChild1.AddFloat(0.0f); // Unknown23
            HumanChild1.AddFloat(0.0f); // Unknown24
            HumanChild1.AddHostInt32(0); // Unknown25
            HumanChild1.AddBoolean(false); // Unknown26
            HumanChild1.AddFloat(0.0f); // Unknown27
            HumanChild1.AddBoolean(false); // Unknown28
            HumanChild1.AddHostInt32(100); // Unknown29
            HumanChild1.AddHostInt32(-1); // Unknown
            HumanChild1.AddHostInt32(-1); // Unknown
            HumanChild1.AddHostInt32(-1); // Unknown
            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddHostInt32(-1); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown

            HumanChild1.AddHostInt32(0); // EffectTagsCount

            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddBoolean(false); // Unknown

            HumanChild1.AddHostInt32(0); // UnknownStruct2
            HumanChild1.AddASCIIString("");
            HumanChild1.AddASCIIString("");
            HumanChild1.AddHostInt32(0);
            HumanChild1.AddASCIIString("");

            HumanChild1.AddFloat(0.0f);
            HumanChild1.AddFloat(0.0f);
            HumanChild1.AddFloat(0.0f);
            HumanChild1.AddFloat(0.0f);

            HumanChild1.AddHostInt32(0);
            HumanChild1.AddHostInt32(-1);
            HumanChild1.AddHostInt32(0);
            HumanChild1.AddBoolean(true);
            HumanChild1.AddHostUInt64(0);
            HumanChild1.AddHostInt32(2);
            HumanChild1.AddFloat(0.0f);

            HumanChild1.AddHostInt32(0); // Target

            HumanChild1.AddHostInt32(0); // CharacterVariables

            HumanChild1.AddHostInt32(0);
            HumanChild1.AddFloat(0.0f);

            HumanChild1.AddFloat(0.0f); // Unknown54, float[4]
            HumanChild1.AddFloat(0.0f);
            HumanChild1.AddFloat(0.0f);
            HumanChild1.AddFloat(0.0f);

            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddFloat(0.0f); // Unknown
            HumanChild1.AddFloat(0.0f); // Unknown
            HumanChild1.AddFloat(0.0f); // Unknown
            HumanChild1.AddASCIIString(""); // Unknown
            HumanChild1.AddASCIIString(""); // Unknown
            HumanChild1.AddASCIIString(""); // Unknown
            HumanChild1.AddBoolean(false); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddHostInt32(8); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown
            HumanChild1.AddHostInt32(3442); // Unknown
            HumanChild1.AddFloat(0.0f); // Unknown
            HumanChild1.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, HumanChild1.GetRaw());

            var Nikki = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Nikki.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Nikki.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Nikki.AddHostInt32(432135); // Name ID
            Nikki.AddHostInt32(826); // Model ID
            Nikki.AddBoolean(false); // Unknown4
            Nikki.AddHostInt32(408679); // Unknown5
            Nikki.AddHostInt32(13951728); // Unknown6
            Nikki.AddHostInt32(1); // Unknown7
            Nikki.AddFloat(1.0f); // Unknown8

            // Position
            Nikki.AddFloat(55.63669f);
            Nikki.AddFloat(30.58106f);
            Nikki.AddFloat(361.6285f);
            Nikki.AddFloat(1.0f);

            //Rotation
            Nikki.AddFloat(0.5590255f);
            Nikki.AddFloat(0f);
            Nikki.AddFloat(0.8291504f);
            Nikki.AddFloat(0f);

            Nikki.AddHostInt32(3333); // Unknown11

            Nikki.AddHostInt32(0); // CharacterAttachmentDataCount
            Nikki.AddHostInt32(1); // Unknown12

            Nikki.AddASCIIString(""); // TextureAlias
            Nikki.AddASCIIString(""); // TintAlias
            Nikki.AddHostInt32(0); // TintId
            Nikki.AddBoolean(true); // Unknown16
            Nikki.AddFloat(0f); // Unknown17
            Nikki.AddHostInt32(0); // Unknown18
            Nikki.AddHostInt32(0); // Unknown19
            Nikki.AddASCIIString("Nikki"); // Custom Name
            Nikki.AddBoolean(false); // NameDisabled
            Nikki.AddHostInt32(0); // Unknown22
            Nikki.AddFloat(0.0f); // Unknown23
            Nikki.AddFloat(0.0f); // Unknown24
            Nikki.AddHostInt32(0); // Unknown25
            Nikki.AddBoolean(false); // Unknown26
            Nikki.AddFloat(0.0f); // Unknown27
            Nikki.AddBoolean(false); // Unknown28
            Nikki.AddHostInt32(100); // Unknown29
            Nikki.AddHostInt32(-1); // Unknown
            Nikki.AddHostInt32(-1); // Unknown
            Nikki.AddHostInt32(-1); // Unknown
            Nikki.AddBoolean(false); // Unknown
            Nikki.AddBoolean(false); // Unknown
            Nikki.AddHostInt32(-1); // Unknown
            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddHostInt32(0); // Unknown

            Nikki.AddHostInt32(0); // EffectTagsCount

            Nikki.AddBoolean(false); // Unknown
            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddBoolean(false); // Unknown
            Nikki.AddBoolean(false); // Unknown
            Nikki.AddBoolean(false); // Unknown
            Nikki.AddBoolean(false); // Unknown

            Nikki.AddHostInt32(0); // UnknownStruct2
            Nikki.AddASCIIString("");
            Nikki.AddASCIIString("");
            Nikki.AddHostInt32(0);
            Nikki.AddASCIIString("");

            Nikki.AddFloat(0.0f);
            Nikki.AddFloat(0.0f);
            Nikki.AddFloat(0.0f);
            Nikki.AddFloat(0.0f);

            Nikki.AddHostInt32(0);
            Nikki.AddHostInt32(-1);
            Nikki.AddHostInt32(0);
            Nikki.AddBoolean(true);
            Nikki.AddHostUInt64(0);
            Nikki.AddHostInt32(2);
            Nikki.AddFloat(0.0f);

            Nikki.AddHostInt32(0); // Target

            Nikki.AddHostInt32(0); // CharacterVariables

            Nikki.AddHostInt32(0);
            Nikki.AddFloat(0.0f);

            Nikki.AddFloat(0.0f); // Unknown54, float[4]
            Nikki.AddFloat(0.0f);
            Nikki.AddFloat(0.0f);
            Nikki.AddFloat(0.0f);

            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddFloat(0.0f); // Unknown
            Nikki.AddFloat(0.0f); // Unknown
            Nikki.AddFloat(0.0f); // Unknown
            Nikki.AddASCIIString(""); // Unknown
            Nikki.AddASCIIString(""); // Unknown
            Nikki.AddASCIIString(""); // Unknown
            Nikki.AddBoolean(false); // Unknown
            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddHostInt32(8); // Unknown
            Nikki.AddHostInt32(0); // Unknown
            Nikki.AddHostInt32(3442); // Unknown
            Nikki.AddFloat(0.0f); // Unknown
            Nikki.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Nikki.GetRaw());

            var FarmerCoin6 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            FarmerCoin6.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            FarmerCoin6.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            FarmerCoin6.AddHostInt32(432135); // Name ID
            FarmerCoin6.AddHostInt32(488); // Model ID
            FarmerCoin6.AddBoolean(false); // Unknown4
            FarmerCoin6.AddHostInt32(408679); // Unknown5
            FarmerCoin6.AddHostInt32(13951728); // Unknown6
            FarmerCoin6.AddHostInt32(1); // Unknown7
            FarmerCoin6.AddFloat(1.0f); // Unknown8

            // Position
            FarmerCoin6.AddFloat(99.52658f);
            FarmerCoin6.AddFloat(22.78155f);
            FarmerCoin6.AddFloat(328.4302f);
            FarmerCoin6.AddFloat(1.0f);

            //Rotation
            FarmerCoin6.AddFloat(-0.2478341f);
            FarmerCoin6.AddFloat(0f);
            FarmerCoin6.AddFloat(0.9688025f);
            FarmerCoin6.AddFloat(0f);

            FarmerCoin6.AddHostInt32(1); // Unknown11

            FarmerCoin6.AddHostInt32(0); // CharacterAttachmentDataCount
            FarmerCoin6.AddHostInt32(1); // Unknown12

            FarmerCoin6.AddASCIIString(""); // TextureAlias
            FarmerCoin6.AddASCIIString(""); // TintAlias
            FarmerCoin6.AddHostInt32(0); // TintId
            FarmerCoin6.AddBoolean(true); // Unknown16
            FarmerCoin6.AddFloat(0f); // Unknown17
            FarmerCoin6.AddHostInt32(0); // Unknown18
            FarmerCoin6.AddHostInt32(0); // Unknown19
            FarmerCoin6.AddASCIIString("Coin Farmer Lubag"); // Custom Name
            FarmerCoin6.AddBoolean(false); // NameDisabled
            FarmerCoin6.AddHostInt32(0); // Unknown22
            FarmerCoin6.AddFloat(0.0f); // Unknown23
            FarmerCoin6.AddFloat(0.0f); // Unknown24
            FarmerCoin6.AddHostInt32(0); // Unknown25
            FarmerCoin6.AddBoolean(false); // Unknown26
            FarmerCoin6.AddFloat(0.0f); // Unknown27
            FarmerCoin6.AddBoolean(false); // Unknown28
            FarmerCoin6.AddHostInt32(100); // Unknown29
            FarmerCoin6.AddHostInt32(-1); // Unknown
            FarmerCoin6.AddHostInt32(-1); // Unknown
            FarmerCoin6.AddHostInt32(-1); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddHostInt32(-1); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown

            FarmerCoin6.AddHostInt32(0); // EffectTagsCount

            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown

            FarmerCoin6.AddHostInt32(0); // UnknownStruct2
            FarmerCoin6.AddASCIIString("");
            FarmerCoin6.AddASCIIString("");
            FarmerCoin6.AddHostInt32(0);
            FarmerCoin6.AddASCIIString("");

            FarmerCoin6.AddFloat(0.0f);
            FarmerCoin6.AddFloat(0.0f);
            FarmerCoin6.AddFloat(0.0f);
            FarmerCoin6.AddFloat(0.0f);

            FarmerCoin6.AddHostInt32(0);
            FarmerCoin6.AddHostInt32(-1);
            FarmerCoin6.AddHostInt32(0);
            FarmerCoin6.AddBoolean(true);
            FarmerCoin6.AddHostUInt64(0);
            FarmerCoin6.AddHostInt32(2);
            FarmerCoin6.AddFloat(0.0f);

            FarmerCoin6.AddHostInt32(0); // Target

            FarmerCoin6.AddHostInt32(0); // CharacterVariables

            FarmerCoin6.AddHostInt32(0);
            FarmerCoin6.AddFloat(0.0f);

            FarmerCoin6.AddFloat(0.0f); // Unknown54, float[4]
            FarmerCoin6.AddFloat(0.0f);
            FarmerCoin6.AddFloat(0.0f);
            FarmerCoin6.AddFloat(0.0f);

            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddFloat(0.0f); // Unknown
            FarmerCoin6.AddFloat(0.0f); // Unknown
            FarmerCoin6.AddFloat(0.0f); // Unknown
            FarmerCoin6.AddASCIIString(""); // Unknown
            FarmerCoin6.AddASCIIString(""); // Unknown
            FarmerCoin6.AddASCIIString(""); // Unknown
            FarmerCoin6.AddBoolean(false); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddHostInt32(8); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown
            FarmerCoin6.AddHostInt32(3442); // Unknown
            FarmerCoin6.AddFloat(0.0f); // Unknown
            FarmerCoin6.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, FarmerCoin6.GetRaw());

            var RoyalGuard2 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            RoyalGuard2.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            RoyalGuard2.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            RoyalGuard2.AddHostInt32(432135); // Name ID
            RoyalGuard2.AddHostInt32(345); // Model ID
            RoyalGuard2.AddBoolean(false); // Unknown4
            RoyalGuard2.AddHostInt32(408679); // Unknown5
            RoyalGuard2.AddHostInt32(13951728); // Unknown6
            RoyalGuard2.AddHostInt32(1); // Unknown7
            RoyalGuard2.AddFloat(1.0f); // Unknown8

            // Position
            RoyalGuard2.AddFloat(-1478.491f);
            RoyalGuard2.AddFloat(-33.0747f);
            RoyalGuard2.AddFloat(337.7339f);
            RoyalGuard2.AddFloat(1.0f);

            //Rotation
            RoyalGuard2.AddFloat(-0.8210192f);
            RoyalGuard2.AddFloat(0f);
            RoyalGuard2.AddFloat(-0.5709004f);
            RoyalGuard2.AddFloat(0f);

            RoyalGuard2.AddHostInt32(1); // Unknown11

            RoyalGuard2.AddHostInt32(0); // CharacterAttachmentDataCount
            RoyalGuard2.AddHostInt32(1); // Unknown12

            RoyalGuard2.AddASCIIString(""); // TextureAlias
            RoyalGuard2.AddASCIIString(""); // TintAlias
            RoyalGuard2.AddHostInt32(0); // TintId
            RoyalGuard2.AddBoolean(true); // Unknown16
            RoyalGuard2.AddFloat(0f); // Unknown17
            RoyalGuard2.AddHostInt32(0); // Unknown18
            RoyalGuard2.AddHostInt32(0); // Unknown19
            RoyalGuard2.AddASCIIString("Sergeant Larkspur"); // Custom Name
            RoyalGuard2.AddBoolean(false); // NameDisabled
            RoyalGuard2.AddHostInt32(0); // Unknown22
            RoyalGuard2.AddFloat(0.0f); // Unknown23
            RoyalGuard2.AddFloat(0.0f); // Unknown24
            RoyalGuard2.AddHostInt32(0); // Unknown25
            RoyalGuard2.AddBoolean(false); // Unknown26
            RoyalGuard2.AddFloat(0.0f); // Unknown27
            RoyalGuard2.AddBoolean(false); // Unknown28
            RoyalGuard2.AddHostInt32(100); // Unknown29
            RoyalGuard2.AddHostInt32(-1); // Unknown
            RoyalGuard2.AddHostInt32(-1); // Unknown
            RoyalGuard2.AddHostInt32(-1); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddHostInt32(-1); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown

            RoyalGuard2.AddHostInt32(0); // EffectTagsCount

            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown

            RoyalGuard2.AddHostInt32(0); // UnknownStruct2
            RoyalGuard2.AddASCIIString("");
            RoyalGuard2.AddASCIIString("");
            RoyalGuard2.AddHostInt32(0);
            RoyalGuard2.AddASCIIString("");

            RoyalGuard2.AddFloat(0.0f);
            RoyalGuard2.AddFloat(0.0f);
            RoyalGuard2.AddFloat(0.0f);
            RoyalGuard2.AddFloat(0.0f);

            RoyalGuard2.AddHostInt32(0);
            RoyalGuard2.AddHostInt32(-1);
            RoyalGuard2.AddHostInt32(0);
            RoyalGuard2.AddBoolean(true);
            RoyalGuard2.AddHostUInt64(0);
            RoyalGuard2.AddHostInt32(2);
            RoyalGuard2.AddFloat(0.0f);

            RoyalGuard2.AddHostInt32(0); // Target

            RoyalGuard2.AddHostInt32(0); // CharacterVariables

            RoyalGuard2.AddHostInt32(0);
            RoyalGuard2.AddFloat(0.0f);

            RoyalGuard2.AddFloat(0.0f); // Unknown54, float[4]
            RoyalGuard2.AddFloat(0.0f);
            RoyalGuard2.AddFloat(0.0f);
            RoyalGuard2.AddFloat(0.0f);

            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddFloat(0.0f); // Unknown
            RoyalGuard2.AddFloat(0.0f); // Unknown
            RoyalGuard2.AddFloat(0.0f); // Unknown
            RoyalGuard2.AddASCIIString(""); // Unknown
            RoyalGuard2.AddASCIIString(""); // Unknown
            RoyalGuard2.AddASCIIString(""); // Unknown
            RoyalGuard2.AddBoolean(false); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddHostInt32(8); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown
            RoyalGuard2.AddHostInt32(3442); // Unknown
            RoyalGuard2.AddFloat(0.0f); // Unknown
            RoyalGuard2.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, RoyalGuard2.GetRaw());

            var Seaside1 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Seaside1.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Seaside1.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Seaside1.AddHostInt32(432135); // Name ID
            Seaside1.AddHostInt32(735); // Model ID
            Seaside1.AddBoolean(false); // Unknown4
            Seaside1.AddHostInt32(408679); // Unknown5
            Seaside1.AddHostInt32(13951728); // Unknown6
            Seaside1.AddHostInt32(1); // Unknown7
            Seaside1.AddFloat(1.0f); // Unknown8

            // Position
            Seaside1.AddFloat(-687.8656f);
            Seaside1.AddFloat(-13.99004f);
            Seaside1.AddFloat(-1240.246f);
            Seaside1.AddFloat(1.0f);

            //Rotation
            Seaside1.AddFloat(0.8474492f);
            Seaside1.AddFloat(0f);
            Seaside1.AddFloat(-0.5308765f);
            Seaside1.AddFloat(0f);

            Seaside1.AddHostInt32(3101); // Unknown11

            Seaside1.AddHostInt32(0); // CharacterAttachmentDataCount
            Seaside1.AddHostInt32(1); // Unknown12

            Seaside1.AddASCIIString(""); // TextureAlias
            Seaside1.AddASCIIString(""); // TintAlias
            Seaside1.AddHostInt32(0); // TintId
            Seaside1.AddBoolean(true); // Unknown16
            Seaside1.AddFloat(0f); // Unknown17
            Seaside1.AddHostInt32(0); // Unknown18
            Seaside1.AddHostInt32(0); // Unknown19
            Seaside1.AddASCIIString(""); // Custom Name
            Seaside1.AddBoolean(true); // NameDisabled
            Seaside1.AddHostInt32(0); // Unknown22
            Seaside1.AddFloat(0.0f); // Unknown23
            Seaside1.AddFloat(0.0f); // Unknown24
            Seaside1.AddHostInt32(0); // Unknown25
            Seaside1.AddBoolean(false); // Unknown26
            Seaside1.AddFloat(0.0f); // Unknown27
            Seaside1.AddBoolean(false); // Unknown28
            Seaside1.AddHostInt32(100); // Unknown29
            Seaside1.AddHostInt32(-1); // Unknown
            Seaside1.AddHostInt32(-1); // Unknown
            Seaside1.AddHostInt32(-1); // Unknown
            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddHostInt32(-1); // Unknown
            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddHostInt32(0); // Unknown

            Seaside1.AddHostInt32(0); // EffectTagsCount

            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddBoolean(false); // Unknown

            Seaside1.AddHostInt32(0); // UnknownStruct2
            Seaside1.AddASCIIString("");
            Seaside1.AddASCIIString("");
            Seaside1.AddHostInt32(0);
            Seaside1.AddASCIIString("");

            Seaside1.AddFloat(0.0f);
            Seaside1.AddFloat(0.0f);
            Seaside1.AddFloat(0.0f);
            Seaside1.AddFloat(0.0f);

            Seaside1.AddHostInt32(0);
            Seaside1.AddHostInt32(-1);
            Seaside1.AddHostInt32(0);
            Seaside1.AddBoolean(true);
            Seaside1.AddHostUInt64(0);
            Seaside1.AddHostInt32(2);
            Seaside1.AddFloat(0.0f);

            Seaside1.AddHostInt32(0); // Target

            Seaside1.AddHostInt32(0); // CharacterVariables

            Seaside1.AddHostInt32(0);
            Seaside1.AddFloat(0.0f);

            Seaside1.AddFloat(0.0f); // Unknown54, float[4]
            Seaside1.AddFloat(0.0f);
            Seaside1.AddFloat(0.0f);
            Seaside1.AddFloat(0.0f);

            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddFloat(0.0f); // Unknown
            Seaside1.AddFloat(0.0f); // Unknown
            Seaside1.AddFloat(0.0f); // Unknown
            Seaside1.AddASCIIString(""); // Unknown
            Seaside1.AddASCIIString(""); // Unknown
            Seaside1.AddASCIIString(""); // Unknown
            Seaside1.AddBoolean(false); // Unknown
            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddHostInt32(8); // Unknown
            Seaside1.AddHostInt32(0); // Unknown
            Seaside1.AddHostInt32(3442); // Unknown
            Seaside1.AddFloat(0.0f); // Unknown
            Seaside1.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Seaside1.GetRaw());

            var Seaside2 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Seaside2.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Seaside2.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Seaside2.AddHostInt32(432135); // Name ID
            Seaside2.AddHostInt32(735); // Model ID
            Seaside2.AddBoolean(false); // Unknown4
            Seaside2.AddHostInt32(408679); // Unknown5
            Seaside2.AddHostInt32(13951728); // Unknown6
            Seaside2.AddHostInt32(1); // Unknown7
            Seaside2.AddFloat(1.0f); // Unknown8

            // Position
            Seaside2.AddFloat(-680.2311f);
            Seaside2.AddFloat(4.59832f);
            Seaside2.AddFloat(-1044.006f);
            Seaside2.AddFloat(1.0f);

            //Rotation
            Seaside2.AddFloat(0.210759f);
            Seaside2.AddFloat(0f);
            Seaside2.AddFloat(-0.9775381f);
            Seaside2.AddFloat(0f);

            Seaside2.AddHostInt32(0); // Unknown11

            Seaside2.AddHostInt32(0); // CharacterAttachmentDataCount
            Seaside2.AddHostInt32(1); // Unknown12

            Seaside2.AddASCIIString(""); // TextureAlias
            Seaside2.AddASCIIString(""); // TintAlias
            Seaside2.AddHostInt32(0); // TintId
            Seaside2.AddBoolean(true); // Unknown16
            Seaside2.AddFloat(0f); // Unknown17
            Seaside2.AddHostInt32(0); // Unknown18
            Seaside2.AddHostInt32(0); // Unknown19
            Seaside2.AddASCIIString(""); // Custom Name
            Seaside2.AddBoolean(true); // NameDisabled
            Seaside2.AddHostInt32(0); // Unknown22
            Seaside2.AddFloat(0.0f); // Unknown23
            Seaside2.AddFloat(0.0f); // Unknown24
            Seaside2.AddHostInt32(0); // Unknown25
            Seaside2.AddBoolean(false); // Unknown26
            Seaside2.AddFloat(0.0f); // Unknown27
            Seaside2.AddBoolean(false); // Unknown28
            Seaside2.AddHostInt32(100); // Unknown29
            Seaside2.AddHostInt32(-1); // Unknown
            Seaside2.AddHostInt32(-1); // Unknown
            Seaside2.AddHostInt32(-1); // Unknown
            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddHostInt32(-1); // Unknown
            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddHostInt32(0); // Unknown

            Seaside2.AddHostInt32(0); // EffectTagsCount

            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddBoolean(false); // Unknown

            Seaside2.AddHostInt32(0); // UnknownStruct2
            Seaside2.AddASCIIString("");
            Seaside2.AddASCIIString("");
            Seaside2.AddHostInt32(0);
            Seaside2.AddASCIIString("");

            Seaside2.AddFloat(0.0f);
            Seaside2.AddFloat(0.0f);
            Seaside2.AddFloat(0.0f);
            Seaside2.AddFloat(0.0f);

            Seaside2.AddHostInt32(0);
            Seaside2.AddHostInt32(-1);
            Seaside2.AddHostInt32(0);
            Seaside2.AddBoolean(true);
            Seaside2.AddHostUInt64(0);
            Seaside2.AddHostInt32(2);
            Seaside2.AddFloat(0.0f);

            Seaside2.AddHostInt32(0); // Target

            Seaside2.AddHostInt32(0); // CharacterVariables

            Seaside2.AddHostInt32(0);
            Seaside2.AddFloat(0.0f);

            Seaside2.AddFloat(0.0f); // Unknown54, float[4]
            Seaside2.AddFloat(0.0f);
            Seaside2.AddFloat(0.0f);
            Seaside2.AddFloat(0.0f);

            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddFloat(0.0f); // Unknown
            Seaside2.AddFloat(0.0f); // Unknown
            Seaside2.AddFloat(0.0f); // Unknown
            Seaside2.AddASCIIString(""); // Unknown
            Seaside2.AddASCIIString(""); // Unknown
            Seaside2.AddASCIIString(""); // Unknown
            Seaside2.AddBoolean(false); // Unknown
            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddHostInt32(8); // Unknown
            Seaside2.AddHostInt32(0); // Unknown
            Seaside2.AddHostInt32(3442); // Unknown
            Seaside2.AddFloat(0.0f); // Unknown
            Seaside2.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Seaside2.GetRaw());

            var GoblinMage = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            GoblinMage.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            GoblinMage.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            GoblinMage.AddHostInt32(432135); // Name ID
            GoblinMage.AddHostInt32(191); // Model ID
            GoblinMage.AddBoolean(false); // Unknown4
            GoblinMage.AddHostInt32(408679); // Unknown5
            GoblinMage.AddHostInt32(13951728); // Unknown6
            GoblinMage.AddHostInt32(1); // Unknown7
            GoblinMage.AddFloat(1.0f); // Unknown8

            // Position
            GoblinMage.AddFloat(-474.5136f);
            GoblinMage.AddFloat(-1.490846f);
            GoblinMage.AddFloat(-1166.573f);
            GoblinMage.AddFloat(1.0f);

            //Rotation
            GoblinMage.AddFloat(0.2982662f);
            GoblinMage.AddFloat(0f);
            GoblinMage.AddFloat(0.9544827f);
            GoblinMage.AddFloat(0f);

            GoblinMage.AddHostInt32(1); // Unknown11

            GoblinMage.AddHostInt32(0); // CharacterAttachmentDataCount
            GoblinMage.AddHostInt32(1); // Unknown12

            GoblinMage.AddASCIIString(""); // TextureAlias
            GoblinMage.AddASCIIString(""); // TintAlias
            GoblinMage.AddHostInt32(0); // TintId
            GoblinMage.AddBoolean(true); // Unknown16
            GoblinMage.AddFloat(0f); // Unknown17
            GoblinMage.AddHostInt32(0); // Unknown18
            GoblinMage.AddHostInt32(0); // Unknown19
            GoblinMage.AddASCIIString(""); // Custom Name
            GoblinMage.AddBoolean(true); // NameDisabled
            GoblinMage.AddHostInt32(0); // Unknown22
            GoblinMage.AddFloat(0.0f); // Unknown23
            GoblinMage.AddFloat(0.0f); // Unknown24
            GoblinMage.AddHostInt32(0); // Unknown25
            GoblinMage.AddBoolean(false); // Unknown26
            GoblinMage.AddFloat(0.0f); // Unknown27
            GoblinMage.AddBoolean(false); // Unknown28
            GoblinMage.AddHostInt32(100); // Unknown29
            GoblinMage.AddHostInt32(-1); // Unknown
            GoblinMage.AddHostInt32(-1); // Unknown
            GoblinMage.AddHostInt32(-1); // Unknown
            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddHostInt32(-1); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown

            GoblinMage.AddHostInt32(0); // EffectTagsCount

            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddBoolean(false); // Unknown

            GoblinMage.AddHostInt32(0); // UnknownStruct2
            GoblinMage.AddASCIIString("");
            GoblinMage.AddASCIIString("");
            GoblinMage.AddHostInt32(0);
            GoblinMage.AddASCIIString("");

            GoblinMage.AddFloat(0.0f);
            GoblinMage.AddFloat(0.0f);
            GoblinMage.AddFloat(0.0f);
            GoblinMage.AddFloat(0.0f);

            GoblinMage.AddHostInt32(0);
            GoblinMage.AddHostInt32(-1);
            GoblinMage.AddHostInt32(0);
            GoblinMage.AddBoolean(true);
            GoblinMage.AddHostUInt64(0);
            GoblinMage.AddHostInt32(2);
            GoblinMage.AddFloat(0.0f);

            GoblinMage.AddHostInt32(0); // Target

            GoblinMage.AddHostInt32(0); // CharacterVariables

            GoblinMage.AddHostInt32(0);
            GoblinMage.AddFloat(0.0f);

            GoblinMage.AddFloat(0.0f); // Unknown54, float[4]
            GoblinMage.AddFloat(0.0f);
            GoblinMage.AddFloat(0.0f);
            GoblinMage.AddFloat(0.0f);

            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddFloat(0.0f); // Unknown
            GoblinMage.AddFloat(0.0f); // Unknown
            GoblinMage.AddFloat(0.0f); // Unknown
            GoblinMage.AddASCIIString(""); // Unknown
            GoblinMage.AddASCIIString(""); // Unknown
            GoblinMage.AddASCIIString(""); // Unknown
            GoblinMage.AddBoolean(false); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddHostInt32(8); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown
            GoblinMage.AddHostInt32(3442); // Unknown
            GoblinMage.AddFloat(0.0f); // Unknown
            GoblinMage.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, GoblinMage.GetRaw());

            var addBoombox1 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            addBoombox1.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            addBoombox1.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            addBoombox1.AddHostInt32(18044); // Name ID
            addBoombox1.AddHostInt32(185); // Model ID
            addBoombox1.AddBoolean(false); // Unknown4
            addBoombox1.AddHostInt32(408679); // Unknown5
            addBoombox1.AddHostInt32(13951728); // Unknown6
            addBoombox1.AddHostInt32(1); // Unknown7
            addBoombox1.AddFloat(1.0f); // Unknown8

            // Position
            addBoombox1.AddFloat(-294.5865f);
            addBoombox1.AddFloat(-35.00544f);
            addBoombox1.AddFloat(-1197.221f);
            addBoombox1.AddFloat(1.0f);

            //Rotation
            addBoombox1.AddFloat(-0.9749401f);
            addBoombox1.AddFloat(0f);
            addBoombox1.AddFloat(0.2224676f);
            addBoombox1.AddFloat(0f);

            addBoombox1.AddHostInt32(2100); // Unknown11

            addBoombox1.AddHostInt32(0); // CharacterAttachmentDataCount
            addBoombox1.AddHostInt32(1); // Unknown12

            addBoombox1.AddASCIIString(""); // TextureAlias
            addBoombox1.AddASCIIString(""); // TintAlias
            addBoombox1.AddHostInt32(0); // TintId
            addBoombox1.AddBoolean(true); // Unknown16
            addBoombox1.AddFloat(0f); // Unknown17
            addBoombox1.AddHostInt32(0); // Unknown18
            addBoombox1.AddHostInt32(0); // Unknown19
            addBoombox1.AddASCIIString(""); // Custom Name
            addBoombox1.AddBoolean(true); // NameDisabled
            addBoombox1.AddHostInt32(0); // Unknown22
            addBoombox1.AddFloat(0.0f); // Unknown23
            addBoombox1.AddFloat(0.0f); // Unknown24
            addBoombox1.AddHostInt32(0); // Unknown25
            addBoombox1.AddBoolean(false); // Unknown26
            addBoombox1.AddFloat(0.0f); // Unknown27
            addBoombox1.AddBoolean(false); // Unknown28
            addBoombox1.AddHostInt32(100); // Unknown29
            addBoombox1.AddHostInt32(-1); // Unknown
            addBoombox1.AddHostInt32(-1); // Unknown
            addBoombox1.AddHostInt32(-1); // Unknown
            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddHostInt32(-1); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown

            addBoombox1.AddHostInt32(0); // EffectTagsCount

            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddBoolean(false); // Unknown

            addBoombox1.AddHostInt32(0); // UnknownStruct2
            addBoombox1.AddASCIIString("");
            addBoombox1.AddASCIIString("");
            addBoombox1.AddHostInt32(0);
            addBoombox1.AddASCIIString("");

            addBoombox1.AddFloat(0.0f);
            addBoombox1.AddFloat(0.0f);
            addBoombox1.AddFloat(0.0f);
            addBoombox1.AddFloat(0.0f);

            addBoombox1.AddHostInt32(0);
            addBoombox1.AddHostInt32(-1);
            addBoombox1.AddHostInt32(0);
            addBoombox1.AddBoolean(true);
            addBoombox1.AddHostUInt64(0);
            addBoombox1.AddHostInt32(2);
            addBoombox1.AddFloat(0.0f);

            addBoombox1.AddHostInt32(0); // Target

            addBoombox1.AddHostInt32(0); // CharacterVariables

            addBoombox1.AddHostInt32(0);
            addBoombox1.AddFloat(0.0f);

            addBoombox1.AddFloat(0.0f); // Unknown54, float[4]
            addBoombox1.AddFloat(0.0f);
            addBoombox1.AddFloat(0.0f);
            addBoombox1.AddFloat(0.0f);

            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddFloat(0.0f); // Unknown
            addBoombox1.AddFloat(0.0f); // Unknown
            addBoombox1.AddFloat(0.0f); // Unknown
            addBoombox1.AddASCIIString(""); // Unknown
            addBoombox1.AddASCIIString(""); // Unknown
            addBoombox1.AddASCIIString(""); // Unknown
            addBoombox1.AddBoolean(false); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddHostInt32(8); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown
            addBoombox1.AddHostInt32(3442); // Unknown
            addBoombox1.AddFloat(0.0f); // Unknown
            addBoombox1.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, addBoombox1.GetRaw());

            var RoyalRex = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            RoyalRex.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            RoyalRex.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            RoyalRex.AddHostInt32(0); // Name ID
            RoyalRex.AddHostInt32(169); // Model ID
            RoyalRex.AddBoolean(false); // Unknown4
            RoyalRex.AddHostInt32(408679); // Unknown5
            RoyalRex.AddHostInt32(13951728); // Unknown6
            RoyalRex.AddHostInt32(1); // Unknown7
            RoyalRex.AddFloat(1.0f); // Unknown8

            // Position
            RoyalRex.AddFloat(-293.1325f);
            RoyalRex.AddFloat(-34.15668f);
            RoyalRex.AddFloat(-1193.752f);
            RoyalRex.AddFloat(1.0f);

            //Rotation
            RoyalRex.AddFloat(-0.9587811f);
            RoyalRex.AddFloat(0f);
            RoyalRex.AddFloat(-0.2841458f);
            RoyalRex.AddFloat(0f);

            RoyalRex.AddHostInt32(3200); // Unknown11

            RoyalRex.AddHostInt32(0); // CharacterAttachmentDataCount
            RoyalRex.AddHostInt32(1); // Unknown12

            RoyalRex.AddASCIIString(""); // TextureAlias
            RoyalRex.AddASCIIString(""); // TintAlias
            RoyalRex.AddHostInt32(0); // TintId
            RoyalRex.AddBoolean(true); // Unknown16
            RoyalRex.AddFloat(0f); // Unknown17
            RoyalRex.AddHostInt32(0); // Unknown18
            RoyalRex.AddHostInt32(0); // Unknown19
            RoyalRex.AddASCIIString("Coli"); // Custom Name
            RoyalRex.AddBoolean(false); // NameDisabled
            RoyalRex.AddHostInt32(0); // Unknown22
            RoyalRex.AddFloat(0.0f); // Unknown23
            RoyalRex.AddFloat(0.0f); // Unknown24
            RoyalRex.AddHostInt32(0); // Unknown25
            RoyalRex.AddBoolean(false); // Unknown26
            RoyalRex.AddFloat(0.0f); // Unknown27
            RoyalRex.AddBoolean(false); // Unknown28
            RoyalRex.AddHostInt32(100); // Unknown29
            RoyalRex.AddHostInt32(-1); // Unknown
            RoyalRex.AddHostInt32(-1); // Unknown
            RoyalRex.AddHostInt32(-1); // Unknown
            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddHostInt32(-1); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown

            RoyalRex.AddHostInt32(0); // EffectTagsCount

            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddBoolean(false); // Unknown

            RoyalRex.AddHostInt32(0); // UnknownStruct2
            RoyalRex.AddASCIIString("");
            RoyalRex.AddASCIIString("");
            RoyalRex.AddHostInt32(0);
            RoyalRex.AddASCIIString("");

            RoyalRex.AddFloat(0.0f);
            RoyalRex.AddFloat(0.0f);
            RoyalRex.AddFloat(0.0f);
            RoyalRex.AddFloat(0.0f);

            RoyalRex.AddHostInt32(0);
            RoyalRex.AddHostInt32(-1);
            RoyalRex.AddHostInt32(0);
            RoyalRex.AddBoolean(true);
            RoyalRex.AddHostUInt64(0);
            RoyalRex.AddHostInt32(2);
            RoyalRex.AddFloat(0.0f);

            RoyalRex.AddHostInt32(0); // Target

            RoyalRex.AddHostInt32(0); // CharacterVariables

            RoyalRex.AddHostInt32(0);
            RoyalRex.AddFloat(0.0f);

            RoyalRex.AddFloat(0.0f); // Unknown54, float[4]
            RoyalRex.AddFloat(0.0f);
            RoyalRex.AddFloat(0.0f);
            RoyalRex.AddFloat(0.0f);

            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddFloat(0.0f); // Unknown
            RoyalRex.AddFloat(0.0f); // Unknown
            RoyalRex.AddFloat(0.0f); // Unknown
            RoyalRex.AddASCIIString(""); // Unknown
            RoyalRex.AddASCIIString(""); // Unknown
            RoyalRex.AddASCIIString(""); // Unknown
            RoyalRex.AddBoolean(false); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddHostInt32(8); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown
            RoyalRex.AddHostInt32(3442); // Unknown
            RoyalRex.AddFloat(0.0f); // Unknown
            RoyalRex.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, RoyalRex.GetRaw());

            var Samantha = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Samantha.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Samantha.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Samantha.AddHostInt32(432135); // Name ID
            Samantha.AddHostInt32(431); // Model ID
            Samantha.AddBoolean(false); // Unknown4
            Samantha.AddHostInt32(408679); // Unknown5
            Samantha.AddHostInt32(13951728); // Unknown6
            Samantha.AddHostInt32(1); // Unknown7
            Samantha.AddFloat(1.0f); // Unknown8

            // Position
            Samantha.AddFloat(-484.3938f);
            Samantha.AddFloat(-7.069954f);
            Samantha.AddFloat(203.0451f);
            Samantha.AddFloat(1.0f);

            //Rotation
            Samantha.AddFloat(-0.8173634f);
            Samantha.AddFloat(0f);
            Samantha.AddFloat(0.5761225f);
            Samantha.AddFloat(0f);

            Samantha.AddHostInt32(1); // Unknown11

            Samantha.AddHostInt32(0); // CharacterAttachmentDataCount
            Samantha.AddHostInt32(1); // Unknown12

            Samantha.AddASCIIString(""); // TextureAlias
            Samantha.AddASCIIString(""); // TintAlias
            Samantha.AddHostInt32(0); // TintId
            Samantha.AddBoolean(true); // Unknown16
            Samantha.AddFloat(0f); // Unknown17
            Samantha.AddHostInt32(0); // Unknown18
            Samantha.AddHostInt32(0); // Unknown19
            Samantha.AddASCIIString(""); // Custom Name
            Samantha.AddBoolean(true); // NameDisabled
            Samantha.AddHostInt32(0); // Unknown22
            Samantha.AddFloat(0.0f); // Unknown23
            Samantha.AddFloat(0.0f); // Unknown24
            Samantha.AddHostInt32(0); // Unknown25
            Samantha.AddBoolean(false); // Unknown26
            Samantha.AddFloat(0.0f); // Unknown27
            Samantha.AddBoolean(false); // Unknown28
            Samantha.AddHostInt32(100); // Unknown29
            Samantha.AddHostInt32(-1); // Unknown
            Samantha.AddHostInt32(-1); // Unknown
            Samantha.AddHostInt32(-1); // Unknown
            Samantha.AddBoolean(false); // Unknown
            Samantha.AddBoolean(false); // Unknown
            Samantha.AddHostInt32(-1); // Unknown
            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddHostInt32(0); // Unknown

            Samantha.AddHostInt32(0); // EffectTagsCount

            Samantha.AddBoolean(false); // Unknown
            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddBoolean(false); // Unknown
            Samantha.AddBoolean(false); // Unknown
            Samantha.AddBoolean(false); // Unknown
            Samantha.AddBoolean(false); // Unknown

            Samantha.AddHostInt32(0); // UnknownStruct2
            Samantha.AddASCIIString("");
            Samantha.AddASCIIString("");
            Samantha.AddHostInt32(0);
            Samantha.AddASCIIString("");

            Samantha.AddFloat(0.0f);
            Samantha.AddFloat(0.0f);
            Samantha.AddFloat(0.0f);
            Samantha.AddFloat(0.0f);

            Samantha.AddHostInt32(0);
            Samantha.AddHostInt32(-1);
            Samantha.AddHostInt32(0);
            Samantha.AddBoolean(true);
            Samantha.AddHostUInt64(0);
            Samantha.AddHostInt32(2);
            Samantha.AddFloat(0.0f);

            Samantha.AddHostInt32(0); // Target

            Samantha.AddHostInt32(0); // CharacterVariables

            Samantha.AddHostInt32(0);
            Samantha.AddFloat(0.0f);

            Samantha.AddFloat(0.0f); // Unknown54, float[4]
            Samantha.AddFloat(0.0f);
            Samantha.AddFloat(0.0f);
            Samantha.AddFloat(0.0f);

            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddFloat(0.0f); // Unknown
            Samantha.AddFloat(0.0f); // Unknown
            Samantha.AddFloat(0.0f); // Unknown
            Samantha.AddASCIIString(""); // Unknown
            Samantha.AddASCIIString(""); // Unknown
            Samantha.AddASCIIString(""); // Unknown
            Samantha.AddBoolean(false); // Unknown
            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddHostInt32(8); // Unknown
            Samantha.AddHostInt32(0); // Unknown
            Samantha.AddHostInt32(3442); // Unknown
            Samantha.AddFloat(0.0f); // Unknown
            Samantha.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Samantha.GetRaw());

            var Child1 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Child1.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Child1.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Child1.AddHostInt32(432135); // Name ID
            Child1.AddHostInt32(7); // Model ID
            Child1.AddBoolean(false); // Unknown4
            Child1.AddHostInt32(408679); // Unknown5
            Child1.AddHostInt32(13951728); // Unknown6
            Child1.AddHostInt32(1); // Unknown7
            Child1.AddFloat(1.0f); // Unknown8

            // Position
            Child1.AddFloat(-1862.327f);
            Child1.AddFloat(-40.49908f);
            Child1.AddFloat(490.5803f);
            Child1.AddFloat(1.0f);

            //Rotation
            Child1.AddFloat(-0.00112173f);
            Child1.AddFloat(0f);
            Child1.AddFloat(-0.9999993f);
            Child1.AddFloat(0f);

            Child1.AddHostInt32(1); // Unknown11

            Child1.AddHostInt32(0); // CharacterAttachmentDataCount
            Child1.AddHostInt32(1); // Unknown12

            Child1.AddASCIIString(""); // TextureAlias
            Child1.AddASCIIString(""); // TintAlias
            Child1.AddHostInt32(0); // TintId
            Child1.AddBoolean(true); // Unknown16
            Child1.AddFloat(0f); // Unknown17
            Child1.AddHostInt32(0); // Unknown18
            Child1.AddHostInt32(0); // Unknown19
            Child1.AddASCIIString(""); // Custom Name
            Child1.AddBoolean(true); // NameDisabled
            Child1.AddHostInt32(0); // Unknown22
            Child1.AddFloat(0.0f); // Unknown23
            Child1.AddFloat(0.0f); // Unknown24
            Child1.AddHostInt32(0); // Unknown25
            Child1.AddBoolean(false); // Unknown26
            Child1.AddFloat(0.0f); // Unknown27
            Child1.AddBoolean(false); // Unknown28
            Child1.AddHostInt32(100); // Unknown29
            Child1.AddHostInt32(-1); // Unknown
            Child1.AddHostInt32(-1); // Unknown
            Child1.AddHostInt32(-1); // Unknown
            Child1.AddBoolean(false); // Unknown
            Child1.AddBoolean(false); // Unknown
            Child1.AddHostInt32(-1); // Unknown
            Child1.AddHostInt32(0); // Unknown
            Child1.AddHostInt32(0); // Unknown

            Child1.AddHostInt32(0); // EffectTagsCount

            Child1.AddBoolean(false); // Unknown
            Child1.AddHostInt32(0); // Unknown
            Child1.AddBoolean(false); // Unknown
            Child1.AddBoolean(false); // Unknown
            Child1.AddBoolean(false); // Unknown
            Child1.AddBoolean(false); // Unknown

            Child1.AddHostInt32(0); // UnknownStruct2
            Child1.AddASCIIString("");
            Child1.AddASCIIString("");
            Child1.AddHostInt32(0);
            Child1.AddASCIIString("");

            Child1.AddFloat(0.0f);
            Child1.AddFloat(0.0f);
            Child1.AddFloat(0.0f);
            Child1.AddFloat(0.0f);

            Child1.AddHostInt32(0);
            Child1.AddHostInt32(-1);
            Child1.AddHostInt32(0);
            Child1.AddBoolean(true);
            Child1.AddHostUInt64(0);
            Child1.AddHostInt32(2);
            Child1.AddFloat(0.0f);

            Child1.AddHostInt32(0); // Target

            Child1.AddHostInt32(0); // CharacterVariables

            Child1.AddHostInt32(0);
            Child1.AddFloat(0.0f);

            Child1.AddFloat(0.0f); // Unknown54, float[4]
            Child1.AddFloat(0.0f);
            Child1.AddFloat(0.0f);
            Child1.AddFloat(0.0f);

            Child1.AddHostInt32(0); // Unknown
            Child1.AddFloat(0.0f); // Unknown
            Child1.AddFloat(0.0f); // Unknown
            Child1.AddFloat(0.0f); // Unknown
            Child1.AddASCIIString(""); // Unknown
            Child1.AddASCIIString(""); // Unknown
            Child1.AddASCIIString(""); // Unknown
            Child1.AddBoolean(false); // Unknown
            Child1.AddHostInt32(0); // Unknown
            Child1.AddHostInt32(0); // Unknown
            Child1.AddHostInt32(0); // Unknown
            Child1.AddHostInt32(8); // Unknown
            Child1.AddHostInt32(0); // Unknown
            Child1.AddHostInt32(3442); // Unknown
            Child1.AddFloat(0.0f); // Unknown
            Child1.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Child1.GetRaw());

            var Chugawug = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Chugawug.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Chugawug.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Chugawug.AddHostInt32(432135); // Name ID
            Chugawug.AddHostInt32(14); // Model ID
            Chugawug.AddBoolean(false); // Unknown4
            Chugawug.AddHostInt32(408679); // Unknown5
            Chugawug.AddHostInt32(13951728); // Unknown6
            Chugawug.AddHostInt32(1); // Unknown7
            Chugawug.AddFloat(1.0f); // Unknown8

            // Position
            Chugawug.AddFloat(-1824.517f);
            Chugawug.AddFloat(-42.23948f);
            Chugawug.AddFloat(433.0621f);
            Chugawug.AddFloat(1.0f);

            //Rotation
            Chugawug.AddFloat(-0.9998603f);
            Chugawug.AddFloat(0f);
            Chugawug.AddFloat(-0.01671218f);
            Chugawug.AddFloat(0f);

            Chugawug.AddHostInt32(1); // Unknown11

            Chugawug.AddHostInt32(0); // CharacterAttachmentDataCount
            Chugawug.AddHostInt32(1); // Unknown12

            Chugawug.AddASCIIString(""); // TextureAlias
            Chugawug.AddASCIIString(""); // TintAlias
            Chugawug.AddHostInt32(0); // TintId
            Chugawug.AddBoolean(true); // Unknown16
            Chugawug.AddFloat(0f); // Unknown17
            Chugawug.AddHostInt32(0); // Unknown18
            Chugawug.AddHostInt32(0); // Unknown19
            Chugawug.AddASCIIString(""); // Custom Name
            Chugawug.AddBoolean(true); // NameDisabled
            Chugawug.AddHostInt32(0); // Unknown22
            Chugawug.AddFloat(0.0f); // Unknown23
            Chugawug.AddFloat(0.0f); // Unknown24
            Chugawug.AddHostInt32(0); // Unknown25
            Chugawug.AddBoolean(false); // Unknown26
            Chugawug.AddFloat(0.0f); // Unknown27
            Chugawug.AddBoolean(false); // Unknown28
            Chugawug.AddHostInt32(100); // Unknown29
            Chugawug.AddHostInt32(-1); // Unknown
            Chugawug.AddHostInt32(-1); // Unknown
            Chugawug.AddHostInt32(-1); // Unknown
            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddHostInt32(-1); // Unknown
            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddHostInt32(0); // Unknown

            Chugawug.AddHostInt32(0); // EffectTagsCount

            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddBoolean(false); // Unknown

            Chugawug.AddHostInt32(0); // UnknownStruct2
            Chugawug.AddASCIIString("");
            Chugawug.AddASCIIString("");
            Chugawug.AddHostInt32(0);
            Chugawug.AddASCIIString("");

            Chugawug.AddFloat(0.0f);
            Chugawug.AddFloat(0.0f);
            Chugawug.AddFloat(0.0f);
            Chugawug.AddFloat(0.0f);

            Chugawug.AddHostInt32(0);
            Chugawug.AddHostInt32(-1);
            Chugawug.AddHostInt32(0);
            Chugawug.AddBoolean(true);
            Chugawug.AddHostUInt64(0);
            Chugawug.AddHostInt32(2);
            Chugawug.AddFloat(0.0f);

            Chugawug.AddHostInt32(0); // Target

            Chugawug.AddHostInt32(0); // CharacterVariables

            Chugawug.AddHostInt32(0);
            Chugawug.AddFloat(0.0f);

            Chugawug.AddFloat(0.0f); // Unknown54, float[4]
            Chugawug.AddFloat(0.0f);
            Chugawug.AddFloat(0.0f);
            Chugawug.AddFloat(0.0f);

            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddFloat(0.0f); // Unknown
            Chugawug.AddFloat(0.0f); // Unknown
            Chugawug.AddFloat(0.0f); // Unknown
            Chugawug.AddASCIIString(""); // Unknown
            Chugawug.AddASCIIString(""); // Unknown
            Chugawug.AddASCIIString(""); // Unknown
            Chugawug.AddBoolean(false); // Unknown
            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddHostInt32(8); // Unknown
            Chugawug.AddHostInt32(0); // Unknown
            Chugawug.AddHostInt32(3442); // Unknown
            Chugawug.AddFloat(0.0f); // Unknown
            Chugawug.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Chugawug.GetRaw());

            var Chugawug1 = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Chugawug1.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Chugawug1.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Chugawug1.AddHostInt32(432135); // Name ID
            Chugawug1.AddHostInt32(14); // Model ID
            Chugawug1.AddBoolean(false); // Unknown4
            Chugawug1.AddHostInt32(408679); // Unknown5
            Chugawug1.AddHostInt32(13951728); // Unknown6
            Chugawug1.AddHostInt32(1); // Unknown7
            Chugawug1.AddFloat(1.0f); // Unknown8

            // Position
            Chugawug1.AddFloat(-445.6659f);
            Chugawug1.AddFloat(-4.555522f);
            Chugawug1.AddFloat(199.3131f);
            Chugawug1.AddFloat(1.0f);

            //Rotation
            Chugawug1.AddFloat(-0.9805745f);
            Chugawug1.AddFloat(0f);
            Chugawug1.AddFloat(0.1526473f);
            Chugawug1.AddFloat(0f);

            Chugawug1.AddHostInt32(1); // Unknown11

            Chugawug1.AddHostInt32(0); // CharacterAttachmentDataCount
            Chugawug1.AddHostInt32(1); // Unknown12

            Chugawug1.AddASCIIString(""); // TextureAlias
            Chugawug1.AddASCIIString(""); // TintAlias
            Chugawug1.AddHostInt32(0); // TintId
            Chugawug1.AddBoolean(true); // Unknown16
            Chugawug1.AddFloat(0f); // Unknown17
            Chugawug1.AddHostInt32(0); // Unknown18
            Chugawug1.AddHostInt32(0); // Unknown19
            Chugawug1.AddASCIIString(""); // Custom Name
            Chugawug1.AddBoolean(true); // NameDisabled
            Chugawug1.AddHostInt32(0); // Unknown22
            Chugawug1.AddFloat(0.0f); // Unknown23
            Chugawug1.AddFloat(0.0f); // Unknown24
            Chugawug1.AddHostInt32(0); // Unknown25
            Chugawug1.AddBoolean(false); // Unknown26
            Chugawug1.AddFloat(0.0f); // Unknown27
            Chugawug1.AddBoolean(false); // Unknown28
            Chugawug1.AddHostInt32(100); // Unknown29
            Chugawug1.AddHostInt32(-1); // Unknown
            Chugawug1.AddHostInt32(-1); // Unknown
            Chugawug1.AddHostInt32(-1); // Unknown
            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddHostInt32(-1); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown

            Chugawug1.AddHostInt32(0); // EffectTagsCount

            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddBoolean(false); // Unknown

            Chugawug1.AddHostInt32(0); // UnknownStruct2
            Chugawug1.AddASCIIString("");
            Chugawug1.AddASCIIString("");
            Chugawug1.AddHostInt32(0);
            Chugawug1.AddASCIIString("");

            Chugawug1.AddFloat(0.0f);
            Chugawug1.AddFloat(0.0f);
            Chugawug1.AddFloat(0.0f);
            Chugawug1.AddFloat(0.0f);

            Chugawug1.AddHostInt32(0);
            Chugawug1.AddHostInt32(-1);
            Chugawug1.AddHostInt32(0);
            Chugawug1.AddBoolean(true);
            Chugawug1.AddHostUInt64(0);
            Chugawug1.AddHostInt32(2);
            Chugawug1.AddFloat(0.0f);

            Chugawug1.AddHostInt32(0); // Target

            Chugawug1.AddHostInt32(0); // CharacterVariables

            Chugawug1.AddHostInt32(0);
            Chugawug1.AddFloat(0.0f);

            Chugawug1.AddFloat(0.0f); // Unknown54, float[4]
            Chugawug1.AddFloat(0.0f);
            Chugawug1.AddFloat(0.0f);
            Chugawug1.AddFloat(0.0f);

            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddFloat(0.0f); // Unknown
            Chugawug1.AddFloat(0.0f); // Unknown
            Chugawug1.AddFloat(0.0f); // Unknown
            Chugawug1.AddASCIIString(""); // Unknown
            Chugawug1.AddASCIIString(""); // Unknown
            Chugawug1.AddASCIIString(""); // Unknown
            Chugawug1.AddBoolean(false); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddHostInt32(8); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown
            Chugawug1.AddHostInt32(3442); // Unknown
            Chugawug1.AddFloat(0.0f); // Unknown
            Chugawug1.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Chugawug1.GetRaw());

            var RainaKush = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            RainaKush.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            RainaKush.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            RainaKush.AddHostInt32(432135); // Name ID
            RainaKush.AddHostInt32(962); // Model ID
            RainaKush.AddBoolean(false); // Unknown4
            RainaKush.AddHostInt32(408679); // Unknown5
            RainaKush.AddHostInt32(13951728); // Unknown6
            RainaKush.AddHostInt32(1); // Unknown7
            RainaKush.AddFloat(1.0f); // Unknown8

            // Position
            RainaKush.AddFloat(-416.0147f);
            RainaKush.AddFloat(-4.143768f);
            RainaKush.AddFloat(134.8165f);
            RainaKush.AddFloat(1.0f);

            //Rotation
            RainaKush.AddFloat(-0.9882807f);
            RainaKush.AddFloat(0f);
            RainaKush.AddFloat(0.1526473f);
            RainaKush.AddFloat(0f);

            RainaKush.AddHostInt32(1); // Unknown11

            RainaKush.AddHostInt32(0); // CharacterAttachmentDataCount
            RainaKush.AddHostInt32(1); // Unknown12

            RainaKush.AddASCIIString(""); // TextureAlias
            RainaKush.AddASCIIString(""); // TintAlias
            RainaKush.AddHostInt32(0); // TintId
            RainaKush.AddBoolean(true); // Unknown16
            RainaKush.AddFloat(0f); // Unknown17
            RainaKush.AddHostInt32(0); // Unknown18
            RainaKush.AddHostInt32(0); // Unknown19
            RainaKush.AddASCIIString("Raina Kush"); // Custom Name
            RainaKush.AddBoolean(false); // NameDisabled
            RainaKush.AddHostInt32(0); // Unknown22
            RainaKush.AddFloat(0.0f); // Unknown23
            RainaKush.AddFloat(0.0f); // Unknown24
            RainaKush.AddHostInt32(0); // Unknown25
            RainaKush.AddBoolean(false); // Unknown26
            RainaKush.AddFloat(0.0f); // Unknown27
            RainaKush.AddBoolean(false); // Unknown28
            RainaKush.AddHostInt32(100); // Unknown29
            RainaKush.AddHostInt32(-1); // Unknown
            RainaKush.AddHostInt32(-1); // Unknown
            RainaKush.AddHostInt32(-1); // Unknown
            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddHostInt32(-1); // Unknown
            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddHostInt32(0); // Unknown

            RainaKush.AddHostInt32(0); // EffectTagsCount

            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddBoolean(false); // Unknown

            RainaKush.AddHostInt32(0); // UnknownStruct2
            RainaKush.AddASCIIString("");
            RainaKush.AddASCIIString("");
            RainaKush.AddHostInt32(0);
            RainaKush.AddASCIIString("");

            RainaKush.AddFloat(0.0f);
            RainaKush.AddFloat(0.0f);
            RainaKush.AddFloat(0.0f);
            RainaKush.AddFloat(0.0f);

            RainaKush.AddHostInt32(0);
            RainaKush.AddHostInt32(-1);
            RainaKush.AddHostInt32(0);
            RainaKush.AddBoolean(true);
            RainaKush.AddHostUInt64(0);
            RainaKush.AddHostInt32(2);
            RainaKush.AddFloat(0.0f);

            RainaKush.AddHostInt32(0); // Target

            RainaKush.AddHostInt32(0); // CharacterVariables

            RainaKush.AddHostInt32(0);
            RainaKush.AddFloat(0.0f);

            RainaKush.AddFloat(0.0f); // Unknown54, float[4]
            RainaKush.AddFloat(0.0f);
            RainaKush.AddFloat(0.0f);
            RainaKush.AddFloat(0.0f);

            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddFloat(0.0f); // Unknown
            RainaKush.AddFloat(0.0f); // Unknown
            RainaKush.AddFloat(0.0f); // Unknown
            RainaKush.AddASCIIString(""); // Unknown
            RainaKush.AddASCIIString(""); // Unknown
            RainaKush.AddASCIIString(""); // Unknown
            RainaKush.AddBoolean(false); // Unknown
            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddHostInt32(8); // Unknown
            RainaKush.AddHostInt32(0); // Unknown
            RainaKush.AddHostInt32(3442); // Unknown
            RainaKush.AddFloat(0.0f); // Unknown
            RainaKush.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, RainaKush.GetRaw());

            var ChugawugMiner = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            ChugawugMiner.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            ChugawugMiner.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            ChugawugMiner.AddHostInt32(432135); // Name ID
            ChugawugMiner.AddHostInt32(15); // Model ID
            ChugawugMiner.AddBoolean(false); // Unknown4
            ChugawugMiner.AddHostInt32(408679); // Unknown5
            ChugawugMiner.AddHostInt32(13951728); // Unknown6
            ChugawugMiner.AddHostInt32(1); // Unknown7
            ChugawugMiner.AddFloat(1.0f); // Unknown8

            // Position
            ChugawugMiner.AddFloat(-515.6367f);
            ChugawugMiner.AddFloat(-4.331403f);
            ChugawugMiner.AddFloat(142.468f);
            ChugawugMiner.AddFloat(1.0f);

            //Rotation
            ChugawugMiner.AddFloat(-0.05814566f);
            ChugawugMiner.AddFloat(0f);
            ChugawugMiner.AddFloat(0.9983081f);
            ChugawugMiner.AddFloat(0f);

            ChugawugMiner.AddHostInt32(1); // Unknown11

            ChugawugMiner.AddHostInt32(0); // CharacterAttachmentDataCount
            ChugawugMiner.AddHostInt32(1); // Unknown12

            ChugawugMiner.AddASCIIString(""); // TextureAlias
            ChugawugMiner.AddASCIIString(""); // TintAlias
            ChugawugMiner.AddHostInt32(0); // TintId
            ChugawugMiner.AddBoolean(true); // Unknown16
            ChugawugMiner.AddFloat(0f); // Unknown17
            ChugawugMiner.AddHostInt32(0); // Unknown18
            ChugawugMiner.AddHostInt32(0); // Unknown19
            ChugawugMiner.AddASCIIString(""); // Custom Name
            ChugawugMiner.AddBoolean(true); // NameDisabled
            ChugawugMiner.AddHostInt32(0); // Unknown22
            ChugawugMiner.AddFloat(0.0f); // Unknown23
            ChugawugMiner.AddFloat(0.0f); // Unknown24
            ChugawugMiner.AddHostInt32(0); // Unknown25
            ChugawugMiner.AddBoolean(false); // Unknown26
            ChugawugMiner.AddFloat(0.0f); // Unknown27
            ChugawugMiner.AddBoolean(false); // Unknown28
            ChugawugMiner.AddHostInt32(100); // Unknown29
            ChugawugMiner.AddHostInt32(-1); // Unknown
            ChugawugMiner.AddHostInt32(-1); // Unknown
            ChugawugMiner.AddHostInt32(-1); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddHostInt32(-1); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown

            ChugawugMiner.AddHostInt32(0); // EffectTagsCount

            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown

            ChugawugMiner.AddHostInt32(0); // UnknownStruct2
            ChugawugMiner.AddASCIIString("");
            ChugawugMiner.AddASCIIString("");
            ChugawugMiner.AddHostInt32(0);
            ChugawugMiner.AddASCIIString("");

            ChugawugMiner.AddFloat(0.0f);
            ChugawugMiner.AddFloat(0.0f);
            ChugawugMiner.AddFloat(0.0f);
            ChugawugMiner.AddFloat(0.0f);

            ChugawugMiner.AddHostInt32(0);
            ChugawugMiner.AddHostInt32(-1);
            ChugawugMiner.AddHostInt32(0);
            ChugawugMiner.AddBoolean(true);
            ChugawugMiner.AddHostUInt64(0);
            ChugawugMiner.AddHostInt32(2);
            ChugawugMiner.AddFloat(0.0f);

            ChugawugMiner.AddHostInt32(0); // Target

            ChugawugMiner.AddHostInt32(0); // CharacterVariables

            ChugawugMiner.AddHostInt32(0);
            ChugawugMiner.AddFloat(0.0f);

            ChugawugMiner.AddFloat(0.0f); // Unknown54, float[4]
            ChugawugMiner.AddFloat(0.0f);
            ChugawugMiner.AddFloat(0.0f);
            ChugawugMiner.AddFloat(0.0f);

            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddFloat(0.0f); // Unknown
            ChugawugMiner.AddFloat(0.0f); // Unknown
            ChugawugMiner.AddFloat(0.0f); // Unknown
            ChugawugMiner.AddASCIIString(""); // Unknown
            ChugawugMiner.AddASCIIString(""); // Unknown
            ChugawugMiner.AddASCIIString(""); // Unknown
            ChugawugMiner.AddBoolean(false); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddHostInt32(8); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown
            ChugawugMiner.AddHostInt32(3442); // Unknown
            ChugawugMiner.AddFloat(0.0f); // Unknown
            ChugawugMiner.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, ChugawugMiner.GetRaw());

            var Chatty = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Chatty.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Chatty.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Chatty.AddHostInt32(432135); // Name ID
            Chatty.AddHostInt32(376); // Model ID
            Chatty.AddBoolean(false); // Unknown4
            Chatty.AddHostInt32(408679); // Unknown5
            Chatty.AddHostInt32(13951728); // Unknown6
            Chatty.AddHostInt32(1); // Unknown7
            Chatty.AddFloat(1.0f); // Unknown8

            // Position
            Chatty.AddFloat(-1555.957f);
            Chatty.AddFloat(-40.64807f);
            Chatty.AddFloat(-625.8187f);
            Chatty.AddFloat(1.0f);

            //Rotation
            Chatty.AddFloat(0.2340431f);
            Chatty.AddFloat(0f);
            Chatty.AddFloat(0.9722263f);
            Chatty.AddFloat(0f);

            Chatty.AddHostInt32(1); // Unknown11

            Chatty.AddHostInt32(0); // CharacterAttachmentDataCount
            Chatty.AddHostInt32(1); // Unknown12

            Chatty.AddASCIIString(""); // TextureAlias
            Chatty.AddASCIIString("pumpkin"); // TintAlias
            Chatty.AddHostInt32(1); // TintId
            Chatty.AddBoolean(true); // Unknown16
            Chatty.AddFloat(0f); // Unknown17
            Chatty.AddHostInt32(0); // Unknown18
            Chatty.AddHostInt32(0); // Unknown19
            Chatty.AddASCIIString("Chatty"); // Custom Name
            Chatty.AddBoolean(false); // NameDisabled
            Chatty.AddHostInt32(0); // Unknown22
            Chatty.AddFloat(0.0f); // Unknown23
            Chatty.AddFloat(0.0f); // Unknown24
            Chatty.AddHostInt32(0); // Unknown25
            Chatty.AddBoolean(false); // Unknown26
            Chatty.AddFloat(0.0f); // Unknown27
            Chatty.AddBoolean(false); // Unknown28
            Chatty.AddHostInt32(100); // Unknown29
            Chatty.AddHostInt32(-1); // Unknown
            Chatty.AddHostInt32(-1); // Unknown
            Chatty.AddHostInt32(-1); // Unknown
            Chatty.AddBoolean(false); // Unknown
            Chatty.AddBoolean(false); // Unknown
            Chatty.AddHostInt32(-1); // Unknown
            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddHostInt32(0); // Unknown

            Chatty.AddHostInt32(0); // EffectTagsCount

            Chatty.AddBoolean(false); // Unknown
            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddBoolean(false); // Unknown
            Chatty.AddBoolean(false); // Unknown
            Chatty.AddBoolean(false); // Unknown
            Chatty.AddBoolean(false); // Unknown

            Chatty.AddHostInt32(0); // UnknownStruct2
            Chatty.AddASCIIString("");
            Chatty.AddASCIIString("");
            Chatty.AddHostInt32(0);
            Chatty.AddASCIIString("");

            Chatty.AddFloat(0.0f);
            Chatty.AddFloat(0.0f);
            Chatty.AddFloat(0.0f);
            Chatty.AddFloat(0.0f);

            Chatty.AddHostInt32(0);
            Chatty.AddHostInt32(-1);
            Chatty.AddHostInt32(0);
            Chatty.AddBoolean(true);
            Chatty.AddHostUInt64(0);
            Chatty.AddHostInt32(2);
            Chatty.AddFloat(0.0f);

            Chatty.AddHostInt32(0); // Target

            Chatty.AddHostInt32(0); // CharacterVariables

            Chatty.AddHostInt32(0);
            Chatty.AddFloat(0.0f);

            Chatty.AddFloat(0.0f); // Unknown54, float[4]
            Chatty.AddFloat(0.0f);
            Chatty.AddFloat(0.0f);
            Chatty.AddFloat(0.0f);

            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddFloat(0.0f); // Unknown
            Chatty.AddFloat(0.0f); // Unknown
            Chatty.AddFloat(0.0f); // Unknown
            Chatty.AddASCIIString(""); // Unknown
            Chatty.AddASCIIString(""); // Unknown
            Chatty.AddASCIIString(""); // Unknown
            Chatty.AddBoolean(false); // Unknown
            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddHostInt32(8); // Unknown
            Chatty.AddHostInt32(0); // Unknown
            Chatty.AddHostInt32(3442); // Unknown
            Chatty.AddFloat(0.0f); // Unknown
            Chatty.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Chatty.GetRaw());

            var Hilforn = new SOEWriter((ushort)BasePackets.BasePlayerUpdatePacket, true);
            Hilforn.AddHostUInt16((ushort)BasePlayerUpdatePackets.PlayerUpdatePacketAddNpc);
            Hilforn.AddHostUInt64(GUIDRandomizer.RandomGUID()); // Guid
            Hilforn.AddHostInt32(432135); // Name ID
            Hilforn.AddHostInt32(214); // Model ID
            Hilforn.AddBoolean(false); // Unknown4
            Hilforn.AddHostInt32(408679); // Unknown5
            Hilforn.AddHostInt32(13951728); // Unknown6
            Hilforn.AddHostInt32(1); // Unknown7
            Hilforn.AddFloat(1.0f); // Unknown8

            // Position
            Hilforn.AddFloat(-1564.097f);
            Hilforn.AddFloat(-32.27134f);
            Hilforn.AddFloat(-658.3897f);
            Hilforn.AddFloat(1.0f);

            //Rotation
            Hilforn.AddFloat(-0.1412534f);
            Hilforn.AddFloat(0f);
            Hilforn.AddFloat(0.9899734f);
            Hilforn.AddFloat(0f);

            Hilforn.AddHostInt32(1); // Unknown11

            Hilforn.AddHostInt32(0); // CharacterAttachmentDataCount
            Hilforn.AddHostInt32(1); // Unknown12

            Hilforn.AddASCIIString(""); // TextureAlias
            Hilforn.AddASCIIString(""); // TintAlias
            Hilforn.AddHostInt32(0); // TintId
            Hilforn.AddBoolean(true); // Unknown16
            Hilforn.AddFloat(0f); // Unknown17
            Hilforn.AddHostInt32(0); // Unknown18
            Hilforn.AddHostInt32(0); // Unknown19
            Hilforn.AddASCIIString("Hilforn"); // Custom Name
            Hilforn.AddBoolean(false); // NameDisabled
            Hilforn.AddHostInt32(0); // Unknown22
            Hilforn.AddFloat(0.0f); // Unknown23
            Hilforn.AddFloat(0.0f); // Unknown24
            Hilforn.AddHostInt32(0); // Unknown25
            Hilforn.AddBoolean(false); // Unknown26
            Hilforn.AddFloat(0.0f); // Unknown27
            Hilforn.AddBoolean(false); // Unknown28
            Hilforn.AddHostInt32(100); // Unknown29
            Hilforn.AddHostInt32(-1); // Unknown
            Hilforn.AddHostInt32(-1); // Unknown
            Hilforn.AddHostInt32(-1); // Unknown
            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddHostInt32(-1); // Unknown
            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddHostInt32(0); // Unknown

            Hilforn.AddHostInt32(0); // EffectTagsCount

            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddBoolean(false); // Unknown

            Hilforn.AddHostInt32(0); // UnknownStruct2
            Hilforn.AddASCIIString("");
            Hilforn.AddASCIIString("");
            Hilforn.AddHostInt32(0);
            Hilforn.AddASCIIString("");

            Hilforn.AddFloat(0.0f);
            Hilforn.AddFloat(0.0f);
            Hilforn.AddFloat(0.0f);
            Hilforn.AddFloat(0.0f);

            Hilforn.AddHostInt32(0);
            Hilforn.AddHostInt32(-1);
            Hilforn.AddHostInt32(0);
            Hilforn.AddBoolean(true);
            Hilforn.AddHostUInt64(0);
            Hilforn.AddHostInt32(2);
            Hilforn.AddFloat(0.0f);

            Hilforn.AddHostInt32(0); // Target

            Hilforn.AddHostInt32(0); // CharacterVariables

            Hilforn.AddHostInt32(0);
            Hilforn.AddFloat(0.0f);

            Hilforn.AddFloat(0.0f); // Unknown54, float[4]
            Hilforn.AddFloat(0.0f);
            Hilforn.AddFloat(0.0f);
            Hilforn.AddFloat(0.0f);

            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddFloat(0.0f); // Unknown
            Hilforn.AddFloat(0.0f); // Unknown
            Hilforn.AddFloat(0.0f); // Unknown
            Hilforn.AddASCIIString(""); // Unknown
            Hilforn.AddASCIIString(""); // Unknown
            Hilforn.AddASCIIString(""); // Unknown
            Hilforn.AddBoolean(false); // Unknown
            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddHostInt32(8); // Unknown
            Hilforn.AddHostInt32(0); // Unknown
            Hilforn.AddHostInt32(3442); // Unknown
            Hilforn.AddFloat(0.0f); // Unknown
            Hilforn.AddHostInt32(0); // Unknown

            LoginManager.SendTunneledClientPacket(soeClient, Hilforn.GetRaw());
        }
    }
}
