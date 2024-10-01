namespace BroCode
{
    internal class Switches
    {
        public Switches() {
            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
