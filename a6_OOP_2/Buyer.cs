using System;
using System.Xml.Linq;

using a6_OOP_2_User;
using a6_OOP_2_Inventory;


namespace a6_OOP_2_Buyer
{
    public class Buyer : User
    {
        public Buyer(string name, int money) : base(name, money) { }

        public void CheckBalance()
        {
            Console.WriteLine($"Name of {Name} - money balance is: {Money} - qty. items: {inventories.Count()}");
        }

        public void ShowInventory()
        {
            if (inventories.Count() > 0)
            {
                foreach (var item in inventories)
                {
                    Console.WriteLine($"{item.Id} - {item.Name}, price: {item.Price}");
                }
            }
            else
            {
                Console.WriteLine("The inventory is still empty...");
            }
        }

        public bool TryToBuy(Inventory inverntoryObject)
        {
            if (Money == 0)
            {
                Console.WriteLine("You have no money");
                return false;
            }
            else if (inverntoryObject.Price > Money)
            {
                Console.WriteLine("You don't have enough money");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Buy(Inventory inverntoryObject)
        {
            Money -= inverntoryObject.Price;
            inventories.Add(inverntoryObject);
            Console.WriteLine("Item bought!");
        }
    }
}

