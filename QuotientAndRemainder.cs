using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class QuotientAndRemainder
    {
        public static void QuotRem()
        {
            Console.WriteLine("enter the dividend:");
            double dividend = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the divisor:");
            double divisor=double.Parse(Console.ReadLine());
            double quotient=dividend/divisor;
            double remainder=dividend%divisor;
            Console.WriteLine("quotient: "+quotient);
            Console.WriteLine("remainder: "+remainder);
        }
    }
}
