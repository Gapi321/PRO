namespace UserLogin
{
    internal class Program
    {

        public static void Main()
        {

            string username = "";
            string password = "";
            int length;
            bool testUser = true;
            bool testPass = true;
            Console.WriteLine("Welcome to the User Login application!");
            while (testUser)
            {
                Console.WriteLine("Create username:\n Username must be 8 characters or more.");

                username = Console.ReadLine() ?? "";
                length = username.Length;

                if (length >= 8)
                {
                    Console.WriteLine("Username created successfully!");
                    testUser = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Username is too short. Please try again.");
                    testUser = true;
                }
            }

            while (testPass)
            {
                Console.WriteLine("Create password:\nPassword must be 8 characters or more and contain an uppercase letter.");
                password = Console.ReadLine() ?? "";

                bool longEnough = password.Length >= 8;
                bool hasUpper = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        hasUpper = true;
                        break;
                    }
                }

                if (longEnough && hasUpper)
                {
                    Console.WriteLine("Password created successfully!");
                    testPass = false;
                    Login(username, password);
                }
                else
                {
                    if (!longEnough)
                        Console.WriteLine("Password must be at least 8 characters long.");
                    if (!hasUpper)
                        Console.WriteLine("Password must contain at least one uppercase letter.");
                    Console.WriteLine("Please try again.\n");
                }
            }

        }

        public static void Login(string Username, string Password)
        {
            Console.Clear();
            Console.WriteLine("enter username:");
           string Username1 = Console.ReadLine() ?? "";
            Console.WriteLine("enter password:");
           string Password1 = Console.ReadLine() ?? "";
            if (Username == Username1 && Password == Password1)
            {
                Console.WriteLine("Login successful!");
                Sucess();
            }
            else
            {
                Console.WriteLine("Login failed. Please try again.");
                Thread.Sleep(2000);
                Login(Username, Password);
            }

        }

        private static void Sucess()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the localhost:3000!");
            Console.WriteLine(@"
                         \O/
                          |
                         / \      
                           ");
            Console.ReadLine();
        }
    }
}
