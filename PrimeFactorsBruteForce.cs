using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class PrimeFactorsBruteForce
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            for(int i = 2; i*i <= number; i++)
            {
                while (number % i == 0)
                {
                    number = number / i;
                    Console.WriteLine(i);
                }
               

            }

        }
    }
}
