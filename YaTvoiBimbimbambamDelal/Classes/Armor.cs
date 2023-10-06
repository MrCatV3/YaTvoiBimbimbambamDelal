using System;
using System.Collections.Generic;
using System.Text;

namespace YaTvoiBimbimbambamDelal.Classes
{
    public class Armor : Item
    {
        public double Defence { get; set; }

        public Armor(double defence, string name, double weight, double cost, string type)
            : base(name, weight, cost, type)
        {
            Defence = defence;
        }

        public override string Display()
        {
            return base.Display() + $", {Defence} защиты";
        }

        
    }
}
