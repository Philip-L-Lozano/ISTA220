using System;

namespace C_Sharp_Exercise_4
{
    internal class Pig
    {
        public string Name;
        public string Sound;
        public string Size;
        public string Type;

        public Pig()
        {
            
            Pig porker = new Pig("northern", "Porker", "big", "oink\n");           
            porker.SayName();
            porker.MakeNoise();

            Pig orker = new Pig("southern", "Orker", "small", "oooiiink\n");           
            orker.SayName();
            orker.MakeNoise();

            Pig yorker = new Pig("eastern", "Yorker", "big", "ooiink\n");            
            yorker.SayName();
            yorker.MakeNoise();

            Pig dorker = new Pig("western", "Dorker", "small", "oink oink\n");           
            dorker.SayName();
            dorker.MakeNoise();

        }



        public Pig(string type, string name, string size, string sound)
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
            Console.WriteLine($"My name is {Name} and I am a {Type} pig");
        }
    }
}
