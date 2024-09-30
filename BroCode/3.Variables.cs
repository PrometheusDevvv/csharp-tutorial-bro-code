namespace BroCode
{
    internal class Variables
    {
        public Variables()
        {
            /* A variable is like a container that holds a value. */

            // Declaration: creating a variable
            int x; // declaring a variable x
            x = 123; // assigning value 123 to x

            // Declaration + Initialization: creating and giving value at the same time
            int y = 321; // y holds the value 321

            // Adding two variables
            int z = x + y; // z holds the result of x + y

            // Different types of variables
            int age = 21; // age holds a whole number
            double height = 300.5; // height holds a decimal number
            bool alive = true; // alive holds true or false
            char symbol = '@'; // symbol holds a single character
            string name = "Bro"; // name holds text

            // Combining two variables
            string username = symbol + name; // username combines symbol and name

            // Output to console
            Console.WriteLine("Your Age Is " + age); // prints age
            Console.WriteLine("Your Height Is " + height + " CM"); // prints height
            Console.WriteLine("Are You Alive? " + alive); // prints if alive
            Console.WriteLine("Your Symbol Is " + symbol); // prints symbol
            Console.WriteLine("Hello " + name); // prints name
            Console.WriteLine("Your Username Is " + username); // prints username
        }
    }
}
