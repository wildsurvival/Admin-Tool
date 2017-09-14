using System;
using System.Threading;
using Lidgren.Network;
using System.Collections.Generic;

namespace Administration_Tool
{
    public class ComputerInfo
    {
        public string MACAddress = "";
        public string Name = "";
        public string Domain = "";
        public string Model = "";
        public string Manufacturer = "";
        public string Username = "";
        public string WakeupType = "";
        public string OperatingSystem = "";
        public string Architecture = "";
    }

    public class Server
    {
        public static MainForm MainForm;
        public static Dictionary<long, ComputerInfo> Computers;

        // Server variables
        private static Dictionary<long, NetConnection> clients;
        private static NetPeerConfiguration config;
        private static NetServer server;

        public Server()
        {
            config = new NetPeerConfiguration("Administration Tool")
            {
                Port = 4321
            };
            server = new NetServer(config);
            Computers = new Dictionary<long, ComputerInfo>();
            clients = new Dictionary<long, NetConnection>();
            server.RegisterReceivedCallback(new SendOrPostCallback(RecievedMessage));
        }

        public void Start()
        {
            server.Start();
        }

        private static void RecievedMessage(object peer)
        {
            NetServer server = (NetServer)peer;
            NetIncomingMessage message = server.ReadMessage();
            NetConnection client = message.SenderConnection;
            switch (message.MessageType)
            {
                case NetIncomingMessageType.Data: // Handle data recieved from current client
                    if (client.Status != NetConnectionStatus.Disconnected)
                        PacketHandler.Handle(message, server, client);
                    break;

                case NetIncomingMessageType.StatusChanged: // Handle connection and status changes
                    Server.MainForm.Log(string.Format("Status of address {0} changed to {1}", client.RemoteEndPoint.Address.ToString(), message.SenderConnection.Status.ToString()));
                    switch (message.SenderConnection.Status)
                    {
                        case NetConnectionStatus.Connected:
                            clients.Add(client.RemoteUniqueIdentifier, client);
                            NetOutgoingMessage send = server.CreateMessage();
                            send.Write((byte)PacketFamily.Info);
                            send.Write((byte)PacketAction.Request);
                            client.SendMessage(send, NetDeliveryMethod.ReliableOrdered, 1);
                            break;
                        case NetConnectionStatus.Disconnected:
                            clients.Remove(client.RemoteUniqueIdentifier);
                            if (Computers.ContainsKey(client.RemoteUniqueIdentifier))
                                Computers.Remove(client.RemoteUniqueIdentifier);
                            if (Server.MainForm.ConnectionList.Items.ContainsKey(client.RemoteUniqueIdentifier.ToString()))
                                Server.MainForm.ConnectionList.Items.RemoveByKey(client.RemoteUniqueIdentifier.ToString());
                            break;
                    }
                    break;

                default: // Unhandled messages
                    Server.MainForm.Log("unhandled message with type: " + message.MessageType);
                    break;
            }
        }
    }
}
