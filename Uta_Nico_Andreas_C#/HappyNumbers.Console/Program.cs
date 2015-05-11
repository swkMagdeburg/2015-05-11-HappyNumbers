using HappyNumbers.Logic;

namespace HappyNumbers.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bitte Zahl eingeben:");
            var zahlString = System.Console.ReadLine();
            var zahl = int.Parse(zahlString);

            HappyNumber.Ausgabe = new Ausgabe();
            var happyNumber = HappyNumber.IsHappyNumber(zahl);

            if (happyNumber)
            {
                System.Console.WriteLine("Die Zahl ist eine super fröhliche Nummer :)");
            }
            else
            {
                System.Console.WriteLine("Die Zahl ist ein Marvin :(");
            }

            System.Console.ReadKey();
        }
    }
}
