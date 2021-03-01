using System;

namespace C_Sharp_Exercise_6
{
    internal class TwoUp
    {
        public virtual void IntroduceSelf(string rank, string name)
        {
            Console.WriteLine($"Good morning Sir! My name is {rank} {name}.");
        }


        internal virtual void IntroduceParagraph(int x, string paragraph)
        {
            Console.WriteLine($"Sir, I'll be briefing paragraph{x}{paragraph}");
        }

        

    }
}