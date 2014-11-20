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

            ////int[] test = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int[] test = new int[] { 7,6,5,4,3,2,1 };
            //#region Printing and debugging (BogoSort)
            //long ms1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            
            //PrintArray(test);

            //int[] final = sort.BogoSort(test, 1);
            //PrintArray(final);

            //long ms2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            //Console.WriteLine("BogoSort on array with " + test.Length + " elements took " + (ms2 - ms1) + "ms");
            //#endregion

            ////Before exiting, pause to see results
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

        //Optimizes this for multiprocessor systems!
        static int[][] SplitArray
    }
}
