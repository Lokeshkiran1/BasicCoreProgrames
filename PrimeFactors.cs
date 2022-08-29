using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class PrimeFactors
    {
        public static void primeFactors()
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());
            for(int b=2; number>1; b++)
            {
                if(number%b==0)
                {
                    int x = 0;
                    while (number%b==0)
                    {
                        number /= b;
                        x++;
                    }
                    Console.WriteLine("{0} is prime factor of {1} times",b,x);

                }
            }
        }
    }
}
