using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvTapshirigi2
{
    internal class NumberTasks
    {
        internal void Print()
        {
            int reversenumber = ReverseNumber();
            Console.Write(reversenumber);
        }
        internal int ReverseNumber()
        {
            Console.Write("Eded daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int count = (int)Math.Log10(number);
            int r;
            int reversenumber = 0;

            while (number != 0)
            {
                r = number % 10;
                number /= 10;

                reversenumber += r * (int)Math.Pow(10, count);
                count--;
            }
            return reversenumber;
        }

    }
}
