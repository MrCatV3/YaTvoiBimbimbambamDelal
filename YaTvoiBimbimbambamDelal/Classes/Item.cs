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

        public Item(string name, double weight, double cost, string type)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Type = type;
        }
        public virtual string Display()
        {
            return $"{Name} - вес: {Weight} кг, цена: {Cost} з";
        }
        
    }
}
