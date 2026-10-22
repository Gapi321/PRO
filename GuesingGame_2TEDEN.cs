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
            int choise = ' ';

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the guessing game!" +
                "\nEnter your username:");

            username = Console.ReadLine();

            Console.WriteLine("Choose a difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Easy mode selected.");
                    Console.WriteLine("I'm thinking of a number between 1 and 10." +
                                      "\nCan you try to guess what it is?");
                    break;
                case 2:
                    Console.WriteLine("Medium mode selected.");
                    Console.WriteLine("I'm thinking of a number between 1 and 20." +
                                      "\nCan you try to guess what it is?");
                    break;
                case 3:
                    Console.WriteLine("Hard mode selected.");
                    Console.WriteLine("I'm thinking of a number between 1 and 30." +
                                      "\nCan you try to guess what it is?");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Easy mode.");
                    Console.WriteLine("I'm thinking of a number between 1 and 10." +
                                      "\nCan you try to guess what it is?");
                    break;
            }

            GuessingGame(secret, score, TopScore, TopPlayer, username, corectGuess, guess, choise);
        }

        private static void GuessingGame(int secret, int score, int TopScore, string TopPlayer, string username, bool corectGuess, int guess, int choise)
        {
            switch (choise)
            {
                case 1:
                    secret = new Random().Next(1, 11);
                    break;
                case 2:
                    secret = new Random().Next(1, 21);
                    break;
                case 3:
                    secret = new Random().Next(1, 31);
                    break;
                default:
                    secret = new Random().Next(1, 11);
                    break;
            }
 
            
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
                    GuessingGame(secret, score, TopScore, TopPlayer, username, corectGuess, guess, choise);


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
            string playAgain;
            if (score > TopScore)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"New high score! Congratulations {username}!" +
                    $"\n New top score: {score}" +
                    $"\n Old top score {TopScore}");
                Console.WriteLine("do you want to play again? (y/n)");
                playAgain = Console.ReadLine();
                if(playAgain.ToLower() == "y")
                {
                    Console.WriteLine("Starting a new game...");
                    Thread.Sleep(2000); 
                    Console.Clear();
                    Main(null);
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
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
