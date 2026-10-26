namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temparature;
            int temp;
            Console.WriteLine("Wnesite temparatiuro");
            temparature = Console.ReadLine();
            if (int.TryParse(temparature, out temp))
            {
                switch (temp)
                {
                    case <= 15:
                        Console.WriteLine("Mrzlo je");
                        break;
                    case >= 16 when temp <= 28:
                        Console.WriteLine("Temparatura je vredu");
                        break;
                    case > 28:
                        Console.WriteLine("Vroce je");
                        break;
                    default:
                        Console.WriteLine("Napaka pri vnosu");
                        break;
                }
            }
            else
            {
                Console.WriteLine("not number");
            }

            Console.ReadLine(); 
        }
    }
}
