using System;

namespace C_Sharp_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Arrays\n");
                Console.WriteLine("Array A: 0, 2, 4, 6, 8, 10");
                Console.WriteLine("Array B: 1, 3, 5, 7, 9");
                Console.WriteLine("Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9\n\n");

                {
                    Average start = new Average();
                    Console.WriteLine();
                }

                {
                    Reversal start = new Reversal();
                    Console.WriteLine();
                }

                {
                    Rotation start = new Rotation();
                    Console.WriteLine();
                }

                {
                    Sort start = new Sort();
                    Console.WriteLine();
                }
                    
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }

        }

    }

}
