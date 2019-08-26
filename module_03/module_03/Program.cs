using System;

namespace module_03
{
    class Program
    {
        static void Main()
        {
            var start = DateTimeOffset.UtcNow;
            var end = start.AddSeconds(45);
            TimeSpan difference = end - start;

            Console.WriteLine(difference.Seconds);
        }
    }
}
