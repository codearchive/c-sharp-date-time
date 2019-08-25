using System;
using System.Globalization;

namespace module_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------Unit 2.1----------

            //var lines = File.ReadAllLines(@"StockData.csv");

            //foreach (var line in lines.Skip(1))
            //{
            //    var segmants = line.Split(',');

            //    var tradeDate = DateTime.Parse(segmants[1], CultureInfo.GetCultureInfo("us-US"));

            //    Console.WriteLine(tradeDate.ToLongDateString());
            //}



            // ----------Unit 2.3---------- 

            //var now = DateTime.Now;

            //TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            //var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);

            //Console.WriteLine(now);
            //Console.WriteLine(sydneyTime);



            // ----------Unit 2.4---------- 

            //var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(5));

            //foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            //{
            //    if (timeZone.GetUtcOffset(time) == time.Offset)
            //    {
            //        Console.WriteLine(timeZone);
            //    }
            //}



            // ----------Unit 2.5----------

            var date_0 = "9/10/2019 10:00:00 PM";
            var parsedDate_0 = DateTime.ParseExact(date_0, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            Console.WriteLine(parsedDate_0);

            var date_1 = "2019-07-01 10:00:00 PM +02:00";
            var parsedDate_1 = DateTime.Parse(date_1, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
            Console.WriteLine(parsedDate_1);
            Console.WriteLine(parsedDate_1.Kind);

        }
    }
}
