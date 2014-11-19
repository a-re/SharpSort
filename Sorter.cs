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
        private Random r = new Random();
        public int[] BogoSort(int[] input)
        {

        }

        //ref keyword is like passing a pointer argument :D
        private void BogoShuffle(ref int[] input)
        {
            input[r.Next(input.Length + 1)] = input[r.Next(input.Length + 1)];
        }
    }
}
