using Gateway.Login;
using Gateway.Player;
using SOE.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway.GameManager
{
    internal class BroadcastManager
    {
        public static void BroadcastToPlayers(byte[] Packet)
        {
            foreach (var connectionManagerClient in LoginManager._server.ConnectionManager.Clients)
            {
                if (connectionManagerClient.Value is null)
                    continue;

                LoginManager.SendTunneledClientPacket(connectionManagerClient.Value, Packet);
            }
        }
    }
}
