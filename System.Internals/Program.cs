namespace System.Internals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of your class
            NetworkInfo networkInfo = new NetworkInfo();
            // Call the method to display network details
            networkInfo.DisplayNetworkDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
