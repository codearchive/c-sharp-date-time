using System;
using System.Globalization;

namespace module_03
{
    class Program
    {
        private static Calendar calendar = CultureInfo.InvariantCulture.Calendar;

        // from: https://blogs.msdn.microsoft.com/shawnste/2006/01/24/iso-8601-week-of-year-format-in-microsoft-net/
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        
        static void Main()
        {
            // ---------- Unit 3.1 ----------

            //var start = DateTimeOffset.UtcNow;
            //var end = start.AddSeconds(45);
            //TimeSpan difference = end - start;

            //Console.WriteLine(difference.Seconds);



            // ---------- Unit 3.2 ----------

            var start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);

            var week = calendar.GetWeekOfYear(start.DateTime, 
                CalendarWeekRule.FirstFourDayWeek, 
                DayOfWeek.Monday);
            
            Console.WriteLine(week);
            Console.WriteLine(GetIso8601WeekOfYear(start.DateTime));
        }
    }
}
