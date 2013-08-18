using System;
using System.Net;

namespace MyIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    Console.WriteLine(localIP);
                }
            }
            Console.ReadLine();
        }
    }
}
