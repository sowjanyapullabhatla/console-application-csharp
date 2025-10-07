namespace System.Internals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("welcome to programing world!");
            // Create an object of OSdetails
            OSdetails myOS = new OSdetails();

            // Call the method to display OS info
            myOS.DisplayOSDetails();

            // Keep the console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
