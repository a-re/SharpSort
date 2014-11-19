using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSort
{
    class Sorter
    {
        public Sorter() { }

        Random r = new Random();
        bool sorted = false;

        public int[] BogoSort(int[] input)
        {
            while(!sorted)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (i == input.Length - 1) { sorted = true; continue; } //This cleverly breaks out of the while AND for
                    if (input[i] < input[i + 1] || input[i] == input[i + 1])
                    {
                        //At least one is sorted, continue.
                        continue;
                    }
                    BogoShuffle(ref input);
                }
            }
            return input;
        }

        //ref keyword is like passing a pointer argument :D
        private void BogoShuffle(ref int[] input)
        {
            input[r.Next(input.Length)] = input[r.Next(input.Length)];
        }
    }
}
