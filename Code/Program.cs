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

            //Before exiting, pause to see results
            int[] splitTest = new int[] { 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[][] splitResult = SplitArray(splitTest, Environment.ProcessorCount); 

            Console.WriteLine(splitResult.Length);
            throw new Exception();
            //Console.ReadKey();
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

        /* Optimizes this for multiprocessor systems! */
        static int[][] SplitArray(int[] inArray, int procs)
        {
            int[][] ret = new int[procs][];
            int tmpCount = 0;
            int div = inArray.Length / procs;
            int mod = inArray.Length % procs;
            bool useMod = mod != 0;

            Console.WriteLine("mod: " + mod);
            Console.WriteLine("useMod: " + useMod);
            /* Initialize the elements of the jagged array */
            for (int i = 0; i < procs; i++)
            {
                if (useMod)
                {
                    ret[i] = new int[div + mod];
                    useMod = false;
                }
                ret[i] = new int[div];
            }

            /* Initialize the jagged array with the split inArray */
            for (int i = 0; i < procs; i++) /* Here, i is the collection of elements of the jagged array that runs on one core */
            {
                for (int l = 0; l < div; l++) /* Here, l is what each core is getting */
                {
                    ret[i][l] = inArray[tmpCount];
                    tmpCount++;
                }
            }

            return ret;
        }
    }
}
