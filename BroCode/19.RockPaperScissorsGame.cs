namespace BroCode
{
    internal class RockPaperScissorsGame
    {
        public RockPaperScissorsGame()
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "P" && player != "R" && player != "S")
                {
                    Console.WriteLine("Rock         R");
                    Console.WriteLine("Paper        P");
                    Console.WriteLine("Scissors     S");
                    Console.Write("Enter: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int randomNum = random.Next(1, 4);

                switch (randomNum)
                {
                    case 1:
                        computer = "R";
                        break;
                    case 2:
                        computer = "S";
                        break;
                    case 3:
                        computer = "P";
                        break;
                }
                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                switch (player)
                {
                    case "R":
                        if (computer == "R")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "P")
                        {
                            Console.WriteLine("You lost");
                        }
                        else
                        {
                            Console.WriteLine("You win");
                        }
                        break;
                    case "S":
                        if (computer == "R")
                        {
                            Console.WriteLine("You lost");
                        }
                        else if (computer == "P")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw");
                        }
                        break;
                    case "P":
                        if (computer == "R")
                        {
                            Console.WriteLine("You win");
                        }
                        else if (computer == "P")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else
                        {
                            Console.WriteLine("You lost");
                        }
                        break;
                }

                Console.WriteLine("Do you want to play again (Y/N)?");
                String answer = Console.ReadLine().ToUpper();

                playAgain = answer == "Y";
            }
        }
    }
}
