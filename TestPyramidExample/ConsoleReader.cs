using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class ConsoleReader : IConsoleReader
    {
        public event EventHandler<string?>? ConsoleInputReceived;
        public ConsoleReader() 
        {
            Task.Run(() => 
            {
                while (true)
                {
                    var line = Console.ReadLine();
                    ConsoleInputReceived?.Invoke(this, line);
                }
            });
        }
    }
}
