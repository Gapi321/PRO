namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vnesite string in pritisnite enter:");
            string preberiVnos = Console.ReadLine();
            Console.WriteLine($"Vnesli ste {preberiVnos}");

            Console.WriteLine("vnesite karakter in pritisnite enter:");
            int asciVrednost = Console.ReadLine();
            Console.WriteLine($"ASCii vrednost je  {asciVrednost}");
            Console.ReadKey();
        }
    }
}
