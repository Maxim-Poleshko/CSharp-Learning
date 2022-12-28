using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

using a5_ClassMethodStructInterface_PlayerPosition;
using a5_ClassMethodStructInterface_RenderPosition;
using a5_ClassMethodStructInterface_Player;
using a5_ClassMethodStructInterface_Table;

class a5_ClassMethodStructInterface
{
    static void Main(string[] args)
    {
        //ClassInit();
        //StructInit();
        //InterfaceInit();
        //PlayerClass();
        PropertiesPractice();
    }

    static void ClassInit()
    {
        Table table1 = new Table();
        table1.Width = 100;
        table1.Height = 100;
        table1.Lenght = 100;

        Table table2;
        table2 = table1;
        table2.Width = 70;

        Console.WriteLine($"Width of table2 were copied from table2 and width " +
            $"was combined table2:{table2.Width} with table1:{table1.Width}");

        table1.CalculatingPackageSize(table1.Width, table1.Height, table1.Lenght);
        Console.WriteLine();

        Table table3 = new Table();
        table3.ShowSettings();
        Console.WriteLine();

        Table table4 = new Table(50, 60, 70);
        table4.ShowSettings();
    }

    
    static void StructInit()
    {
        Person oleg = new Person() { age = 14 };
        oleg.name = "Oleg";
        Person roman = new Person();
        Person max = oleg with { name = "Max" };
        
        oleg.ShowPersong();
        roman.ShowPersong();
        max.ShowPersong();
    }

    struct Person
    {
        public string name;
        public int age;

        public Person()
        {
            name = "default";
            age = 0;
        }

        public void ShowPersong()
        {
            Console.WriteLine($"Name is:{name}, age is {age}");
        }
    }

    static void InterfaceInit()
    {
        IMovable movable = new Car();
    }

    interface IMovable
    {
        void Move();
        void OneMove();
    }

    class Car : IMovable
    {
        public void Move()
        {
            throw new NotImplementedException();
        }

        public void OneMove()
        {
            throw new NotImplementedException();
        }
    }

    //Создать класс игрока, с полями содержащими информацию об игроке и методом, который выводит информацию на экран.
    //В классе обязательно должен быть конструктор
    static void PlayerClass()
    {
        Player player = new Player("Max", 30, "male");
        player.ShowInfo();
    }


    //Создать класс игрока, у которого есть поля с его положением в x,y.
    //Создать класс отрисовщик, с методом который отрисует игрока.
    //Попрактиковаться в работе со свойствами.

    static void PropertiesPractice()
    {
        Console.Write("Set x:");
        int xPosition = Convert.ToInt32(Console.ReadLine());
        Console.Write("Set y:");
        int yPosition = Convert.ToInt32(Console.ReadLine());
        RenderPosition renderPosition = new RenderPosition();
        PlayerPosition playerPosition = new PlayerPosition(xPosition, yPosition);

        Console.Clear();
        renderPosition.Draw(playerPosition.X, playerPosition.Y);
    }

}