using System;

namespace BroCode
{
    internal class UserInput
    {
        public UserInput()
        {
            // This program demonstrates how to receive input from the user.
            // Console.ReadLine returns user input as a string.

            Console.Write("What's Your Name: ");
            string name = Console.ReadLine();

            Console.Write("What's Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, you are {age} years old!");

            Console.ReadKey(true);
        }
    }
}
