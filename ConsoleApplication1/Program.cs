using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current time zone.
            TimeZone zone = TimeZone.CurrentTimeZone;
            string standard = zone.StandardName;
            string daylight = zone.DaylightName;
            Console.WriteLine(standard);
            Console.WriteLine(daylight);
            Console.Read();
        }
    }
}
