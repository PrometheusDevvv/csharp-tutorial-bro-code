namespace BroCode
{
    internal class NumberGuessingGame
    {
        public NumberGuessingGame()
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int guess;
            int number;
            int guesses;
            String response = "";

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.WriteLine($"Guess a number between {min} and {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    // Move this line inside the loop to count correctly

                    if (guess > number)
                    {
                        Console.WriteLine("Guess is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Guess is too low");
                    }
                    guesses++;
                }
                Console.WriteLine($"Number {number}");
                Console.WriteLine($"You WIN !");
                Console.WriteLine($"Guesses {guesses}");

                Console.WriteLine($"Would you like to play agaun (Y/N)? :");
                response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                Console.WriteLine("Thanks for playing!");
                Console.ReadKey(); // Keeps the console open
            }
        }
    }
}
