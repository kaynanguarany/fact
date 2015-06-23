using System.Collections.Generic;
using System.Globalization;

namespace Fact.Faker.BR
{
    public class DateBR : DateAndTime
    {
        public static string Extenso
        {
            get
            {
                var dateTime = Date;
                var culture = new CultureInfo("pt-BR");
                var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

                return $"{ dayOfWeek }, { dateTime.Day } de { culture.DateTimeFormat.GetMonthName(dateTime.Month) } de { dateTime.Year }";
            }
        }
    }
}
