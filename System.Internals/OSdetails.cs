using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Internals
{
    internal class OSdetails
    {
        public void DisplayOSDetails()
        {
            Console.WriteLine("OS Details:");
            Console.WriteLine("------------");

            Console.WriteLine("OS Version: " + Environment.OSVersion);
            Console.WriteLine("OS Platform: " + Environment.OSVersion.Platform);
            Console.WriteLine("Is 64-bit OS: " + Environment.Is64BitOperatingSystem);
            Console.WriteLine("User Name: " + Environment.UserName);
            Console.WriteLine("Machine Name: " + Environment.MachineName);
        }
    }
}