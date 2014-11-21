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
            int[] splitTest = new int[] { 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[][] splitResult = SplitArray(splitTest, Environment.ProcessorCount);
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

        //Optimizes this for multiprocessor systems!
        static int[][] SplitArray(int[] inArray, int procs)
        {
            /* Let's say we have a 7-value array and 4 procs
             * fuck it
             */
            bool done = false;
            int[][] ret = new int[procs][];
            int i, x, y;
            int tempCount = 0;
            int firstDiv = inArray.Length / procs; 
            while (!done)
            {
                for (i = 0; i < firstDiv; i++)
                {

                }
                for (x = 0; x < procs; x++)
                {
                    for (y = tempCount; y < firstDiv; y++)
                    {
                        ret[x][y] = inArray[tempCount];
                    }
                    tempCount += y;
                }
                done = true; 
            }
            return ret;
        }
    }
}
