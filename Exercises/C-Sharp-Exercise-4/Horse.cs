using System;

namespace C_Sharp_Exercise_4
{
    internal class Horse
    {
        public string Name;
        public string Sound;
        public string Size;
        public string Type;

        public Horse()
        {
            
            Horse frank = new Horse("Stallion", "Frank", "big", "Neh\n");            
            frank.SayName();
            frank.MakeNoise();

            Horse fred = new Horse("Pony", "Fred", "small", "Nehhh\n");           
            fred.SayName();
            fred.MakeNoise();

            Horse bandit = new Horse("Gelding", "Bandit", "big", "Neeehhhh\n");           
            bandit.SayName();
            bandit.MakeNoise();

            Horse bullet = new Horse("Arabian", "Bullet", "small", "Neehh\n");           
            bullet.SayName();
            bullet.MakeNoise();
        }



        public Horse(string type, string name, string size, string sound)
        {
            Name = name;
            Sound = sound;
            Size = size;
            Type = type;


        }

        public void MakeNoise()
        {
            Console.WriteLine($"When I speak I go {Sound} and I am {Size}\n");
        }

        public void SayName()
        {
            Console.WriteLine($"My name is {Name} and I am a {Type} horse");
        }
    }
}
