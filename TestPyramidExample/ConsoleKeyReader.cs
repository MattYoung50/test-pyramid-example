using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class ConsoleKeyReader : IKeyReader
    {
        public ConsoleKey ReadKey()
        {
            return Console.ReadKey().Key;
        }
    }
}
