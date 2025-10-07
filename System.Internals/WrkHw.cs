// File: Program.cs

using System;
using System.Management;
namespace System.Internals
{
    public  class WrkHw
    {
        public void GetSystemHardwareInfo()
        {
            Console.WriteLine("=== System Hardware Information ===\n");

            // CPU Info
            Console.WriteLine("Processor Information:");
            using (var searcher = new ManagementObjectSearcher("select Name, NumberOfCores, NumberOfLogicalProcessors from Win32_Processor"))
            {
                foreach (var obj in searcher.Get())
                {
                    Console.WriteLine($"CPU Name: {obj["Name"]}");
                    Console.WriteLine($"Cores: {obj["NumberOfCores"]}");
                    Console.WriteLine($"Logical Processors: {obj["NumberOfLogicalProcessors"]}\n");
                }
            }

            // RAM Info
            Console.WriteLine("Memory (RAM) Information:");
            using (var searcher = new ManagementObjectSearcher("select TotalPhysicalMemory from Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    double ramBytes = Convert.ToDouble(obj["TotalPhysicalMemory"]);
                    double ramGB = Math.Round(ramBytes / (1024 * 1024 * 1024), 2);
                    Console.WriteLine($"Total RAM: {ramGB} GB\n");
                }
            }

            // Disk Info
            Console.WriteLine("Disk Drive Information:");
            using (var searcher = new ManagementObjectSearcher("select Model, Size from Win32_DiskDrive"))
            {
                foreach (var obj in searcher.Get())
                {
                    double sizeBytes = Convert.ToDouble(obj["Size"]);
                    double sizeGB = Math.Round(sizeBytes / (1024 * 1024 * 1024), 2);
                    Console.WriteLine($"Drive Model: {obj["Model"]}");
                    Console.WriteLine($"Size: {sizeGB} GB\n");
                }
            }

            // OS Info
            Console.WriteLine("Operating System Information:");
            using (var searcher = new ManagementObjectSearcher("select Caption, Version from Win32_OperatingSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    Console.WriteLine($"OS Name: {obj["Caption"]}");
                    Console.WriteLine($"Version: {obj["Version"]}");
                }
            }
        }
    }
}
