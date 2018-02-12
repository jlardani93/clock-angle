using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ClockAngleProject.Models
{
    public class Clock
    {
        private int _hour;
        private int _hourAngle;
        private int _minute;
        private int _minuteAngle;

        public void SetHour(string hour)
        {
            _hour = Int32.Parse(hour);
            _hourAngle = 30 * Int32.Parse(hour) + _minute/2;
        }

        public void SetMinute(string minute)
        {
            _minute = Int32.Parse(minute);
            _minuteAngle = 6 * Int32.Parse(minute);
        }

        public string GetHour()
        {
            return _hour.ToString();
        }

        public string GetMinute()
        {
            return _minute.ToString();
        }

        public int GetHourAngle()
        {
            return _hourAngle;
        }

        public int GetMinuteAngle()
        {
            return _minuteAngle;
        }

        public string CalculateAngle()
        {
            int result = Math.Abs(_hourAngle - _minuteAngle);
            if (result > 180)
            {
                result = 360 - result;
            }
            return result.ToString();
        }
    }
}
