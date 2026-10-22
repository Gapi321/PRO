namespace IfElse
{
    internal class Program
    {
        static void Main()
        {
            bool isNum = true;


            Console.WriteLine("Vnesite stevilko");
            string input = Console.ReadLine();
            isNum = double.TryParse(input, out double parsedNumber);
            if (isNum)
            {
                Console.WriteLine($"Vnesena stevilka je: {parsedNumber}");
                NumCheck(parsedNumber);
            }
            else
            {
                Console.WriteLine("Vnešena vrednost ni število.");
                Main();
            }
        }

        public static double NumCheck(double number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine($"Stevilo {number} je deljivo z 3.");
                
            }
            if (number % 7 == 0)
            {
                Console.WriteLine($"Stevilo {number} je deljivo z 7.");
              
            }
            SodoLiho(number);
            return number;

        }

        private static void SodoLiho(double number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Stevilo {number} je sodo.");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine($"Stevilo {number} je liho.");
            }

        }
    }
}
