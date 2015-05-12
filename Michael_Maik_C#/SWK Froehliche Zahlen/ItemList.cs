using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK_Froehliche_Zahlen
{
    public class ItemList
    {
        private List<Item> _itemList = null;
        private int _startNumber;

        public ItemList(int number)
        {
            this._startNumber = number;
        }

        private void CalculateIterations()
        {
            if (_itemList != null)
                return;
            _itemList = new List<Item>();
            Item item = new Item(_startNumber);
            _itemList.Add(item);

            while (item.Successor != 1 && !NumberExists(item.Successor)) {
                item = new Item(item.Successor);
                _itemList.Add(item);
            }
        }

        private bool NumberExists(int number)
        {
            foreach (Item item in _itemList)
            {
                if (item.Number == number)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetPrint()
        {
            CalculateIterations();
            string printstring = _startNumber.ToString();
            foreach (Item item in _itemList)
            {
                printstring +=  " -> " + item.GetPrint();
            }
            return printstring;
        }
    }
}
