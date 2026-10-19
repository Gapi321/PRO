using System.Runtime.CompilerServices;

namespace TryParse
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            string stringForFloat = "0,85";
            string stringForInt = "12345"; 

            float Float =float.Parse(stringForFloat);
            int Int = Int.Parse(stringForInt);

   
            float resoult = Float + Int;
            Console.WriteLine(resoult);
            Console.WriteLine(Float);
            Console.WriteLine(Int);
         


        }
    }
}
