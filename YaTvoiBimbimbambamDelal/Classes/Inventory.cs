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
        public int Capacity { get; } = 32;
        public Inventory()
        {
            _inventory = new List<Item>();
            
        }

        public void AddItem(Item item)
        {
            if (_inventory.Count < Capacity)
            {
                _inventory.Add(item);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В инвентаре достигнуто максимальное количество предметов");
                Console.ResetColor();
            }
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
            int temp = 1;
            foreach (var item in FW)
            {
                Console.WriteLine(temp++ + "\t" + item.Display());
            }
        }
        public void FiltrA()
        {
            var FA = _inventory.Where(x => x.Type == "броня");
            int temp = 1;
            foreach (var item in FA)
            {
                Console.WriteLine(temp++ + "\t" + item.Display());
            }
        }
        public void FiltrO()
        {
            var FO = _inventory.Where(x => x.Type == "другое");
            int temp = 1;
            foreach (var item in FO)
            {
                Console.WriteLine(temp++ + "\t" + item.Display());
            }
        }
        public void SetWeapon()
        {
            

            int temp = 1;
            Console.WriteLine("\nВыбор оружия:\n");
            var FW = _inventory.Where(x => x.Type == "оружие");
            foreach (var item in FW)
            {
                Console.WriteLine(temp++ + "\t" + item.Display());
            }
            Console.WriteLine("\nВведите номер предмета который хотите экипировать: ");
            int nameW = Int32.Parse(Console.ReadLine());
            if (nameW >= 1 && nameW <= FW.Count())
            {

                //проверка на наличие экипированного оружия
                if (_inventory.Find(x => x.Status == true && x.Type == "оружие") != null)
                {
                    Item findException = _inventory.Find(x => x.Status == true && x.Type == "оружие");
                    findException.Status = false;
                }


                Item findW = FW.ElementAt(nameW - 1);
                if (findW != null) findW.Status = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nПредмета с таким именем нет в инвентаре");
                    Console.ResetColor();
                }
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nПредмета с таким номером нет в списке");
                Console.ResetColor();
            }
        }
        
        public void SetArmor()
        {
            

            int temp = 1;
            Console.WriteLine("\nВыбор брони:\n");
            var FA = _inventory.Where(x => x.Type == "броня");
            foreach (var item in FA)
            {
                Console.WriteLine(temp++ + "\t" + item.Display());
            }
            Console.WriteLine("\nВведите номер предмета который хотите экипировать: ");
            int nameA = Int32.Parse(Console.ReadLine());
            if (nameA >= 1 && nameA <= FA.Count())
            {
                //проверка на наличие экипированной брони
                if (_inventory.Find(x => x.Status == true && x.Type == "броня") != null)
                {
                    Item findException = _inventory.Find(x => x.Status == true && x.Type == "броня");
                    findException.Status = false;
                }


                Item findA = FA.ElementAt(nameA - 1);
                if (findA != null) findA.Status = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nПредмета с таким именем нет в инвентаре");
                    Console.ResetColor();
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nПредмета с таким номером нет в списке");
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
