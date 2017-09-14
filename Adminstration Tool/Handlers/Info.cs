using System.Net;
using System.Windows.Forms;

using Lidgren.Network;

namespace Administration_Tool.Handlers
{
    public class InfoHandler
    {
        public static void HandleRecieve(NetIncomingMessage message, NetServer server, NetConnection client)
        {
            if (Server.Computers.ContainsKey(client.RemoteUniqueIdentifier))
            {

            }
            else
            {
                ComputerInfo info = new ComputerInfo();
                info.MACAddress = message.ReadString();
                message.ReadByte();
                info.Name = message.ReadString();
                info.Domain = message.ReadString();
                info.Model = message.ReadString();
                info.Manufacturer = message.ReadString();
                info.Username = message.ReadString();
                info.WakeupType = message.ReadString();
                message.ReadByte();
                info.OperatingSystem = message.ReadString();
                info.Architecture = message.ReadString();

                ListViewItem item = new ListViewItem(client.RemoteEndPoint.Address.ToString(), 0);
                item.Tag = client.RemoteUniqueIdentifier;
                item.Name = client.RemoteUniqueIdentifier.ToString();
                item.SubItems.Add(info.Name);
                item.SubItems.Add(info.OperatingSystem);
                Server.MainForm.ConnectionList.Items.Add(item);
                Server.Computers.Add(client.RemoteUniqueIdentifier, info);
            }
        }
    }
}
