using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class ConsoleKeyReader : IKeyReader
    {
        public event EventHandler<ConsoleKey>? KeyPressed;
        public ConsoleKeyReader() 
        {
            Task.Run(() => 
            {
                while (true)
                {
                    KeyPressed?.Invoke(this, Console.ReadKey().Key);
                }
            });
        }
    }
}
