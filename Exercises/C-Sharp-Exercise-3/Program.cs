using System;

namespace C_Sharp_Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1. Circumference and area of a circle.");
            Console.Write("Enter a positive integer for the radius.");
            (double circumference, double area) = CalculateCircle();
            Console.WriteLine($"\nThe circumference is {circumference}");
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2. Volume of a hemisphere.");
            Console.Write("Enter a positive integer for the radius.");
            double volume = CalculateHemisphere();
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3. Area of a triangle (Heron's Formula).");
            Console.Write("Enter 3 positive integers for the lengths of the sides of the triangle.\n");
            (double side1d, double side2d, double side3d) = CalculateTriangle();
            double sides = side1d + side2d + side3d;
            double trianglearea = sides / 2;
            Console.WriteLine($"The area is {trianglearea}");

            Console.WriteLine("\nPart 4. Solving a Quadratic Equation).");
            Console.Write("Enter 3 integers for the coefficients of a quadratic equation\n");
            (int coefficientAint, int coefficientBint, int coefficientCint) = CalculateQuadratic();
            double positive_num = (-coefficientBint + Math.Sqrt((coefficientBint * coefficientBint) - (4 * coefficientAint * coefficientCint)));
            double negative_num = (-coefficientBint - Math.Sqrt((coefficientBint * coefficientBint) - (4 * coefficientAint * coefficientCint)));
            double denominator = 2 * coefficientAint;
            Console.WriteLine($"The positive solution is{positive_num / denominator}");
            Console.WriteLine($"The negative solution is{negative_num / denominator}");
        }

        private static (int coefficientAint, int coefficientBint, int coefficientCint) CalculateQuadratic()
        {
            try
            {
                Console.Write("Coefficient a: ");
                string coefficientA = Console.ReadLine();
                int coefficientAint = int.Parse(coefficientA);

                Console.Write("Coefficient b: ");
                string coefficientB = Console.ReadLine();
                int coefficientBint = int.Parse(coefficientB);

                Console.Write("Coefficient c: ");
                string coefficientC = Console.ReadLine();
                int coefficientCint = int.Parse(coefficientC);

                return (coefficientAint, coefficientBint, coefficientCint);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
                return CalculateQuadratic();
            }         
            finally
            {
                Console.WriteLine("Okay");
            }
        }
        private static (double, double, double) CalculateTriangle()
        {
            try
            {
                Console.Write("Side1: ");
                string side1 = Console.ReadLine();
                double side1d = double.Parse(side1);

                Console.Write("Side2: ");
                string side2 = Console.ReadLine();
                double side2d = double.Parse(side2);

                Console.Write("Side3: ");
                string side3 = Console.ReadLine();
                double side3d = double.Parse(side3);

                if (side1d <= 0)
                {
                    throw new ArgumentException();
                }
                else if (side2d <= 0)
                {
                    throw new ArgumentException();
                }
                else if (side3d <= 0)
                {
                    throw new ArgumentException();
                }
                return (side1d, side2d, side3d);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter a number greater than 0");
                return CalculateTriangle();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
                return CalculateTriangle();
            }           
            finally
            {
                Console.WriteLine("Okay");
            }
        }   

        private static double CalculateHemisphere()
        {
            try
            {
                string strvolradius = Console.ReadLine();
                int volradius = int.Parse(strvolradius);
                double volume = (((4 / 3) * Math.PI * volradius * volradius * volradius) / 2);

                if (volradius <= 0)
                {
                    throw new ArgumentException();
                }
                return volume;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter a number greater than 0");
                return CalculateHemisphere();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
                return CalculateHemisphere();
            }           
            finally
            {
                Console.WriteLine("Okay");
            }
        }
        private static (double, double) CalculateCircle()
        {
            try
            {
                string strradius = Console.ReadLine();
                int intradius = int.Parse(strradius);
                double circumference = 2 * Math.PI * intradius;
                double area = Math.PI * intradius * intradius;
                
                if (intradius <= 0)
                {
                    throw new ArgumentException();
                }

                return (circumference, area);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter a number greater than 0");
                return CalculateCircle();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
                return CalculateCircle();
            }         
            finally
            {
                Console.WriteLine("Okay");
            }
        }
    }
}
