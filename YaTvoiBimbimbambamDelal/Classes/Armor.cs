using System;
using System.Collections.Generic;
using System.Text;

namespace YaTvoiBimbimbambamDelal.Classes
{
    public class Armor : Item
    {
        public double Defence { get; set; }

        public Armor(double defence, string name, double weight, double cost, string type, bool status)
            : base(name, weight, cost, type, status)
        {
            Defence = defence;
        }

        public override string Display()
        {
            return base.Display() + $", {Defence} защиты";
        }

        
    }
}
