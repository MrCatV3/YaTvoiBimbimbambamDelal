using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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
            if (find != null) Console.WriteLine(find.Display());
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nПредмета с таким именем нет в инвентаре");
                Console.ResetColor();
            }

        }
        public void FiltrW()
        {
            var FW = _inventory.Where(x => x.Type == "оружие");
            
            foreach (var item in FW)
            {
                Console.WriteLine(item.Display());
            }
        }
        public void FiltrA()
        {
            var FA = _inventory.Where(x => x.Type == "броня");

            foreach (var item in FA)
            {
                Console.WriteLine(item.Display());
            }
        }
        public void FiltrO()
        {
            var FO = _inventory.Where(x => x.Type == "другое");

            foreach (var item in FO)
            {
                Console.WriteLine(item.Display());
            }
        }
        public void SetWeapon()
        {
            if (_inventory.Find(x => x.Status == true && x.Type == "оружие") != null)
            {
                Item findException = _inventory.Find(x => x.Status == true && x.Type == "оружие");
                findException.Status = false;
            }
            Console.WriteLine("\nВыбор оружия:\n");
            var FW = _inventory.Where(x => x.Type == "оружие");
            foreach (var item in FW)
            {
                Console.WriteLine(item.Display());
            }
            Console.WriteLine("\nВведите имя предмета который хотите экипировать: ");
            string nameW = Console.ReadLine();
            Item findW = _inventory.Find(x => x.Name.Contains(nameW));
            if (findW != null) findW.Status = true;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nПредмета с таким именем нет в инвентаре");
                Console.ResetColor();
            }

        }
        
        public void SetArmor()
        {
            if (_inventory.Find(x => x.Status == true && x.Type == "броня") != null)
            {
                Item findException = _inventory.Find(x => x.Status == true && x.Type == "броня");
                findException.Status = false;
            }
            Console.WriteLine("\nВыбор брони:\n");
            var FA = _inventory.Where(x => x.Type == "броня");
            foreach (var item in FA)
            {
                Console.WriteLine(item.Display());
            }
            Console.WriteLine("\nВведите имя предмета который хотите экипировать: ");
            string nameA = Console.ReadLine();
            Item findA = _inventory.Find(x => x.Name.Contains(nameA));
            if (findA != null) findA.Status = true;

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nПредмета с таким именем нет в инвентаре");
                Console.ResetColor();
            }
            
        }
        public void DisplayEquip()
        {
            var DE = _inventory.Where(x => x.Status == true);
            Console.WriteLine("\nЭкипированные предметы: ");
            foreach (var item in DE)
            {
                Console.WriteLine(item.Display());
            }
        }
    }
}
