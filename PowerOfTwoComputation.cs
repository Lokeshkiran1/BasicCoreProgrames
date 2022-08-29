using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class PowerOfTwoComputation
    {
        public static void ToFindPower()
        {
            int two = 2;
            Console.WriteLine("Give the power value:");
            int exp = int.Parse(Console.ReadLine());
            if (0 <= exp && exp < 31)
            {
                Console.WriteLine("int is overflow");
            }
            double result = Math.Pow(two, exp);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
