using System.Globalization;

namespace VremenskaPostaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days;
            double temperature;
            string weather = "";

            Console.WriteLine("Za koliko dni zelite spremljati vreme?");
            while (!int.TryParse(Console.ReadLine(), out days) || days <= 0)
            {
                Console.WriteLine("Napacen vnos! Vnesite pozitivno celo stevilo:");
            }

            Console.WriteLine($"Spremljanje vreme za {days} dni.");
            double[] temps = new double[days + 1];
            string[] Kind = new string[days + 1];

            for (int i = 1; i <= days; i++)
            {
                Console.WriteLine($"DAN: {i}");

                Console.WriteLine("vnesite danasnjo temparaturo");
                while(!double.TryParse(Console.ReadLine()?.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out temperature))
                {
                    Console.WriteLine("Napacen vnos! Vnesite veljavno temperaturo:");
                }   
                temps[i] = temperature;
                Console.WriteLine($"Danasnja temperatura: {temperature}");



                Console.WriteLine("Kaksno je vreme danes?");
                weather = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(weather) || double.TryParse(weather, out _))
                {
                    Console.WriteLine("Napacen vnos! Vnesite besedo:");
                    weather = Console.ReadLine();
                }
                Kind[i] = weather;
            }


            Console.WriteLine("Za ispis podatkov pritisnite 1");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 1; i <= days; i++)
                {
                    Console.WriteLine($"DAN: {i}");
                    Console.WriteLine($"Temperatura: {temps[i]}");
                    Console.WriteLine($"Vreme: {Kind[i]}");
                }
                double averageTemperature = POP(temps, days);
                Console.WriteLine($"Povprečna temperatura: {averageTemperature}");
            }
            Console.WriteLine("nov dan pritisnite 2");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 2)
            {
                Console.Clear();
                Thread.Sleep(2000);
                Main(args);
               


            }
        }

        private static double POP(double[] temps, int days)
        {
           double Ptemp = temps.Sum();
            double averageTemp = Ptemp / days;
            return averageTemp;
        }

    }
}
