

using System;

namespace Classes
{
    class Point
    {
        private int _x = 0;                         // declared 4 private instance fields and initialized them
        private int _y = 0;
        private int _z = 0;
        private static int objectCount = 0;         // static makes objectCount a class variable shared by all objects of that class
        private int serialNum;                      // Creates instance field serialNum
        public static int ObjectCount()             // class method
        {
           return objectCount;
        }
            

        public Point()                                      // This is the default constructor
        {
            _x = -1;                                            // Assigned parameters to private fields
            _y = -1;
            objectCount++;
            serialNum = objectCount;
            Console.WriteLine($"Default constructor called, point number {serialNum}");
        }

        public Point(int x, int y)                          // This is the constructor
        {
            _x = x;                                         // Assigned parameters to private fields
            _y = y;
            objectCount++;
            serialNum = objectCount;
            Console.WriteLine($"x = {x}, y = {y}, point number {serialNum}");
        }
        public Point(int x, int y, int z)                          // This is the constructor
        {
            _x = x;
            _y = y;
            _z = z;
            objectCount++;
            serialNum = objectCount;
            Console.WriteLine($"x = {_x}, y = {_y}, z = {_z}"); 
        }

        public double DistanceTo(Point other)              // other contains memory address of Point which itself contains another memory address.
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public double DistanceToTriple(Point other2)
        {
            int xDiff = _x - other2._x;
            int yDiff = _y - other2._y;
            int zDiff = _z - other2._z;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff) + zDiff * zDiff);
            return distance;
        }

    }
}