namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TopPlayer = "Pro Player";
            int TopScore = 10;
            string username = "Player1";
            int score = 0;
            int guess = 0;
            int secret = 0;
            bool corectGuess = true;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the guessing game!" +
                "\nEnter your username:");

            username = Console.ReadLine();
            
            Console.WriteLine("I'm thinking of a number between 1 and 10." +
               "\nCan you try to guess what it is?");

            GuessingGame(secret, score, TopScore, TopPlayer, username, corectGuess, guess);
        }


        private static void GuessingGame(int secret, int score, int TopScore, string TopPlayer, string username, bool corectGuess, int guess)
        { 
          
                secret = new Random().Next(1, 11);
            
            while (corectGuess)
            {
                Console.ForegroundColor = ConsoleColor.White;
             
                Console.Write("Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a number.");
                    continue;
                }

                if (guess == secret)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    score++;
                    Score(TopScore, score, TopPlayer, username);
                    GuessingGame(secret, score, TopScore, TopPlayer, username, corectGuess, guess);


                }
                else
                {
                    if (guess < secret)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    corectGuess = true;
                }
            }
        }

        private static void Score(int TopScore, int score, string topPlayer,string username)
        {
            if (score > TopScore)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"New high score! Congratulations {username}!" +
                    $"\n New top score: {score}" +
                    $"\n Old top score {TopScore}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{topPlayer}'S Score:{TopScore}" +
                    $"\n{username}'S Score: {score}");
            }
        }
    }
}
