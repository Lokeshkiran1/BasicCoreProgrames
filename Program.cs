﻿using System;
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
            Console.WriteLine("1.Flip Coin Problem\n2.Leap Year Identification\n3.PowerOfTwoComputation\n");
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

                default:
                    Console.WriteLine("enteres wrong choice");
                    break;
            }

        }
    }
}
