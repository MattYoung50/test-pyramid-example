namespace example
{
    public class TestPyramidExample
    {
        public void Run()
        {
            Console.WriteLine("Press any key to send a packet. Press Enter to exit.");
            int packetCounter = 0;
            var key = Console.ReadKey();
            while(key.Key != ConsoleKey.Enter)
            {
                Console.WriteLine($"\nSent packet {packetCounter++}");
                key = Console.ReadKey();
            }
        }
    }
}