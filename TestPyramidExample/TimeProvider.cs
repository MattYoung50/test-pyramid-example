using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class TimeProvider : ITimeProvider
    {
        public int GetDay() => DateTime.Now.Day;
        public int GetHour() => DateTime.Now.Hour;
        public int GetMinute() => DateTime.Now.Minute;
        public int GetMonth() => DateTime.Now.Month;
        public int GetSecond() => DateTime.Now.Second;
        public int GetYear() => DateTime.Now.Year;
    }
}
