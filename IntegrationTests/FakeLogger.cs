using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeLogger : ILogger
    {
        public List<string> LogMessages { get; } = new List<string>();
        public void WriteLine(string message)
        {
            LogMessages.Add(message);
        }
    }
}
