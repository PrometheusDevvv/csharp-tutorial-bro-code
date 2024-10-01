using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCode
{
    internal class StringMethods
    {
        public StringMethods()
        {
            String fullName = "Bro Code";
            String phoneNumber = "123-456-789";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //phoneNumber = phoneNumber.Replace("-", "");

            //String userName = fullName.Insert(0,"@");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(4, 4);
            Console.WriteLine($"{firstName} X {lastName}");

            Console.ReadKey();
        }
    }
}
