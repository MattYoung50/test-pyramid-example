using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeTimeProvider : ITimeProvider
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public FakeTimeProvider(int day, int month, int year, int hour, int minute, int second)
        {
            Day = day;
            Month = month;
            Year = year;
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public int GetDay() => Day;
        public int GetMonth() => Month;
        public int GetYear() => Year;
        public int GetHour() => Hour;
        public int GetMinute() => Minute;
        public int GetSecond() => Second;
    }
}
