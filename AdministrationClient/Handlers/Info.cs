using System.Linq;
using System.Management;
using System.Collections.Generic;
using Lidgren.Network;
using System;

namespace AdministrationClient.Handlers
{
    public class InfoHandler
    {
        private static string GetMACAddress()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true");
            IEnumerable<ManagementObject> objects = searcher.Get().Cast<ManagementObject>();
            string mac = (from o in objects orderby o["IPConnectionMetric"] select o["MACAddress"].ToString()).FirstOrDefault();
            return mac;
        } 

        public static void HandleRequest(NetIncomingMessage message, NetClient client, NetConnection server)
        {
            NetOutgoingMessage send = client.CreateMessage();
            send.Write((byte)PacketFamily.Info);
            send.Write((byte)PacketAction.Recieve);
            send.Write(GetMACAddress());

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            IEnumerable<ManagementObject> objects = searcher.Get().Cast<ManagementObject>();
            send.Write((byte)objects.Count<ManagementObject>());
            foreach (ManagementObject item in objects)
            {
                send.Write(item["name"].ToString());
                send.Write(item["domain"].ToString());
                send.Write(item["model"].ToString());
                send.Write(item["manufacturer"].ToString());
                send.Write(item["username"].ToString());
                send.Write(item["wakeuptype"].ToString());
            }

            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            objects = searcher.Get().Cast<ManagementObject>();
            send.Write((byte)objects.Count<ManagementObject>());
            foreach (ManagementObject item in objects)
            {
                send.Write(item["caption"].ToString());
                send.Write(item["osarchitecture"].ToString());
            }

            server.SendMessage(send, NetDeliveryMethod.ReliableOrdered, 1);
        }
    }
}
