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

            int[] test = new int[] { 0,1,2,3,4,5,6,7,8,9,10,11,12 };
            PrintArray(test);

            int[] final = sort.BogoSort(test);
            PrintArray(final);
            
            //Before exiting, pause to see results
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine();
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
