using HappyNumbers.Logic;

namespace HappyNumbers.Console
{
    class Ausgabe : IAusgabe
    {
        public void DruckeZwischenergebnis(int ziffer)
        {
            System.Console.WriteLine("Zwischenergebnis: " + ziffer);
        }
    }
}