using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class TimestampProvider
    {
        private readonly ITimeProvider _timeProvider;

        public TimestampProvider(ITimeProvider timeProvider) 
        {
            _timeProvider = timeProvider;
        }
        public string GetTimestamp()
        {
            var day = _timeProvider.GetDay();
            var month = _timeProvider.GetMonth();
            var year = _timeProvider.GetYear();
            var second = _timeProvider.GetSecond();
            var minute = _timeProvider.GetMinute();
            var hour = _timeProvider.GetHour();
            var timeString = $"{month.ToString("00")}/{day.ToString("00")}/{year} {hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}";
            return timeString;
        }
    }
}
