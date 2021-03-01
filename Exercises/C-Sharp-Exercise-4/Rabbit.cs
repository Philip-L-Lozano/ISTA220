using System;

namespace C_Sharp_Exercise_4
{
    internal class Rabbit
    {
        public string Name;
        public string Sound;
        public string Size;
        public string Type;

        public Rabbit()
        {            
            Rabbit bugs = new Rabbit("Great Plains", "Bugs", "big", "HI\n");            
            bugs.SayName();
            bugs.MakeNoise();

            Rabbit babs = new Rabbit("Forest", "Babs", "small", "Hey\n");           
            babs.SayName();
            babs.MakeNoise();

            Rabbit bomber = new Rabbit("Jungle", "Bomber", "big", "Hello\n");           
            bomber.SayName();
            bomber.MakeNoise();

            Rabbit baller = new Rabbit("Desert", "Baller", "small", "Nice to meet ya\n");           
            baller.SayName();
            baller.MakeNoise();
        }



        public Rabbit(string type, string name, string size, string sound)
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
            Console.WriteLine($"My name is {Name} and I am a {Type} rabbit");
        }
    }
}
