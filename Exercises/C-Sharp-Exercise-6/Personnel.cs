using System;

namespace C_Sharp_Exercise_6
{

    internal class Personnel : TwoUp
    {

        public override void IntroduceSelf(string rank, string name)
        {
            Console.WriteLine($"Good morning Sir! My name is {rank} {name}.");
        }
        internal override void IntroduceParagraph(int x, string paragraph)
        {
            Console.WriteLine($"Sir, I'll be briefing paragraph{x}{paragraph}");
        }
        internal void Paragraph1()
        {
            Console.WriteLine("Situation");
        }
        internal void Paragraph2()
        {
            Console.WriteLine("Mission");
        }
        internal void Paragraph3()
        {
            Console.WriteLine("Execution");
        }
        internal void Paragraph4()
        {
            Console.WriteLine("Sustainment");
        }
        internal void Medical()
        {
            Console.WriteLine("Medical");
        }
        internal void Paragraph5()
        {
            Console.WriteLine("Command and Control");
        }

    }
}