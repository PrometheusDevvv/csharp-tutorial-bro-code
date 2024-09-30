using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCode
{
    internal class HypotenuseCalculatorProgram
    {
        public HypotenuseCalculatorProgram() {

            Console.Write("Enter Side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a*a) + (b*b));

            Console.WriteLine("The Hypotenuse Is " + c);

            Console.ReadKey();
        }
    }
}
