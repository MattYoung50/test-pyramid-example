using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeConsoleReader : IConsoleReader
    {
        public event EventHandler<string?>? ConsoleInputReceived;
        public void InjectLine(string line)
        {
            ConsoleInputReceived?.Invoke(this, line);
        }
    }
}
