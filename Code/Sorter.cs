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
            while(!sorted)
            {
                for (int l = 0; l < input.Length; l++)
                {
                    if (l == input.Length - 1) { sorted = true; break; }
                    if (!(input[l] < input[l + 1] || input[l] == input[l + 1]))
                    {
                        Console.WriteLine("Shuffling...");
                        BogoShuffle(ref input);
                    }
                    Console.WriteLine("Sorted! input[l]: " + input[l] + "  input[l + 1]: " + input[l + 1]);
                }
            }
            return input;
        }

        //ref keyword is like passing a pointer argument :D
        private void BogoShuffle(ref int[] input)
        {
            Console.WriteLine("BogoShuffle() called!");
            input[r.Next(input.Length)] = input[r.Next(input.Length)];
        }
    }
}
