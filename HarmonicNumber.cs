using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class HarmonicNumber
    {
        public static void HarmonicNumberCom()
        {
            Console.WriteLine("enter the n'th number:");
            int number = int.Parse(Console.ReadLine());
            double j=0;
            for(double i=1; i<=number; i++)
            {
                j = j + 1 / i;
                Console.WriteLine(j);
            }
            Console.WriteLine("Sum of n'th harmonic number"+j);
        }
    }
}
