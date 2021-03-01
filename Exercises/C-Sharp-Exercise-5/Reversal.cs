using System;

namespace C_Sharp_Exercise_5
{
	class Reversal
	{
		public int[] A = { 0, 2, 4, 6, 8, 10 }; // size 6        
		public int[] B = { 1, 3, 5, 7, 9 }; // size 5
		public int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; // size 12

		public Reversal()
		{
            Console.WriteLine("This is the reverse of Array A:\n");
			Reverse(A);
			Console.WriteLine("This is the reverse of Array B:\n");
			Reverse(B);
			Console.WriteLine("This is the reverse of Array C:\n");
			Reverse(C);
		}

		public static void Reverse(int[] x)
		{
			for (int i = x.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(x[i] + " ");
			}
		}
	}
}