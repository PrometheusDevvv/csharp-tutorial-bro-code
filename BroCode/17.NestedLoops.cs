
namespace BroCode
{
    internal class NestedLoops
    {
        public NestedLoops() {
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How Many COlumns?: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("What Sybmol?: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(symbol+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
