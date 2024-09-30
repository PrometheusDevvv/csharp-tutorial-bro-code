using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCode
{
    internal class Constants
    {
       public Constants()
        {
            // A constant is a variable with a fixed value that cannot be changed.
            // Declared with the 'const' keyword, 'pi' represents the mathematical constant.
            const double pi = 3.141459;
            Console.WriteLine(pi);


            // Waiting for user input to prevent the console from closing immediately.
            Console.ReadKey();
        }
    }
}
