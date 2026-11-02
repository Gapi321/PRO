namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naloga: Naj program izpiše "Pozdravljen, [ime]!"
            string ime = "Miroslav";
            Console.WriteLine("Pozdravljen, " + ime + "!");

            // Naloga: Izračunaj deljenje dveh števil
            int a = 10;
            int b = 0;
            try
            {
                Console.WriteLine("Rezultat je: " + (a / b));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Napaka: Deljenje z ničlo ni dovoljeno.");
            }

            // Naloga: Preveri, ali je številka soda ali liha
            int stevilo = 5;
            if (stevilo % 2 == 0)
            {
                Console.WriteLine("Številka je soda.");
            }
            else
            {
                Console.WriteLine("Številka je liha.");
            }

            // Naloga: Prikaz temperature glede na vhodni podatek
            int temperatura = 20;
            if (temperatura < 15)
            {
                Console.WriteLine("Mrzlo je.");
            }
            else
            {
                Console.WriteLine("Toplo je.");
            }


            // Naloga: Izpiši številke od 1 do 5 vključno z 1 in 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Številka: " + i);


            }

            // Naloga: Pretvori decimalno število v celo število
            double Stevilo = 12.5;
            int CeloStevilo = (int)Stevilo;
            Console.WriteLine("Celo število: " + CeloStevilo);


            Console.WriteLine("Rezultat je: " + Add(5, 10));

            // Naloga: Poišči določeno vrednost v tabeli
            int[] tabela = { 1, 2, 3, 4, 5 };
            int iskanaVrednost = 3;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] == iskanaVrednost)
                {
                    Console.WriteLine("Vrednost najdena!");
                }
            }

            // Naloga: Preveri, ali je vnos uporabnika številka
            Console.WriteLine("Vnesite število:");
            string vnos = Console.ReadLine() ?? " ";
            int STevilo;
      
            if (int.TryParse(vnos, out STevilo))
            {
                Console.WriteLine("Vnesena vrednost je številka.");
            }
            else
            {
                Console.WriteLine("Napaka: Vnesena vrednost ni številka.");
            }


        }

        // Naloga: Kreiraj metodo za seštevanje dveh števil
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
    }
}
