using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Basic Core Programes\n");
            Console.WriteLine("1.Flip Coin Problem\n2.Leap Year Identification\n3.PowerOfTwoComputation\n4.Harmonic Number\n5.PrimeFactors of a given number\n6.Compute Quotient and remainder\n7.Even or odd number\n8.Swapping of two numbers");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoinComputation.FlipCoin();
                    break;
                case 2:
                    LeapYearIdentification.LeapYear();
                    break;
                case 3:
                    PowerOfTwoComputation.ToFindPower();
                    break;
                case 4:
                    HarmonicNumber.HarmonicNumberCom();
                    break;
                case 5:
                    PrimeFactorsBruteForce.PrimeFactors();
                    PrimeFactors.primeFactors();
                    break;
                case 6:
                    QuotientAndRemainder.QuotRem();
                    break;
                case 7:
                    EvenOddComputation.evenOdd();
                    break;
                case 8:
                    SwappingOfNumbers.swapTwoNumbers();
                    break;

                default:
                    Console.WriteLine("enteres wrong choice");
                    break;
            }

        }
    }
}
