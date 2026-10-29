using System.ComponentModel;

namespace teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ocena;
            int Ocene = 0;
            int steviloOcen = 0;
            Console.WriteLine("enter marks (5-10) or -1 to calculate average:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Ocena))
                {
                    if (Ocena >= 5 && Ocena <= 10)
                    {
                        Console.WriteLine($"entered number is {Ocena}");
                        Ocene += Ocena;
                        steviloOcen++;
                       
                    }
                    else if (Ocena == -1)
                    {
                        Sestevek(Ocene, steviloOcen);
       
                    }
                    else
                    {
                        Console.WriteLine("not a valid mark");
                 
                    }
                }
                else
                {
                    Console.WriteLine("enter a number");
                
                }
                
            }
            Console.ReadLine();
        }

        private static void Sestevek(int Ocene, int steviloOcen)
        {
            double povprecje = (double)Ocene / steviloOcen;
            Console.WriteLine($"average mark is {povprecje}");
            Console.WriteLine("Again? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                Main(null);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
