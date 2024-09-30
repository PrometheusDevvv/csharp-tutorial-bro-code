namespace BroCode
{
    internal class RandomNumbers
    {
        public RandomNumbers()
        {
            /*
             * Topic: Random
             * By default, random.Next() generates a random integer in the range [0, int.MaxValue).
             * random.Next(minValue, maxValue) generates a random integer in the range [minValue, maxValue).
             * random.NextDouble() generates a random double in the range [0.0, 1.0).
            */
            Random random = new Random();
            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            Console.WriteLine(num1); 
            Console.WriteLine(num2);
            Console.WriteLine(num3);


            double num = random.NextDouble();
            Console.WriteLine(num);


            Console.ReadKey();
        }
    }
}
