using System;

namespace C_Sharp_Exercise_4
{
    public class Cow
    {
        public string Name;
        public string Sound;
        public string Size;
        public string Type;

        public Cow()
        {
            Console.WriteLine("Meet the whole family\n");

            Cow betty = new Cow("Spotted", "Betty", "big", "Moo\n");            
            betty.SayName();
            betty.MakeNoise();

            Cow daisy = new Cow("Dimpled", "Daisy", "small", "Moooooo\n");
            daisy.SayName();
            daisy.MakeNoise();

            Cow sally = new Cow("Belted", "Sally", "big", "Moooo\n");           
            sally.SayName();
            sally.MakeNoise();

            Cow molly = new Cow("Normal", "Molly", "small", "Mooooo\n");           
            molly.SayName();
            molly.MakeNoise();

        }

       

        public Cow(string type, string name, string size, string sound)
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
            Console.WriteLine($"My name is {Name} and I am a {Type} cow");
        }
    }
}