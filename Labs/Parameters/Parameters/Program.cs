#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int Phil = 0;
            Console.WriteLine(Phil);
            Pass.Value(Phil);
            Console.WriteLine(Phil);
            Phil = Pass.SetPhil();
            Console.WriteLine(Phil);
            Console.ReadKey();

            Console.WriteLine("-------");

            int i = 0;
            Console.WriteLine($"i is {i}");
            Pass.Value2(ref i);
            Console.WriteLine(i);
           
            Console.ReadKey();


            Console.WriteLine("-------");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.WriteLine(wi.message);
            Pass.Reference2(wi);
            Console.WriteLine(wi.message);

            Console.WriteLine(wi.booleanvalue);
            Pass.Reference3(wi);
            Console.WriteLine(wi.booleanvalue);
            Console.ReadKey();


            Duck daffy = new Duck();
            Console.WriteLine($"daffy's name is [{daffy.Name}]");
            daffy.Name = "Daffy";
            Console.WriteLine($"daffy's name is now [{daffy.Name}]");

            daffy.SetName("daffidil");
            Console.WriteLine($"Daffy's name is now {daffy.Name}");

            Duck huey = new Duck();
            huey.SetName("Huey");
            Console.WriteLine(huey.Name);

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
