namespace Konvertuirajte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numA = 11.2f;
            string numB;

            bool myBool = true;
            string MyBool;

            numB = numA.ToString();
            Console.WriteLine($"{numB}");

            MyBool = myBool.ToString();
            Console.WriteLine($"{MyBool}");

        }
    }
}
