using System;

namespace BroCode
{
    internal class ArithmeticOperators
    {
        public ArithmeticOperators()
        {
            int friends = 5;
            friends += 3;        // Increment friends by 3
            friends -= 2;        // Decrement friends by 2
            friends *= 2;        // Double the number of friends
            friends /= 2;        // Halve the number of friends

            int remainder = friends % 2; // Calculate remainder when friends is divided by 2

            Console.WriteLine(friends);   // Output the total number of friends
            Console.WriteLine(remainder);   // Output the remainder
            Console.ReadKey();             // Wait for user input before closing
        }
    }
}
