﻿using System;

namespace TollFeeCalculator.Utils
{
    public static class DateTimeExtensions
    {
        public static bool IsBetweenTimes(this DateTime date, string startTime, string endTime)
        {
            var startHour = int.Parse(startTime.Split(':')[0]);
            var startMinute = int.Parse(startTime.Split(':')[1]);
            var endHour = int.Parse(endTime.Split(':')[0]);
            var endMinute = int.Parse(endTime.Split(':')[1]);

            var intervalStart = new DateTime(date.Year, date.Month, date.Day, startHour, startMinute, 0);
            var intervalEnd = new DateTime(date.Year, date.Month, date.Day, endHour, endMinute, 0);

            return IsInInterval(date, intervalStart, intervalEnd);
        }

        public static bool IsInInterval(this DateTime date, DateTime intervalStart, DateTime intervalEnd)
        {
            return date >= intervalStart
                && date < intervalEnd;
        }
    }
}
