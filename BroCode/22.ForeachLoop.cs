namespace BroCode
{
    internal class ForeachLoop
    {
        public ForeachLoop()
        {
            String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach(String car in cars)
            {
                Console.WriteLine(      );
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
