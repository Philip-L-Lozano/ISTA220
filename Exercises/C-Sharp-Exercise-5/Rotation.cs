using System;

namespace C_Sharp_Exercise_5
{
	public class Rotation
	{
		public int[] A = { 0, 2, 4, 6, 8, 10 }; // size 6        
		public int[] B = { 1, 3, 5, 7, 9 }; // size 5
		public int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; // size 12


        public Rotation()
        {
            Console.WriteLine("This is array A rotated:\n");
            Rotate(A, 2, 0);
            Console.WriteLine("This is array B rotated:\n");
            Rotate(B, 2, 1);
            Console.WriteLine("This is array C rotated:\n");
            Rotate(C, 4, 0);

        }

        //Array A: 2 left
        //Array B: 2 right
        //Array C: 4 left
        public static void Rotate(int[] x, int places, int direction)
        {
            int[] t = new int[places]; //creates a new temporary array to hold a # of values = the # of places to shift.

            if (direction == 1)
            {
                for (int i = 0; i < places; i++)
                {
                    int final = x[x.Length - 1];

                    for (int j = x.Length - 1; j > 0; j--)
                    {
                        x[j] = x[j - 1];
                    }
                    x[0] = final;
                }

                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine(x[i] + " ");
                }
            }

            else if (direction == 0)
            {
                for (int i = 0; i < places; i++)
                {
                    int temp = x[0];

                    for (int j = 0; j < x.Length - 1; j++)
                    {
                        x[j] = x[j + 1];
                    }
                    x[x.Length - 1] = temp;
                }

                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine(x[i] + " ");
                }
            }





        }

        
    }
}