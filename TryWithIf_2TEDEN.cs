using System.Net.Http.Headers;

namespace TryWithIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("What is your age");
            age= int.Parse(Console.ReadLine());

            if (age <= 17)
            {
                Console.WriteLine("You are a child");
            }
            else if(age >= 18 && age <= 40)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a legend");
            }
            Console.ReadLine();
        }
    }
}
