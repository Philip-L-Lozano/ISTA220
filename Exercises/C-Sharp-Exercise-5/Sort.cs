using System;
namespace C_Sharp_Exercise_5
{
    class Sort
    {
        public int[] A = { 0, 2, 4, 6, 8, 10 }; // size 6        
        public int[] B = { 1, 3, 5, 7, 9 }; // size 5
        public int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; // size 12
      
        public Sort()
        {
            Console.WriteLine("This is Array A sorted:\n");
            Sorting(A);
            Console.WriteLine("This is Array B sorted:\n");
            Sorting(B);
            Console.WriteLine("This is Array C sorted:\n");
            Sorting(C);
        }

        public static void Sorting(int[] x)
        {
            int t;
            for (int i = 0; i < x.Length; i++)
            {
                for (int v = 0; v < x.Length - 1; v++)
                {
                    if (x[v] > x[v + 1])
                    {
                        t = x[v + 1];
                        x[v + 1] = x[v];
                        x[v] = t;
                    }

                    Console.WriteLine(x[i] + " ");
                }
            }
        }
        
    }
}