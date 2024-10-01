namespace BroCode
{
    class IfStatements {
        public IfStatements()
        {
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
                
            if (name !=  "")
            {
                Console.WriteLine($"Hello {name}");

            }
            else
            {
                Console.WriteLine("You didn\'t enter you name");

            }


            Console.ReadKey();
        }
    }
}
