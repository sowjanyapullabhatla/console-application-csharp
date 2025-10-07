namespace System.Internals
{
    class Program
    {
        static void Main(string[] args)
        {
            WrkHw wrkHw = new WrkHw();
            wrkHw.GetSystemHardwareInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
