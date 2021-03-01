using System;

namespace C_Sharp_Exercise_5
{
	class Average
	{
		public int[] A = { 0, 2, 4, 6, 8, 10 }; // size 6        
		public int[] B = { 1, 3, 5, 7, 9 }; // size 5
		public int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; // size 12

		public Average()
		{
            Console.WriteLine($"The average of array A is {CalculateAvg(A)}\n" +
                $"The average of array B is {CalculateAvg(B)}\n" +
                $"The average of array C is {CalculateAvg(C)}");
        }

        public static double CalculateAvg(int[] x)
        {
            int count;
            int sum = 0;
            double avg = 0;

            for (int i = 0; i < x.Length; i++)
            {
                count = x.Length;
                sum += x[i];
                avg = sum / count;               
            }

            return avg;
        }

    }
}