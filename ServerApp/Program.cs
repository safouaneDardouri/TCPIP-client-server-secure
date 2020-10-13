using Examples.System.Net;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace ServerApp
{
    class Program
    {
        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();
        static X509Certificate serverCertificate = null;


        static void Main(string[] args)
        {
            SslTcpServer a = new SslTcpServer();
        }
    }
}
