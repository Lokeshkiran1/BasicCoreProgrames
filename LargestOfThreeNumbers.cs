using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class LargestOfThreeNumbers
    {
        public static void largest()
        {
            Console.WriteLine("enter the number1");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the number2");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the number3");
            double number3 = double.Parse(Console.ReadLine());
            if (number1 == number2 && number2 == number3)
            {
                Console.WriteLine("three numbers are equal");
            }
                if (number1 > number2)
                {
                    if (number1 > number3)
                    {
                        Console.WriteLine(number1 + " greater");
                    }
                    else
                    {
                        Console.WriteLine(number3 + " greater");
                    }
                }
                else if (number2 > number3)
                {
                    Console.WriteLine(number2 + " greater");
                }
                else
                {
                    Console.WriteLine(number3 + " greater");
                }
            
        }
    }
}
