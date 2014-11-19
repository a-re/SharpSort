using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter sort = new Sorter();

            int[] test = new int[] { 9, 6, 3, 4, 8 };
            PrintArray(test);
            Console.WriteLine();

            int[] final = sort.BogoSort(test);
            PrintArray(final);
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
