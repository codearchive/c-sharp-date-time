using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace module_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);

            Console.WriteLine(contractDate);

            contractDate = ExtendContract(contractDate, 1);

            Console.WriteLine(contractDate);
        }

        private static DateTimeOffset ExtendContract(DateTimeOffset current, int months)
        {
            var newContractDate = current.AddMonths(months).AddTicks(-1);

            return new DateTimeOffset(newContractDate.Year, newContractDate.Month, DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month), 23, 59, 59, current.Offset);
        }
    }
}
