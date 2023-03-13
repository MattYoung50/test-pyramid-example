using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeEnvironmentProvider : IEnvironmentProvider
    {
        private int _exitCode;
        public int GetExitCode() => _exitCode;
        public void Exit(int exitCode)
        {
            _exitCode = exitCode;
        }
    }
}
