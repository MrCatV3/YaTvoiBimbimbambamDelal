using System;
using System.Collections.Generic;
using System.Text;

namespace YaTvoiBimbimbambamDelal.Classes
{
    public class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }

        public Item(string name, double weight, double cost, string type, bool status)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Type = type;
            Status = status;
        }
        public virtual string Display()
        {
            return $"{Name} - вес: {Weight} кг, цена: {Cost} з";
        }
        
    }
}
