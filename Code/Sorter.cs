using System;

namespace SharpSort
{
    class Sorter
    {
        public Sorter() { }

        Random r = new Random();
        bool sorted = false;
        int l;
        #region BogoSort!
        public int[] BogoSort(int[] input)
        {
            while(!sorted)
            {
                for (l = 0; l < input.Length; l++)
                {
                    #region WORKING CODE
                    //if (l == input.Length - 1) 
                    //{
                    //    Console.Write("EXITING: ");
                    //    foreach (int intt in input) { Console.Write(intt + " "); }
                    //    sorted = true; break;
                    //}
                    //if (input[l] > input[l + 1])
                    //{
                    //    l = 0;
                    //    BogoShuffle(input);
                    //    continue;
                    //}
                    #endregion
                    if (l >= input.Length)
                    {
                        if (input[l - 1] > input[l])
                        {
                            l = 0;
                            BogoShuffle(input);
                            continue;
                        }
                        Console.Write("EXITING: ");
                        foreach (int intt in input) { Console.Write(intt + " "); }
                        sorted = true; break;
                    }
                    if (input[l] > input[l + 1])
                    {
                        l = 0;
                        BogoShuffle(input);
                        continue;
                    }
                }
            }
            return input;
        }

        private void BogoShuffle(int[] input)
        {
            bool tempNum = false;
            int rand = 0;
            for (int l = 0; l < input.Length; l++)
            {
                while(!tempNum)
                {
                    rand = r.Next(input.Length);
                    if (rand != l) { tempNum = true; }
                }

                int atRand = input[l];
                input[l] = input[rand];
                input[rand] = atRand;
            }
        }
        #endregion
    }
}
