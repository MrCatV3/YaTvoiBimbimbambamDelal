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
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nВаш инвентарь:");
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nИнвентарь отсортированный по имени предметов:");
                        _inventory.SortName();
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nИнвентарь отсортированный по цене предметов:");
                        _inventory.SortCost();
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nИнвентарь отсортированный по весу предметов:");
                        _inventory.SortWeight();
                        _inventory.DisplayAll();
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("\nВведите название предмета, который хотите найти: ");
                        string Char = Console.ReadLine();
                        _inventory.FindName(Char);
                        break;
                    case 6:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nВсё ваше оружие:");
                        _inventory.FiltrW();
                        Console.ResetColor();
                        break;
                    case 7:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nВся ваша броня:");
                        _inventory.FiltrA();
                        Console.ResetColor();
                        break;
                    case 8:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nВсе ваши другие предметы:");
                        _inventory.FiltrO();
                        Console.ResetColor();
                        break;
                    case 9:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        _inventory.SetArmor();
                        Console.ResetColor();
                        break;
                    case 10:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        _inventory.SetWeapon();
                        Console.ResetColor();
                        break;
                    case 11:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        _inventory.DisplayEquip();
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void create2()
        {
            _inventory.AddItem(new Item("Тряпка конца времён", 0.2, 100, "другое", false));
            _inventory.AddItem(new Item("Заколдованное щупальце осьминога", 120, 1200, "другое", false));
            _inventory.AddItem(new Item("Кирпич", 3.5, 0.01, "другое", false));
            _inventory.AddItem(new Item("Постапокалиптический виноград", 0.7, 15, "другое", false));
            _inventory.AddItem(new Item("Криогенный шашлык", 1, 15, "другое", false));
            _inventory.AddItem(new Item("Картошка", 5, 0.05, "другое", false));
            _inventory.AddItem(new Item("Глаз бога", 0, 50000, "другое", false));
            _inventory.AddItem(new Item("Рог дьявола", 100, 25000, "другое", false));
            _inventory.AddItem(new Item("Крыло грифона", 20, 2000, "другое", false));
            _inventory.AddItem(new Item("Свисток призывающий пегаса", 0.05, 3000, "другое", false));
            _inventory.AddItem(new Item("Водоросли", 0.15, 0.001, "другое", false));
            _inventory.AddItem(new Item("Пустой колчан", 2, 1, "другое", false));
            _inventory.AddItem(new Item("Бесконечная стрела", 0.03, 100, "другое", false));
            _inventory.AddItem(new Item("Зачарованая бесконечная стрела", 0.02, 1500, "другое", false));
            _inventory.AddItem(new Item("Браслет невидимости", 0.18, 2500, "другое", false));
            _inventory.AddItem(new Item("Высшее зелье восстановления здоровья", 0.25, 50, "другое", false));
            _inventory.AddItem(new Item("Воскрешающий свиток", 0.005, 5000, "другое", false));
            _inventory.AddItem(new Item("Карта", 0.02, 500, "другое", false));
            _inventory.AddItem(new Item("Кристаллический цветок маны", 3, 600, "другое", false));
            _inventory.AddItem(new Item("Космический бриллиант удвоения", 0.27, 1100, "другое", false));
            _inventory.AddItem(new Armor(1500,"Небесная броня", 80.5, 15000, "броня", false));
            _inventory.AddItem(new Armor(1000, "Призрачная броня", 30.15, 12000, "броня", false));
            _inventory.AddItem(new Armor(10, "Костюм новичка", 10, 0.1, "броня", false));
            _inventory.AddItem(new Armor(50, "Одеяния высшего мага", 20.2, 7000, "броня", false));
            _inventory.AddItem(new Armor(30, "Снаряжение охотника", 15.7, 1, "броня", false));
            _inventory.AddItem(new Armor(2000, "Адская броня", 130, 14000, "броня", false));
            _inventory.AddItem(new Weapon(1500, "Лук пробивающий небо", 8, 9000, "оружие", false));
            _inventory.AddItem(new Weapon(2000, "Посох уничтожения мира", 4, 20000, "оружие", false));
            _inventory.AddItem(new Weapon(1200, "Алебарда срубающая горы", 20, 13000, "оружие", false));
            _inventory.AddItem(new Weapon(500, "Перчатки бьющие истинным уроном", 3, 4000, "оружие", false));
            _inventory.AddItem(new Weapon(20, "Копьё охотника", 5, 1, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
            _inventory.AddItem(new Weapon(1, "Ржавый железный меч", 0.9, 0, "оружие", false));
        }
    }
}
