using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyNumbers.Logic
{
    public class HappyNumber
    {
        public static IAusgabe Ausgabe { get; set; }

        public static bool IsHappyNumber(int zahl)
        {
            var ziffern = ZerlegeZahlInZiffern(zahl);
            ziffern = QuadriereZiffern(ziffern);
            var summe = SummiereZiffern(ziffern);

            switch (summe)
            {
                case 1:
                    return true;
                case 4:
                    return false;
            }

            if (Ausgabe != null)
            {
                Ausgabe.DruckeZwischenergebnis(summe);
            }

            return IsHappyNumber(summe);
        }

        public static IEnumerable<int> ZerlegeZahlInZiffern(int zahl)
        {
            var zahlAlsString = zahl.ToString();
            return zahlAlsString.Select(zeichen => Int32.Parse(zeichen.ToString())).ToList();
        }

        public static IEnumerable<int> QuadriereZiffern(IEnumerable<int> ziffern)
        {
            return ziffern.Select(ziffer => ziffer * ziffer).ToList();
        }

        private static int SummiereZiffern(IEnumerable<int> ziffern)
        {
            return ziffern.Sum();
        }
    }
}
