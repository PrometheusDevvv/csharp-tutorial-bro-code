namespace BroCode
{
    internal class CalculatorProgram
    {
        public CalculatorProgram()
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("-----------------------");
                Console.WriteLine("Calculator Program:");
                Console.WriteLine("-----------------------");

                Console.WriteLine("Enter number 1:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter numer 2 :");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("Enter Option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That was not valid option"); break;
                }
                Console.WriteLine("Would you like to continue? (Y/N): ");


            } while ( Console.ReadLine().ToUpper() == "Y" );

            Console.WriteLine("Bye!");
         }
    }
}
