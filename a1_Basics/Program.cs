using System;

namespace a1_Basics
{
    class Variables
    {
        
        static void Main(string[] args)
        {
            variables();
            dataTypes();
            convertData();
            arithmeticalOperatorators();
            questionarie();
        }

        static void variables()
        {
            byte byteIntFrom0to255;
            sbyte byteIntFromMin127to128;
            short intFromMin32kTo32k;
            ushort intFrom0to65k;
            int intFroMin2BilTo28Bil;
            uint intFrom0to4Bil;
            long intLong;
            ulong intUlong;

            float float7Char;
            double float15char;

            char charSybols;

            string strCharacters;

            bool trueFalse;
        }

        

        static void dataTypes()
        {
            //Задача:
            //На экране в специальной зоне выводятся картинки, по 3 в ряд.Всего у пользователя в альбоме 52 картинки.
            //Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.

            //В качестве решения ожидается объявленные переменные с необходимыми
            //значениями и вывод необходимых данных основываясь на значениях переменных.

            int usersImages = 52;
            Console.WriteLine("Полностью заполнено рядом в альбоме " + usersImages / 3 + " и количество сверх норми " + usersImages % 3);
            // output: Полностью заполнено рядом в альбоме 18 и количество сверх норми 0
        }

        static void convertData()
        {
            //Легенда:
            //Вы приходите в магазин и хотите купить за своё золото кристаллы.
            //В вашем кошельке есть какое - то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить?
            //После сделки у вас остаётся какое - то количество золота и появляется какое - то количество кристаллов.

            //Формально:
            //При старте программы пользователь вводит начальное количество золота.
            //Потом ему предлагается купить какое - то количество кристаллов по цене N(задать в программе самому).
            //Пользователь вводит число и его золото конвертируется в кристаллы.Остаток золота и кристаллов выводится на экран.

            int myWalletCurrencyGold;
            int wantToBuy;

            int marketCrystallsStock = 100;
            int marketCrystallPrice = 10;

            Console.Write("How much gold do you have? ");
            myWalletCurrencyGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myWalletCurrencyGold);

            Console.Write("How much do you want to buy: ");
            wantToBuy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have " + (myWalletCurrencyGold - (marketCrystallPrice * wantToBuy)
                + " gold and " + wantToBuy + " crystals."));

        }

        static void arithmeticalOperatorators()
        {
            //Легенда:
            //Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.

            //Формально:
            //Пользователь вводит кол - во людей в очереди.
            //Фиксированное время приема одного человека всегда равно 10 минутам.
            //Пример ввода: Введите кол-во старушек: 14
            //Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."
            
            int queue;
            int waitForEachPerson = 10;

            Console.Write("How many people in queue: ");
            queue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You need to wait " + (waitForEachPerson * queue / 60) + "h and " + (waitForEachPerson * queue % 60) + "m");
        }

        static void questionarie()
        {
            //Конкатенация
            int age;
            string name;
            string city;

            Console.Write("What's your name: ");
            name = Console.ReadLine();
            Console.Write("How old are you: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("What's the city do you live: ");
            city = Console.ReadLine();

            Console.WriteLine("Your name is " + name + " " + age + " years old from " + city + ".");
        }
    }
}
