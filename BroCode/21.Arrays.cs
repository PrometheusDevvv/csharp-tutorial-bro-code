namespace BroCode
{
    internal class Arrays
    {
        public Arrays()
        {
            String[] cars = new String[4];
            //String[] cars = { "BMW", "Mustang", "Corvette"};

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

        }
    }
}
