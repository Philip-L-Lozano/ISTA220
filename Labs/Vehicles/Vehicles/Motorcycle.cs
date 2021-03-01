using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Motorcycle : Vehicle
    {
        internal void Accelerate()
        {
            Console.WriteLine("Motorcycle going faster");
        }

        internal void Brake()
        {
            Console.WriteLine("Motorcycle going slower");
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycling");
        }

    }
}
