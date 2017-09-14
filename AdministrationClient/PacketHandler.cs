using System;
using System.Reflection;
using Lidgren.Network;

namespace AdministrationClient
{
    public static class PacketHandler
    {
        private delegate void Handler(NetIncomingMessage message, NetClient client, NetConnection server);
        private static Handler[,] handlers = InitializeHandlers();

        private static Handler[,] InitializeHandlers()
        {
            handlers = new Handler[256, 256];

            foreach (var type in Assembly.GetCallingAssembly().GetTypes())
            {
                if (type.Namespace == typeof(Handler).Namespace + ".Handlers" && type.Name.EndsWith("Handler"))
                {
                    PacketFamily family = (PacketFamily)Enum.Parse(typeof(PacketFamily), type.Name.Substring(0, type.Name.Length - 7));

                    foreach (MethodInfo method in type.GetMethods())
                    {
                        if (method.IsStatic && method.Name.StartsWith("Handle"))
                        {
                            PacketAction action = (PacketAction)Enum.Parse(typeof(PacketAction), method.Name.Substring(6));

                            handlers[(byte)family, (byte)action] = (Handler)Delegate.CreateDelegate(typeof(Handler), method);
                        }
                    }
                }
            }

            return handlers;
        }

        public static void Handle(NetIncomingMessage message, NetClient client, NetConnection server)
        {
            PacketFamily family = (PacketFamily)message.ReadByte();
            PacketAction action = (PacketAction)message.ReadByte();
            Handler handler = handlers[(byte)family, (byte)action];

            if (handler == null)
                System.Diagnostics.Debug.WriteLine("No handler set for " + family + "_" + action);
            else
                lock (client)
                {
                    handler(message, client, server);
                }
        }

    }
}
