using System;
using YaTvoiBimbimbambamDelal.Classes;

namespace YaTvoiBimbimbambamDelal
{
    class Program
    {
        static Inventory _inventory = new Inventory();
        static void Main(string[] args)
        {



            _inventory.AddItem(new Item("Манга", 0.15, 500, "другое"));
            _inventory.AddItem(new Item("Картошка", 1, 1200, "другое"));
            _inventory.AddItem(new Item("Картошка", 1, 1300, "другое"));
            _inventory.AddItem(new Item("Aboba2", 0.15, 1500, "другое"));
            _inventory.AddItem(new Item("Манга3", 0.15, 1060, "другое"));
            _inventory.AddItem(new Item("Антошка", 0.15, 1800, "другое"));
            _inventory.AddItem(new Item("Манга4", 0.15, 1090, "другое"));
            _inventory.AddItem(new Item("Aboba4", 2, 10760, "другое"));
            _inventory.AddItem(new Item("Манга5", 0.15, 1020, "другое"));
            _inventory.AddItem(new Item("Aboba5", 153, 1040, "другое"));
            _inventory.AddItem(new Item("Бартошка", 0.15, 1500, "другое"));
            _inventory.AddItem(new Item("Aboba6", 333, 1010, "другое"));
            _inventory.AddItem(new Item("Манга7", 125, 1020, "другое"));
            _inventory.AddItem(new Item("Амежка", 72.4, 1030, "другое"));
            _inventory.AddItem(new Item("Манга8", 72.4, 1500, "другое"));
            _inventory.AddItem(new Item("Aboba8", 72.4, 1060, "другое"));
            _inventory.AddItem(new Item("АбобкаКС31", 0.15, 1700, "другое"));
            _inventory.AddItem(new Item("Aboba9", 0.15, 1080, "другое"));
            _inventory.AddItem(new Item("Манга10", 72.4, 10760, "другое"));
            _inventory.AddItem(new Item("Трататататтата", 0.15, 1100, "другое"));
            _inventory.AddItem(new Item("Aboba11", 72.4, 1040, "другое"));
            _inventory.AddItem(new Item("Чтобневтыкал", 0.15, 1700, "другое"));
            _inventory.AddItem(new Item("Aboba12", 0.15, 1006, "другое"));
            _inventory.AddItem(new Item("Манга12", 0.15, 1005, "другое"));
            _inventory.AddItem(new Item("Aboba13", 0.15, 1500, "другое"));
            _inventory.AddItem(new Item("Манга13", 0.15, 100, "другое"));
            _inventory.AddItem(new Item("Aboba14", 0.15, 1400, "другое"));
            _inventory.AddItem(new Item("Aboba14", 0.15, 1700, "другое"));
            _inventory.AddItem(new Item("Aboba15", 0.15, 1060, "другое"));
            _inventory.AddItem(new Item("Aboba15", 0.15, 1050, "другое"));
            _inventory.AddItem(new Armor(30,"Aboba16", 30, 1100, "броня"));
            _inventory.AddItem(new Weapon(15,"Aboba16", 6, 1010, "оружие"));


            _inventory.DisplayAll();
            //Console.WriteLine("Do-----------------------------------------");
            //_inventory.DisplayAll();
            //_inventory.SortName();
            //Console.WriteLine("Imeny------------------------------------------");
            //_inventory.DisplayAll();

            //_inventory.SortWeight();
            //Console.WriteLine("Wes--------------------------------------");
            //_inventory.DisplayAll();

            //_inventory.SortCost();
            //Console.WriteLine("Dengi ---------------------------------------");
            //_inventory.DisplayAll();

            Console.Write("Введите название предмета, который хотите найти: ");
            string Char = Console.ReadLine();
            _inventory.FindName(Char);
            

        }
    }
}
