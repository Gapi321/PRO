using System.Diagnostics.CodeAnalysis;

namespace Methodes
{
    internal class Program
    {
        int numA;
        int numB;
        int result;
        char operation;
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Dobrodosli v kalkulator vpisite prvo stevilko");
                int numA = double.TryParse(Console.ReadLine(), out double parsedNumA) ? (int)parsedNumA : 0;
                Console.WriteLine("katero operacijo zelite opraviti");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine("\nVpisite drugo stevilko");
                int numB = double.TryParse(Console.ReadLine(), out double parsedNumB) ? (int)parsedNumB : 0;

                switch (operation)
                {
                    case '+':
                        Console.WriteLine(Sestevanje(numA, numB));
                        break;
                    case '-':
                        Console.WriteLine(Odstevanje(numA, numB));
                        break;
                    case '*':
                        Console.WriteLine(Mnozenje(numA, numB));
                        break;
                    case '/':
                        Console.WriteLine(Deljenje(numA, numB));
                        break;
                    default:
                        Console.WriteLine("Neveljavna operacija");
                        break;
                }
            }
            
        }

        public static double Sestevanje(int a, int b)
        {

            double result = a + b;
            return result;
        }

        public static double Odstevanje(int a, int b)
        {
            double result = a - b;
            return result;
        }

        public static double Deljenje(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Napaka: Deljenje z 0 ni dovoljeno.");
                return double.NaN; // Return NaN to indicate an error
            }
           
            double result = a / b;
            return result;
        
        }

        public static double Mnozenje(int a, int b)
        {
            double result = a * b;
            return result;
        }
        
    }
}
