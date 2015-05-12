using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK_Froehliche_Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            var input = Console.ReadLine();
            while (!Int32.TryParse(input, out i))
            {
                input = Console.ReadLine();
            }

            Console.WriteLine(new ItemList(i).GetPrint());
            Console.ReadLine();
        }
    }
}
