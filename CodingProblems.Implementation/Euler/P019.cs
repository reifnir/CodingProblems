using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P019
    {
        public static int CountOfSundaysOnMonthStartInClosedInterval(DateTime start, DateTime end)
        {
            int output = 0;

            var workingDate = NextFirstOfMonth(start);
            while (workingDate <= end)
            {
                if (workingDate.DayOfWeek == DayOfWeek.Sunday)
                    output++;

                workingDate = workingDate.AddMonths(1);
            }

            return output;
        }

        private static DateTime NextFirstOfMonth(DateTime date)
        {
            return date.Day == 1 ? date : new DateTime(date.Year, date.Month, 1).AddMonths(1);
        }
    }
}
