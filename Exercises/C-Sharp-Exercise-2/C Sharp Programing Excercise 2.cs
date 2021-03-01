using System;

namespace C_Sharp_Programing_Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("\nPart 1, sum 10 numbers.");
         Console.WriteLine("Enter 10 scores to add: ");
         int sum = SumTenInts(0, 1);         
         Console.WriteLine($"The sum of ten integers is {sum}");

         Console.WriteLine("\nPart 2, average 10 numbers.");
         Console.WriteLine("Enter 10 scores to average: ");
         double avg = AvgTenInts(0, 1);
         char letterGrade = ConvertNumericToLetterGrade(avg);
         Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");



         Console.WriteLine("\nPart 3, average user predetermined number of scores.");
         Console.WriteLine("Enter the total number of scores to average: ");
         string inputNumber = Console.ReadLine();
         int numScores = int.Parse(inputNumber);
         Console.WriteLine("Enter scores to average: ");
         double avg1 = AvgUnkInts(0, 1, numScores);
         char letterGrade1 = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade1}");



         Console.WriteLine("\nPart 4, average non-redetermined number of scores.");
         Console.WriteLine("Enter scores to average. ");
         double avg2 = AvgAnyInts(0, 1);
         char letterGrade2 = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade2}");

        }

        private static char ConvertNumericToLetterGrade(double avg)
        {
            switch (avg)
            {
                case double n when n >= 90:
                    return 'A';
                    
        
                case double n when n >= 80 && n < 90:
                    return 'B';
                   
        
                case double n when n >= 70 && n < 80:
                    return 'C';


                case double n when n >= 60 && n < 70:
                    return 'D';


                case double n when n < 60:
                    return 'F';

                default:
                    return ' ';
                
            }
        
        }

        private static double AvgAnyInts(int sum, int count)
        {
            string input = Console.ReadLine();
            {

                if (input == "stop")
                    return sum / --count;
                else 
                    sum += int.Parse(input);
                
                if (count > 0)
                    return AvgAnyInts(sum, count + 1);
                else
                    return 0;
            }
        }
        
        private static double AvgUnkInts(int sum, int count, int numScores)
        {                                     
            string input = Console.ReadLine();           
            sum += int.Parse(input);
            double avg1 = sum / numScores;
            if (count < numScores)
                return AvgUnkInts(sum, count + 1, numScores);
            else
                return avg1;
        }

        private static double AvgTenInts(int sum, int count)
        {           
            string input = Console.ReadLine();            
            sum += int.Parse(input);
            double avg = sum / count;
            if (count < 10) 
                return AvgTenInts(sum, count + 1);
            else
                return avg;
        }

        private static int SumTenInts(int sum, int count)
        {
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return SumTenInts(sum, count + 1);
            else
                return sum;
        }
    }
}
