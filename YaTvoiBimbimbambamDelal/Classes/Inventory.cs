using System;
using System.Collections.Generic;
using System.Text;

namespace YaTvoiBimbimbambamDelal.Classes
{
    class Inventory
    {
        private List<Item> _inventory;

        public Inventory()
        {
            _inventory = new List<Item>(32);
        }

        public void AddItem(Item item)
        {
            _inventory.Add(item);
        }

        public void DisplayAll()
        {
            int id = 1;
            foreach (var item in _inventory)
            {
                Console.WriteLine(id++ + "\t" + item.Display());
            }
        }

        public void SortName()
        {
            _inventory.Sort(delegate (Item x, Item y)
            {
                return x.Name.CompareTo(y.Name);
            });
        }
        public void SortWeight()
        {
            _inventory.Sort(delegate (Item x, Item y)
            {
                return x.Weight.CompareTo(y.Weight);
            });
        }
        public void SortCost()
        {
            _inventory.Sort(delegate (Item x, Item y)
            {
                return x.Cost.CompareTo(y.Cost);
            });
        }
        public void FindName(string Char)
        {
            Item find = _inventory.Find(x => x.Name.Contains(Char));
            find.Display();
        }

    }
}
