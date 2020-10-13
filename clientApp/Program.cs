using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace clientApp
{
    class Program
    {

        //private static Hashtable certificateErrors = new Hashtable();

        //// The following method is invoked by the RemoteCertificateValidationDelegate.
        //public static bool ValidateServerCertificate(
        //      object sender,
        //      X509Certificate certificate,
        //      X509Chain chain,
        //      SslPolicyErrors sslPolicyErrors)
        //{
        //    if (sslPolicyErrors == SslPolicyErrors.None)
        //        return true;

        //    Console.WriteLine("Certificate error: {0}", sslPolicyErrors);

        //    // Do not allow this client to communicate with unauthenticated servers.
        //    return false;
        //}


        static void Main(string[] args)
        {

            //IPAddress ip = IPAddress.Parse("127.0.0.1");
            //int port = 5000;
            //TcpClient client = new TcpClient();
            //client.Connect(ip, port);
            //Console.WriteLine("client connected!!");
            //NetworkStream ns = client.GetStream();
            //SslStream sslStream = new SslStream(
            //   ns,
            //   false,
            //   new RemoteCertificateValidationCallback(ValidateServerCertificate),
            //   null
            //   );
            //Thread thread = new Thread(o => ReceiveData((TcpClient)o));

            //thread.Start(client);

            //string s;
            //while (!string.IsNullOrEmpty((s = Console.ReadLine())))
            //{
            //    byte[] buffer = Encoding.ASCII.GetBytes(s);
            //    ns.Write(buffer, 0, buffer.Length);
            //}

            //client.Client.Shutdown(SocketShutdown.Send);
            //thread.Join();
            //ns.Close();
            //client.Close();
            //Console.WriteLine("disconnect from server!!");
            //Console.ReadKey();
            SslTcpClient SslTcpClient = new SslTcpClient();
        }

        //static void ReceiveData(TcpClient client)
        //{
        //    NetworkStream ns = client.GetStream();
        //    byte[] receivedBytes = new byte[1024];
        //    int byte_count;

        //    while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
        //    {
        //        Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
        //    }
        //}
    }
}
