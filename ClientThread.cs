using System;
using System.Net.Sockets;

namespace Webserver_SJ
{
    public class ClientThread
    {

        public ClientThread(Socket socket)
        {

        }
        public void run()
        {
            Console.WriteLine("connected");
        }
    }
}
