namespace BUSCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limit = 40;
            int People = 0;
            char Key;
            Console.WriteLine("welcoe to bus");
            while (People <= Limit)
            {
                Key = Console.ReadKey(true).KeyChar;
                switch (Key)
                {
                    case '+':
                        if (People >= Limit)
                        {
                            Console.WriteLine("buss is full");
                        }
                        else if (People == 0 || People <= Limit)
                        {
                            People++;
                            Console.WriteLine($"People in bus: {People}");

                        }
                        break;

                    case '-':
                        if (People <= 0)
                        {
                            Console.WriteLine("buss is empty");
                        }
                        else if (People >= 0)
                        {
                            People--;
                            Console.WriteLine($"People in bus: {People}");
                        }
                        break;
                }

            }




        }
    }
}
