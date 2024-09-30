namespace BroCode
{
    internal class Variables
    {
        public Variables()
        {
            /* A variable is like a container that holds a value. */

            // Declaration of an integer variable 'x' without assigning a value.
            int x;
            // Assigning the value 123 to the variable 'x'.
            x = 123;

            // Declaration and initialization of the variable 'y' in one step.
            int y = 321;

            // Adding the values of 'x' and 'y' and storing the result in 'z'.
            int z = x + y;

            // Declaring different types of variables:
            int age = 21;           // Integer: a whole number to store age.
            double height = 300.5;  // Double: to store height as a decimal number.
            bool alive = true;      // Boolean: stores true or false values.
            char symbol = '@';      // Char: stores a single character.
            string name = "Bro";    // String: stores text.

            // Concatenating the character symbol and the name into a new string variable.
            string username = symbol + name;

            // Printing each variable's value to the console.
            Console.WriteLine("Your Age Is " + age);              // Outputs the age value.
            Console.WriteLine("Your Height Is " + height + " CM"); // Outputs the height value with "CM" appended.
            Console.WriteLine("Are You Alive? " + alive);          // Outputs the boolean value (true/false).
            Console.WriteLine("Your Symbol Is " + symbol);         // Outputs the symbol character.
            Console.WriteLine("Hello " + name);                    // Outputs the name.
            Console.WriteLine("Your Username Is " + username);     // Outputs the combined username.
        }
    }
}
    