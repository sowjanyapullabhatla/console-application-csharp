using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace System.Internals
{
    public class NetworkInfo
    {
        public void DisplayNetworkDetails()
        {
            string hostName = Dns.GetHostName(); // Get host name
            Console.WriteLine($"Host Name: {hostName}");

            // Get IP addresses
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);

            Console.WriteLine("IP Addresses:");
            foreach (IPAddress address in addresses)
            {
                // Display only IPv4 addresses (ignore IPv6)
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    Console.WriteLine($"- {address}");
                }
            }
        }
    }
}
