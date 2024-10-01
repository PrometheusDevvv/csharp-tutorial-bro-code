
namespace BroCode
{
    internal class LogicalOperators
    {
        public LogicalOperators() {
            Console.Write("What\'s the temperature outside (c) ?: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25) {
                Console.WriteLine("It's warm outside!");
            }else if  (temp <= -50 || temp >= 50){
                Console.WriteLine("DON\'t GO OUTSIDE!");
            }

        }
    }
}
