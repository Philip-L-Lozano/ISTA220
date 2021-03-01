using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(null));
            //Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(21));
            Console.WriteLine(Util.Sum(13,31));
            Console.WriteLine(Util.Sum(7,45,67));
            Console.WriteLine(Util.Sum(44,24,64,76));
            Console.WriteLine(Util.Sum(56,37,42,88,63));
            Console.WriteLine(Util.Sum(91,14,53,65,87,48));
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
