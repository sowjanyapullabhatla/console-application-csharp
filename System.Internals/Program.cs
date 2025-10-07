namespace System.Internals
{
    class Program
    {
        static void Main(string[] args)
        {
            WrkHw wrkHw = new WrkHw();
            wrkHw.GetSystemHardwareInfo();

            Console.WriteLine("Hello, World!");
            Console.WriteLine("welcome to programing world!");
            // Create an object of OSdetails
            OSdetails myOS = new OSdetails();

            // Call the method to display OS info
            myOS.DisplayOSDetails();

            // Keep the console open
            // Create an instance of your class
            NetworkInfo networkInfo = new NetworkInfo();
            // Call the method to display network details
            networkInfo.DisplayNetworkDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
