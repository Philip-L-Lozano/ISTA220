using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Test vehicle");
            Vehicle v = new Vehicle();
            v.StartEngine("RUM RUM");
            v.Drive();
            v.StopEngine("GIN GIN");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive(); // prints "Flying" from Car class from overloaded method in Derived class Airplane.
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine("------------------------------------");
          
            Console.WriteLine("Journey by car:");
            Car Car1 = new Car();
            Car1.StartEngine("Brm brm");
            Car1.Accelerate();
            Car1.Drive(); // prints Motoring"
            Car1.Brake();
            Car1.StopEngine("Phut phut");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\nTesting polymorphism");
            Vehicle w = new Vehicle();
            w.Drive();
            w = Car1;
            w.Drive();
            w = myPlane;
            w.Drive();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Journey by motorcycle");
            Motorcycle mc = new Motorcycle();
            mc.StartEngine("Voom Voom");
            mc.Accelerate();
            mc.Drive();
            mc.Brake();
            mc.StopEngine("Klunk Klunk");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
