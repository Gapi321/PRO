using System.Reflection.Metadata;

namespace Methode3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string janez = "Janez";
            string miha = "Miha";
            string joze = "Joze";

            Pozdrav(miha);
            Pozdrav(joze);
            Pozdrav(janez);
        }

        public static void Pozdrav(string name)
        {
            Console.WriteLine($"Pozdravljen, {name}!");
    
        }
    }
}
