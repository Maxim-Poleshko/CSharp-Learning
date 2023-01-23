//Существует продавец, он имеет у себя список товаров и при нужде может вам его показать,
//также продавец может продать вам товар. После продажи товар переходит к вам, и вы можете также посмотреть свои вещи.
//Возможные классы – игрок, продавец, товар.

using System;
using System.Diagnostics;
using System.Reflection.Emit;

using a6_OOP_2_Buyer;
using a6_OOP_2_Seller;

class a6_OOP
{
    static void Main(string[] args)
    {
        bool appRunning = true;

        string name;
        int money;

        Console.Write("Set your name to sign in as buyer: ");
        name = Console.ReadLine();
        Console.Write("Set how much money you want to deposit: ");
        money = Convert.ToInt32(Console.ReadLine());

        Buyer buyer = new Buyer("buyer: " + name, money);
        Seller seller = new Seller("seller: " + "Roman", 10);
        Console.Clear();

        seller.StoreProducts();


        while (appRunning)
        {
            Console.Write("1 - Check yours balance\n2 - Check seller balance\n3 - Buy product\n5 - Exit\nSet: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    buyer.CheckBalance();
                    buyer.ShowInventory();
                    buyer.BuetifyOutput();
                    break;

                case 2:
                    seller.CheckBalance();
                    seller.ShowInventory();
                    seller.BuetifyOutput();
                    break;

                case 3:
                    seller.Sell(buyer);
                    seller.BuetifyOutput();
                    break;

                case 5:
                    appRunning = false;
                    break;
            }
        }
    }
}