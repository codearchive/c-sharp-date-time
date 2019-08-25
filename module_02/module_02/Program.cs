using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"StockData.csv");

            foreach (var line in lines.Skip(1))
            {
                var segmants = line.Split(',');

                var tradeDate = DateTime.Parse(segmants[1], CultureInfo.GetCultureInfo("us-US"));

                Console.WriteLine(tradeDate.ToLongDateString());
            }
        }
    }
}
