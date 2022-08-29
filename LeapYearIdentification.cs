

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class LeapYearIdentification
    {
        public static void LeapYear()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || year % 400 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }

        }
    }
}