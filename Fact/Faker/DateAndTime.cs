using System;
using Fact.Faker.Utils;

namespace Fact.Faker
{
    public class DateAndTime
    {
        public static DateTime DateTime => Date.Add(Time);

        public static int Day => 31.Randomize(1);

        public static int Month => 12.Randomize(1);

        public static int Year => 9999.Randomize(1);

        public static DateTime Date => new DateTime(Year, Month, Day > DateTime.DaysInMonth(Year, Month) ? DateTime.DaysInMonth(Year, Month) : Day);

        public static DateTime Birthday => new DateTime(DateTime.Now.Year.Randomize((DateTime.Now.Year - 99)), Month, Day > DateTime.DaysInMonth(Year, Month) ? DateTime.DaysInMonth(Year, Month) : Day);

        public static TimeSpan Time => new TimeSpan(24.Randomize(), 60.Randomize(), 60.Randomize());

        public static DayOfWeek dayOfWeek => Date.DayOfWeek;
    }
}
