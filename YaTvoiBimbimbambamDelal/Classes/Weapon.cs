using System;
using System.Collections.Generic;
using System.Text;

namespace YaTvoiBimbimbambamDelal.Classes
{
    class Weapon : Item
    {
        public double Damage { get; set; }

        public Weapon(double damage, string name, double weight, double cost, string type, bool status) 
            : base(name, weight, cost, type, status)
        {
            Damage = damage;
        }

        public override string Display()
        {
            return base.Display() + $", {Damage} урона";
        }
    }
}
