
namespace BroCode
{
    internal class WhileLoops
    {
        public WhileLoops()
        {
            String name = "";
            while (name == "") {
                Console.Write("Enter Your Name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {name}");
        }
    }
}
