using System;

using a6_OOP_2_Inventory;

namespace a6_OOP_2_User
{
    public class User
    {
        public string Name;
        public double Money;
        protected List<Inventory> inventories = new List<Inventory>();

        public User(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void BuetifyOutput()
        {
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
    }
}

