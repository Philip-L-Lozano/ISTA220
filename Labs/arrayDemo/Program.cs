using System;

namespace arrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Demo");
            int[] phil = { 1, 2, 65, 46, 300, 700, 89, 1000, 3, 67 };
            for(int i = 0; i < phil.Length; i++)
            {
                if (i == 2) phil[i] = 64; // changes number at index 2 to 64
                Console.WriteLine($"{i}. {phil[i]}"); // 
            }
            Console.WriteLine("-------------------------");

            int counter = 0;
            foreach(int e in phil) // foreach dereferences the array reference and returns the value stored at the index.
            {
                Console.WriteLine($"{counter++}. {e}");
            }

        }
    }
}
