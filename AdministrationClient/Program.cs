using System;
using System.Threading;
using Lidgren;

using Lidgren.Network;

namespace AdministrationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new NetPeerConfiguration("Administration Tool");
            var client = new NetClient(config);
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
            client.RegisterReceivedCallback(new SendOrPostCallback(RecievedMessage));
            client.Start();
            client.Connect(host: "10.12.20.53", port: 4321);

            while (true)
                Console.ReadLine();
        }

        private static void RecievedMessage(object peer)
        {
            NetClient client = (NetClient)peer;
            NetConnection server = client.ServerConnection;
            NetIncomingMessage message;
            while ((message = client.ReadMessage()) != null)
            {
                switch (message.MessageType)
                {
                    case NetIncomingMessageType.Data: // Handle data recieved from current client
                        PacketHandler.Handle(message, client, server);
                        break;

                    case NetIncomingMessageType.StatusChanged: // Handle connection and status changes
                        Console.WriteLine(message.SenderConnection.Status.ToString());
                        break;

                    default: // Unhandled messages
                        System.Diagnostics.Debug.WriteLine("unhandled message with type: " + message.MessageType);
                        break;
                }
            }
        }
    }
}
