using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Webserver_SJ
{
    public class Server
    {
        private string ip;
        private int threads,port;
        private TcpListener tcpListener;

        public Server(string ip, int threads, int port)
        {
            this.ip = ip;
            this.threads = threads;
            this.port = port;

            tcpListener = new TcpListener(IPAddress.Parse(ip),port);

        }

        public void StartServer()
        {
            while (true)
            {

                Socket clientSocket = tcpListener.AcceptSocket();

                ClientThread client = new ClientThread(clientSocket);
                Thread clnThrd = new Thread(ThreadStart(client.run);

                clnThrd.Start();
            }
        }

    }
}
