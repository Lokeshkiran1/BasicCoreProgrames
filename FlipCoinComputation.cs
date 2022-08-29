using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class FlipCoinComputation
    {
        public static void FlipCoin()
        {
            Console.WriteLine("Enter the number of times you want to flip");
            int flipCount = Convert.ToInt32(Console.ReadLine());
            int head = 0, tail = 0;
            double headPercentage, tailPercentage;
            if (flipCount > 0)
            {
                for (int i = 0; i < flipCount; i++)
                {
                    Random random = new Random();
                    // Console.WriteLine("random"+random);
                    double flipProbability = random.NextDouble();
                    Console.WriteLine("flipProbability " + flipProbability);
                    if (flipProbability > 0.5)
                    {
                        Console.WriteLine("Head Wins");
                        head++;
                    }
                    else
                    {
                        Console.WriteLine("Tails Wins");
                        tail++;
                    }
                }
                headPercentage = head * 100 / flipCount;
                tailPercentage = tail * 100 / flipCount;
                Console.WriteLine("head percentage {0} & tail percentage {1}", headPercentage, tailPercentage);
            }
            else
            {
                Console.WriteLine("flip should be valid count");
            }
        }
    }
}