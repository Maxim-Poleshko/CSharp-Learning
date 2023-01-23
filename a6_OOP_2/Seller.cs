using System;
using System.Xml.Linq;

using a6_OOP_2_User;
using a6_OOP_2_Inventory;
using a6_OOP_2_Buyer;

namespace a6_OOP_2_Seller
{
	public class Seller : User
    {
        public Seller(string name, int money) : base(name, money) { }

        public void StoreProducts()
        {
            string[] items = { "Power tool accessories", "Dog toys", "Costume shoes", "Laptop batteries", "Shot glasses", "Slipcovers", "Wall plates and covers", "Baby shirts", "Curtain and drape rings", "Cabinet knobs and handles" };
            foreach (var item in items)
            {
                Random random = new Random();

                inventories.Add(new Inventory(random.Next(1, 2000), item, random.Next(1, 80)));
            }
        }


        public void CheckBalance()
        {
            Console.WriteLine($"Name of {Name} - money balance is: {Money} - qty. items: {inventories.Count()}");
        }


        public void ShowInventory()
        {
            foreach (var item in inventories)
            {
                Console.WriteLine($"{item.Id} - {item.Name}, price: {item.Price}");
            }
        }

        public void Sell(Buyer buyer)
        {
            string searchName;

            ShowInventory();

            Console.Write("\nWhich one do you want to buy: ");
            searchName = Console.ReadLine().ToLower();

            for (int i = 0; i < inventories.Count(); i++)
            {
                if (inventories[i].Name.ToLower() == searchName)
                {
                    int indexOfItem = inventories.IndexOf(inventories[i]);

                    if (buyer.TryToBuy(inventories[i]))
                    {
                        buyer.Buy(inventories[i]);
                        Money += inventories[i].Price;
                        inventories.Remove(inventories[indexOfItem]);
                    }
                }
            }
        }
    }
}

