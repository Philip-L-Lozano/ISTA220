using System;
using System.Collections.Generic;


namespace C_Sharp_Exercise_11
{
    // Create a collection of random points (integer pairs) numbered between 1 and 100.
    // Create a function that takes 2 points and returns the distance between them.
    // Create a function that iterates through the collection, finds the shortest distance between any 2 points among all points, and returns those 2 points.

    // Create a collection of random points (integer triples) numbered between 1 and 1000. 
    // Create a function that takes 2 points and returns the distance between them.
    // Create a function that iterates through the collection, finds the shortest distance between any 2 points among all points, and returns those 2 points.

    class Program
    {               
        static void Main(string[] args)
        {          
            Console.WriteLine("This is a vector distance calculator.");
            Console.WriteLine("Please enter '2' or '3' for the number of dimensions you wish to calculate points from or enter '0' to quit.");
            bool run = true;
            while (run)
            {
                string input = Console.ReadLine();
                int selection = Int32.Parse(input);
                if (selection == 2)
                {
                    Dictionary<int, Tuple<int, int>> points = CreatePoints2D();
                    
                }
                else if (selection == 3)
                {

                }
                else if (selection == 0)
                {
                    Environment.Exit(0);
                }
                else
                    Console.WriteLine("Please enter a valid selection.");                       
            }           
        }
        private static Dictionary<int, Tuple<int, int>> CreatePoints2D()
        {
            Random random = new Random();
            Dictionary<int, Tuple<int, int>> points = new Dictionary<int, Tuple<int, int>>();
            
            for (int i = 0; i < 100; i++)
            {
                points.Add(i, Tuple.Create(random.Next(1, 101), random.Next(1, 101)));                
            }            
            return points;           
        }

        private static Dictionary<int, Tuple<int, int, int, int, double>> DistanceCalc(Dictionary<int, Tuple<int, int>> points)
        {                        
            Dictionary<int, Tuple<int, int, int, int, double>> pointsWithDistances = new Dictionary<int, Tuple<int, int, int, int, double>>();
            int x1, y1, x2, y2;
            double distance;

            // 1. Read the current value in points.
            // 2. Calculate the distance between the current and next point.
            // 3. Assign/Overwrite the lowest distance if the distance is the lowest or overwrite the distance if it is not the lowest.
            // 4. return the lowest distance with its associated points. 

            foreach (var point in points) 
            {
                x1 = point.Value.Item1;
                y1 = point.Value.Item2;
                x2 = point.Value.Item3; // How do I read the next point in this???
                y2 = point.Value.Item4;
                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                pointsWithDistances.Add(point.Key, Tuple.Create(x1, y1, x2, y2, distance));
            }
            return pointsWithDistances;
          
        }
    }

    struct TwoD
    {
        


    }
    class ThreeD
    {

        
            
        
        
    }
}
