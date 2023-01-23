using System;


namespace a6_OOP_2_Inventory
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Inventory(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}

