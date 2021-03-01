using System;

namespace C_Sharp_Exercise_6
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                IssueTheOrder();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }

        static void IssueTheOrder()
        {
            Personnel pl = new Personnel();
            Personnel psg = new Personnel();            
            Personnel rto = new Personnel();

            Console.WriteLine("Good morning Sir! My name is LT New Guy. I will be delivering today's mission brief!");
            Console.WriteLine("First, I'd like the team to introduce themselves.");
            psg.IntroduceSelf("SFC", "Lee");
            rto.IntroduceSelf("PV2", "Smith");
            pl.Paragraph1();
            pl.Paragraph2();
            pl.Paragraph3();
            psg.Paragraph4();          
            rto.Paragraph5();



           

            
            
            


        }

    }
}
