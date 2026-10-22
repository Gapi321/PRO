using System;
using System.ComponentModel;

namespace HelloWorld
{
    internal class Hello
    {
        string passwor;
        public void Main(string[] args)
        {
            string name;
            int age;
            bool minor = true;
            bool pass = true;
            
            string p;


            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name");

            name = Console.ReadLine();

            Console.WriteLine("Hello" + " " + name);
            Console.WriteLine("What is your age?");
            if (int.TryParse(Console.ReadLine(),out age))
            {
                if (age >= 18)
                {
                   minor = false;
                }
            }
            else
            {
                Console.WriteLine("Not a walid number");
            }

            if (!minor)
            {
                Console.WriteLine($"You are {age} and you are old enough");
            }
            else
            {
                Console.WriteLine($"You are {age} and you are not old enough");
            }


            while (minor)
            {
                Console.WriteLine("Tkank you for using our services");
            }

            while (!minor)
            {
             string input = Password();
                Console.WriteLine(input);
            }


        }
        public string Password()
        {
            passwor = Console.ReadLine() ?? "";
            return passwor;
        }

    }
}
