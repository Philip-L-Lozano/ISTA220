using System;

namespace C_Sharp_Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Part 1. Circumference and area of a circle.");
            Console.Write("Enter and intiger for the radius.");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;

            Console.WriteLine($"\nThe circumference is {circumference}");
            double area = Math.PI * intradius * intradius;
            Console.WriteLine($"The area is {area}");




            Console.WriteLine("\nPart 2. Volume of a hemisphere.");
            Console.Write("Enter and intiger for the radius.");
            string strvolradius = Console.ReadLine();
            int volradius = int.Parse(strvolradius);
            double volume = (((4 / 3) * Math.PI * volradius * volradius * volradius) / 2);
            Console.WriteLine($"The volume is {volume}");




            Console.WriteLine("\nPart 3. Area of a triangle (Heron's Formula).");
            Console.Write("Enter 3 intigers for the lengths of the sides of the triangle.\n");
            Console.Write("Side1: ");
            string side1 = Console.ReadLine();
            Console.Write("Side2: ");
            string side2 = Console.ReadLine();
            Console.Write("Side3: ");
            string side3 = Console.ReadLine();

            int sides = int.Parse(side1 + side2 + side3);
            double trianglearea = sides / 2;
            Console.WriteLine($"The area is {trianglearea}");




            Console.WriteLine("\nPart 4. Solving a Quadratic Equation).");
            Console.Write("Enter 3 intigers for the coefficients of a quadratic equation\n");
            Console.Write("Coefficient a: ");
            string coefficientA = Console.ReadLine();
            Console.Write("Coefficient b: ");
            string coefficientB = Console.ReadLine();
            Console.Write("Coefficient c: ");
            string coefficientC = Console.ReadLine();

            int coefficientAint = int.Parse(coefficientA);
            int coefficientBint = int.Parse(coefficientB);
            int coefficientCint = int.Parse(coefficientC);
            double positive_num = (-coefficientBint + Math.Sqrt((coefficientBint * coefficientBint) - (4 * coefficientAint * coefficientCint)));
            double negative_num = (-coefficientBint - Math.Sqrt((coefficientBint * coefficientBint) - (4 * coefficientAint * coefficientCint)));
            double denominator = 2 * coefficientAint;
            Console.WriteLine($"The positive solution is{positive_num / denominator}");
            Console.WriteLine($"The negative solution is{negative_num / denominator}");







        }
    }
}
