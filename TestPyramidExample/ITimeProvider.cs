using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public interface ITimeProvider
    {
        int GetDay();
        int GetMonth();
        int GetYear();
        int GetSecond();
        int GetMinute();
        int GetHour();
    }
}
