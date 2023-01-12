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
         internal int[] EnterArray()
        {
            Console.Write("Massivin uzunlugunu daxil et: ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"mass[{i}] = ");
                mass[i] = int.Parse(Console.ReadLine());
            }
            return mass;
        }


        internal int[] SquareRootElements(int[] mass)
        {
            int count = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                    count++;
            }
            
            int[] squarerootElements = new int[count];
            int index = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                    squarerootElements[index++] = mass[i];
            }
            return squarerootElements;
        }

        internal void Print(int[] mass)
        {
            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
        }
    }
}
