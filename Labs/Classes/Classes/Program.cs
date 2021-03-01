using System;


namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point(3,4);                      // This is the constructor
            Point origin2 = new Point();
            Point origin3 = new Point(3, 5, 7);
            Point bottomRight = new Point(1366, 768);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);
            Point origin4 = new Point(1, 2, 3);
            Console.WriteLine($"distance between point1 and point2 is: " +
                $"{point1.DistanceTo(point2)}");
            Console.WriteLine($"distance between point2 and point1 is: " +
                $"{point2.DistanceTo(point1)}");                            // Instance method DistanceTo is called on the instance Point
            Console.WriteLine($"distance between point1 and point1 is: " +
                $"{point1.DistanceTo(point1)}");
            Console.WriteLine($"The number of points created is: " +
                $"{Point.ObjectCount()}");
            Console.WriteLine($"distance between origin3 and origin4 is: " +
                $"{origin3.DistanceToTriple(origin4)}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
