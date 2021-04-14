using System;

namespace C_Sharp_Exercise_8
{
    class Program
    {        
        static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
      
        static void Main(string[] args)
        {
            int bisectionInput = array.Length / 2;
            Random random = new Random();
            int answer = random.Next(1, 10);
            FindAnswer(array, bisectionInput, answer);
        }
        
        private static void FindAnswer(int[] x, int guess, int answer)
        {
            Console.WriteLine($"The current guess is {guess}");            
            if (guess > answer)
                TooHigh(x, answer);
            else if (guess < answer)
                TooLow(x, answer);
            else
                Console.WriteLine($"The answer is {answer}.");
        }


        static void TooHigh(int[] x, int answer)
        {
            Console.WriteLine("You're number is too high.\n");
            int length = x.Length / 2;
            int[] newArray = new int[length];
            Array.Copy(x, 0, newArray, 0, length);         
            FindAnswer(newArray, newArray[(newArray.Length-1)/2], answer);
        }
        static void TooLow(int[] x, int answer)
        {
            Console.WriteLine("You're number is too low.\n");
            int length = x.Length / 2;
            int[] newArray = new int[length];
            Array.Copy(x, length, newArray, 0, length);          
            FindAnswer(newArray, newArray[(newArray.Length - 1) / 2], answer);
        }
    }
}
