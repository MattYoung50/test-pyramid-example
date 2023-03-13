using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeKeyReader : IKeyReader
    {
        public event EventHandler<ConsoleKey>? KeyPressed;
        public void InjectKeyPress(ConsoleKey key)
        {
            KeyPressed?.Invoke(this, key);
        }
    }
}
