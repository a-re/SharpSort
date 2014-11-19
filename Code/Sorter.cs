using System;

namespace SharpSort
{
    class Sorter
    {
        public Sorter() { }

        Random r = new Random();
        bool sorted = false;

        public int[] BogoSort(int[] input)
        {
            loop: while(!sorted)
            {
                for (int l = 0; l < input.Length; l++)
                {
                    if (l == input.Length - 1) 
                    {
                        Console.Write("EXITING: ");
                        foreach (int intt in input) { Console.Write(intt + " "); }
                        sorted = true;
                        goto loop; 
                    }
                    if (input[l] < input[l + 1])
                    {
                        //Console.WriteLine("Shuffling..."); 
                        l = 0;
                        BogoShuffle(input);
                        continue;
                    }
                    //Console.WriteLine("Sorted! input[l]: " + input[l] + "  input[l + 1]: " + input[l + 1]);
                }
            }
            return input;
        }

        private void BogoShuffle(int[] input)
        {
            //Console.Write("BEFORE: ");
            //foreach (int intt in input) { Console.Write(intt); }
            //Console.WriteLine();

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

                //Console.WriteLine("l: " + l + " rand: " + rand);
                //foreach (int intt in input) { Console.Write(intt); }
                //Console.WriteLine();
            }
        }
    }
}
