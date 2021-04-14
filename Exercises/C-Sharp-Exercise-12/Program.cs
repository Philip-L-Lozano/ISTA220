using System;
using System.Collections.Generic;

namespace C_Sharp_Exercise_12
{
    class Program
    {
        // fix error handling and return to main menu.

        static void Main(string[] args)
        {
            int selection;
            int numProblems;            

            Console.WriteLine("Welcome to Math Games!\n");

            Console.WriteLine("Please select a game to practice: ");
            Console.WriteLine("[1]: Addition");
            Console.WriteLine("[2]: Subtraction");
            Console.WriteLine("[3]: Multiplication");
            Console.WriteLine("[4]: Division");
            string input = Console.ReadLine();
            selection = int.Parse(input);
            if (selection >= 1 && selection <= 4)
            {
                Console.WriteLine("Please select the number of problems you wish to practice (up to 10): "); 
                string input2 = Console.ReadLine();
                numProblems = int.Parse(input2);
                if (numProblems >= 1 && numProblems <= 10)
                {
                    if (selection == 1)
                        Addition(numProblems);
                    else if (selection == 2)
                        Subtraction(numProblems);
                    else if (selection == 3)
                        Multiplication(numProblems);
                    else if (selection == 4)
                        Division(numProblems);
                    else
                    {
                        Console.WriteLine("Please enter a valid selection.");
                    }
                }
                else
                {
                    Console.WriteLine("Please select a number between 1 and 10.");
                }
            }
            else
                Console.WriteLine("Please select a valid choice.");
            
        }
        public static void Addition(int numProblems)
        {
            int numOperands = numProblems * 2;
            List<int> rN = new List<int>(numOperands);
            Random r = new Random();
            int i = 0;
            int j = 0;
            int cA = 0;
            while (rN.Count < numOperands)
            {
                rN.Add(r.Next(1, 11));
            }
            while (i < numProblems) 
            {
                Console.WriteLine($"{rN[j]} + {rN[j + 1]} = ");
                string input = Console.ReadLine();
                int userAnswer = int.Parse(input);
                int correctAnswer = rN[j] + rN[j + 1];
                if (correctAnswer == userAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    cA++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}\n");
                }                                 
                j += 2;
                i++;
            }
            Console.WriteLine($"You're total score was {(cA / numProblems).ToString("0.00%")}"); // returns only 0% or 100%. Why?
        }
        private static void Subtraction(int numProblems)
        {
            int numOperands = numProblems * 2;            
            Random r = new Random();
            int[] high = new int [numOperands / 2];
            int[] low = new int[numOperands / 2];            
            int j = 0;
            int cA = 0;
            for (int i = 0; i < high.Length - 1; i++)
            {
                high[i] = r.Next(6, 11); // can populate 0. Why?
                low[i] = r.Next(1, 6);   // can populate 0. Why?
            }
            while (j < numProblems)
            {
                Console.WriteLine($"{high[j]} - {low[j]} = "); // always gives 0-0 for last question. Why?
                string input = Console.ReadLine();
                int userAnswer = int.Parse(input);
                int correctAnswer = high[j] - low[j];
                if (correctAnswer == userAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    cA++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}\n");
                }                
                j++;
            }
            Console.WriteLine($"You're total score was {(cA / numProblems).ToString("0.00%")}");
        }

        private static void Multiplication(int numProblems)
        {
            int numOperands = numProblems * 2;
            List<int> rN = new List<int>(numOperands);
            Random r = new Random();
            int i = 0;
            int j = 0;
            int cA = 0;
            while (rN.Count < numOperands)
            {
                rN.Add(r.Next(1, 11));
            }
            while (i < numProblems)
            {
                Console.WriteLine($"{rN[j]} x {rN[j + 1]} = ");
                string input = Console.ReadLine();
                int userAnswer = int.Parse(input);
                int correctAnswer = rN[j] * rN[j + 1];
                if (correctAnswer == userAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    cA++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}\n");
                }
                j += 2;
                i++;
            }
            Console.WriteLine($"You're total score was {(cA / numProblems).ToString("0.00%")}"); // returns only 0% or 100%. Why?
        }

        private static void Division(int numProblems)
        {
            Console.WriteLine("Please round your answers to the nearest hundredths.\n");
            int numOperands = numProblems * 2;
            List<float> rN = new List<float>(numOperands);
            Random r = new Random();
            int i = 0;
            int j = 0;
            int cA = 0;
            while (rN.Count < numOperands)
            {
                rN.Add(r.Next(1, 11));
            }
            while (i < numProblems)
            {
                Console.WriteLine($"{rN[j]} / {rN[j + 1]} = ");
                string input = Console.ReadLine();
                float userAnswer = float.Parse(input);
                float correctAnswer = (float) Math.Round((rN[j] / rN[j + 1]), 2);
                if (correctAnswer == userAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    cA++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}\n");
                }
                j += 2;
                i++;
            }
            Console.WriteLine($"You're total score was {(cA / numProblems).ToString("0.00%")}"); // returns only 0% or 100%. Why?
        }

        
    }
}
