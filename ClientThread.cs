using System;
using System.Net.Sockets;

namespace Webserver_SJ
{
    public class ClientThread
    {
        private Socket socket;

        public ClientThread(Socket socket)
        {
            this.socket = socket;
      
        }
        public void run()
        {
            
            Console.WriteLine("connected");
        }
    }
}
