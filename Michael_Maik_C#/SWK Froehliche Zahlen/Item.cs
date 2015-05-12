using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK_Froehliche_Zahlen
{
    public class Item
    {
        private string printString = "";
        public int Number { get; private set; }
        public int Successor { get { return CalcSuccessor(); } }


        public Item(int number)
        {
            this.Number = number;
        }

        private int? _successor = null;
        private int CalcSuccessor()
        {
            if (_successor.HasValue)
                return _successor.Value;

            int sum = 0;

            var numberAsString = Number.ToString();
            foreach(var c in numberAsString)
            {
                int digit = Int32.Parse(c.ToString());
                sum += digit * digit;
                if (!String.IsNullOrEmpty(printString))
                {
                    printString += " + ";
                }
                printString += digit.ToString() + "^2";
            }
            printString += " = " + sum.ToString();

            _successor = sum;
            return sum;
        }

        public string GetPrint()
        {
            CalcSuccessor();
            return printString;
        }
    }
}
