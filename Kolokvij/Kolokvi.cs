namespace Kolokvi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1.
            string Word = "hello";
            int Num = 5;
            double DecimalNum = 3.14;
            char Character = 'A';
            // 2.
            bool Is = true;
            string IsString = Is.ToString();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Word, Num, DecimalNum, Character, IsString);
         
            //3.
            int Points;
            Console.WriteLine("enter points:");
            while (!int.TryParse(Console.ReadLine(), out Points))
            {
                Console.WriteLine("Napacen vnos vnesite stevilko");
            }
      
                switch (Points)
                {
                    case > 90 and <= 100:
                        Console.WriteLine("10");
                        break;

                    case >= 80 and <= 89:
                        Console.WriteLine("9");
                        break;

                    case >= 70 and <= 79:
                        Console.WriteLine("8");
                        break;

                    case >= 60 and <= 69:
                        Console.WriteLine("7");
                        break;

                    case >= 50 and <= 59:
                        Console.WriteLine("6");
                        break;

                    case >= 0 and <= 49:
                        Console.WriteLine("5");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            


            //4.
            string Username;
            string Password;
                   string ConfirmPassword = "";
                   string ConfirmUsername = "";
           
            Console.WriteLine("Enter username:");
            Username = Console.ReadLine().ToString();

            Console.WriteLine("Enter password:");
            Password = Console.ReadLine().ToString();

            Console.Clear();



            Console.WriteLine("Confirm username:");
            ConfirmUsername = Console.ReadLine().ToString();
  
            Console.WriteLine("Confirm password:");
            ConfirmPassword = Console.ReadLine().ToString();

            Console.WriteLine("Procesing...");
            Thread.Sleep(1000);

            while (ConfirmUsername != Username || ConfirmPassword != Password)
            {
                Console.Clear();
                Console.WriteLine("Username or password is incorrect. Please try again.");
                Console.WriteLine("Confirm username:");
                ConfirmUsername = Console.ReadLine().ToString();
                Console.WriteLine("Confirm password:");
                ConfirmPassword = Console.ReadLine().ToString();
            }

            Console.WriteLine("LOGIN SUCCESSFUL!"); 
           
            //5.
            string Ime;

            Console.WriteLine("Enter your name:");
            Ime = Console.ReadLine().ToString();

            if (Ime.Length < 6)
            {
                Console.WriteLine($"Ime: {Ime}");   
            }
            else
            {
                Console.WriteLine("Posodobili bomo program da spremlja več črk!");
            }

             */
        }
    }
}
