using System;

namespace C_Sharp_Exercise_4
{
    class Program
    {

        static void Main(string[] args)
        {
            void AnimalFarm()
            {              

                {
                    Console.WriteLine("This is a list of the animals on the farm.\n");
                    Cow first = new Cow();
                }
                
                {
                    Horse first = new Horse();
                }

                {
                    Pig first = new Pig();
                }

                {
                    Rabbit first = new Rabbit();
                }

            }

            try
            {
                AnimalFarm();
            }
            catch (Exception)
            {
                Console.WriteLine("done");
            }
        }
    }
}

