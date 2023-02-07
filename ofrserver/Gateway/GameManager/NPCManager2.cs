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

        }
    }
}
