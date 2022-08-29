using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograme
{
    internal class VowelsConsonant
    {
        public static void VowelsConsonantIdentification()
        {
            Console.WriteLine("Enter the charactor:");
            char ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine(ch + " is a Vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is a consonant");
            }
            else
            {
                Console.WriteLine("please enter only character!");
            }
        }
    }
}
