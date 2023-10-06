using System;
using System.Dynamic;

using YaTvoiBimbimbambamDelal.Classes;

namespace YaTvoiBimbimbambamDelal
{
    class Program
    {
        static Inventory _inventory = new Inventory();
        static void Main(string[] args)
        {
            int i = 0;
            create2();
            while (i != 12)
            {
                Console.WriteLine("\n 1 - Вывод всего инвентаря, 2 - Сортировка по имени, 3 - Сортировка по цене, 4 - Сортировка по весу\n 5 - Поиск предмета по названию, 6 - Фильтр по оружию, 7 - Фильтр по броне, 8 - Фильтр по другим предметам\n 9 - Экипировать броню, 10 - Экипировать оружие, 11 - Просмотр экипированных предметов, 12 - Выход");
                Console.Write("\nВведите номер действия: ");
                i = Int32.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nВаш инвентарь:");
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nИнвентарь отсортированный по имени предметов:");
                        _inventory.SortName();
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nИнвентарь отсортированный по цене предметов:");
                        _inventory.SortCost();
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nИнвентарь отсортированный по весу предметов:");
                        _inventory.SortWeight();
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.Write("\nВведите название предмета, который хотите найти: ");
                        string Char = Console.ReadLine();
                        _inventory.FindName(Char);
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nВсё ваше оружие:");
                        _inventory.FiltrW();
                        Console.ResetColor();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nВся ваша броня:");
                        _inventory.FiltrA();
                        Console.ResetColor();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nВсе ваши другие предметы:");
                        _inventory.FiltrO();
                        Console.ResetColor();
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Green;
                        _inventory.SetArmor();
                        Console.ResetColor();
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        _inventory.SetWeapon();
                        Console.ResetColor();
                        break;
                    case 11:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        _inventory.DisplayEquip();
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void create2()
        {
            _inventory.AddItem(new Item("тряпка конца времён", 0.2, 100, "другое", false));
            _inventory.AddItem(new Item("заколдованное щупальце осьминога", 120, 1200, "другое", false));
            _inventory.AddItem(new Item("кирпич", 3.5, 0.01, "другое", false));
            _inventory.AddItem(new Item("постапокалиптический виноград", 0.7, 15, "другое", false));
            _inventory.AddItem(new Item("криогенный шашлык", 1, 15, "другое", false));
            _inventory.AddItem(new Item("картошка", 5, 0.05, "другое", false));
            _inventory.AddItem(new Item("глаз бога", 0, 50000, "другое", false));
            _inventory.AddItem(new Item("рог дьявола", 100, 25000, "другое", false));
            _inventory.AddItem(new Item("крыло грифона", 20, 2000, "другое", false));
            _inventory.AddItem(new Item("свисток призывающий пегаса", 0.05, 3000, "другое", false));
            _inventory.AddItem(new Item("водоросли", 0.15, 0.001, "другое", false));
            _inventory.AddItem(new Item("пустой колчан", 2, 1, "другое", false));
            _inventory.AddItem(new Item("бесконечная стрела", 0.03, 100, "другое", false));
            _inventory.AddItem(new Item("зачарованая бесконечная стрела", 0.02, 1500, "другое", false));
            _inventory.AddItem(new Item("браслет невидимости", 0.18, 2500, "другое", false));
            _inventory.AddItem(new Item("высшее зелье восстановления здоровья", 0.25, 50, "другое", false));
            _inventory.AddItem(new Item("воскрешающий свиток", 0.005, 5000, "другое", false));
            _inventory.AddItem(new Item("карта", 0.02, 500, "другое", false));
            _inventory.AddItem(new Item("кристаллический цветок маны", 3, 600, "другое", false));
            _inventory.AddItem(new Item("космический бриллиант удвоения", 0.27, 1100, "другое", false));
            _inventory.AddItem(new Armor(1500,"небесная броня", 80.5, 15000, "броня", false));
            _inventory.AddItem(new Armor(1000, "призрачная броня", 30.15, 12000, "броня", false));
            _inventory.AddItem(new Armor(10, "костюм новичка", 10, 0.1, "броня", false));
            _inventory.AddItem(new Armor(50, "одеяния высшего мага", 20.2, 7000, "броня", false));
            _inventory.AddItem(new Armor(30, "снаряжение охотника", 15.7, 1, "броня", false));
            _inventory.AddItem(new Armor(2000, "адская броня", 130, 14000, "броня", false));
            _inventory.AddItem(new Weapon(1500, "лук пробивающий небо", 8, 9000, "оружие", false));
            _inventory.AddItem(new Weapon(2000, "посох уничтожения мира", 4, 20000, "оружие", false));
            _inventory.AddItem(new Weapon(1200, "алебарда срубающая горы", 20, 13000, "оружие", false));
            _inventory.AddItem(new Weapon(500, "перчатки бьющие истинным уроном", 3, 4000, "оружие", false));
            _inventory.AddItem(new Weapon(20, "копьё охотника", 5, 1, "оружие", false));
            _inventory.AddItem(new Weapon(1, "ржавый железный меч", 0.9, 0, "оружие", false));
        }
    }
}
