using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace a3_Arrays_Methods;

class ArraysAndMethods
{
    static void Main(string[] args)
    {
        //BarsMainSettings();
        //ReadIntConverter();
        //ShaffleElements();
        //CounterOfPositiveNegativeNumbers();
        //RemoveSmallestValueInArray();
        FactorialViaRecursion();
    }

    static void BarsMainSettings()
    {
        //Разработайте функцию, которая рисует некий бар(Healthbar, Manabar)в определённой позиции.Она также принимает некий закрашенный процент.
        //При 40% бар выглядит так:
        //[####_____]

        Console.Write("Set how much health your character has: ");
        int health = Convert.ToInt32(Console.ReadLine());
        Console.Write("Set how much mana your character has: ");
        int mana = Convert.ToInt32(Console.ReadLine());

        string leftBoundary = "[";
        string rightBoundary = "]";
        int lengtOfTheBars = 50;

        ConsoleColor DefaultColor = Console.BackgroundColor;
        Console.Write("Health " + leftBoundary);
        for (int i = 0; i < lengtOfTheBars; i++)
        {
            if (i < health)
            {
                Console.BackgroundColor = ConsoleColor.Red;

                Console.Write("#");
            }
            else
            {
                Console.BackgroundColor = DefaultColor;
                Console.Write("_");

            }
        }
        Console.Write(rightBoundary);
        Console.BackgroundColor = DefaultColor;

        Console.Write("\nMana   " + leftBoundary);
        for (int i = 0; i < lengtOfTheBars; i++)
        {
            if (i < mana)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("#");
            }
            else
            {
                Console.BackgroundColor = DefaultColor;
                Console.Write("_");

            }
        }
        Console.Write(rightBoundary);
        Console.ReadKey();

    }

    static void ReadIntConverter()
    {
        //Написать функцию, которая запрашивает число у пользователя(с помощью метода Console.ReadLine() ) и
        //    пытается сконвертировать его в тип int(с помощью int.TryParse())
        //Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно.
        //После ввода, который удалось преобразовать в число, число возвращается.
        //P.S Задача решается с помощью циклов
        //P.S Также в TryParse используется модфикатор параметра out

        bool intConverted = true;
        while (intConverted)
        {
            Console.Write("Set the number to convert to Int32: ");
            string userNumber = Console.ReadLine();

            while (int.TryParse(userNumber, out int result) == false && intConverted)
            {
                Console.WriteLine("Wrong type of number set.");
                break;
            }
            while (int.TryParse(userNumber, out int result) && intConverted)
            {
                Console.WriteLine(userNumber + " converted to Int32 successfully.");
                intConverted = false;
                Console.ReadKey();
            }

        }
    }

    static void ShaffleElements()
    {
        //Реализуйте метод Shuffle, который перемешивает элементы массива в случайном порядке.
        bool runningApp = true;
        string[] array = new string[0];

        while (runningApp)
        {
            Console.WriteLine("Set '1' to set the numbers\nSet '2' to shaffle numbers in the array\nSet '3' to quit");
            int menuChoosing = Convert.ToInt32(Console.ReadLine());

            if (menuChoosing == 1)
            {
                bool setNumberCycle = true;

                while (setNumberCycle)
                {
                    Console.Write("Set number or 'Stop' to exit ");
                    string item = Console.ReadLine().ToLower();

                    if (item != "stop")
                    {
                        string[] tempArray = new string[array.Length + 1];
                        for (int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i];
                        }
                        tempArray[tempArray.Length - 1] = item;
                        array = tempArray;
                    }
                    else if (item == "stop")
                    {
                        setNumberCycle = false;
                    }
                }
                Console.WriteLine("You got back to menu\n");
            }
            else if (menuChoosing == 2)
            {
                Console.Clear();
                if (array.Length != 0)
                {
                    Console.Write("Original array -> ");
                    foreach (var item in array)
                    {
                        Console.Write(item + " ");
                    }

                    Console.Write("\nShaffled array -> ");
                    Random random = new Random();
                    array = array.OrderBy(x => random.Next()).ToArray();
                    foreach (var i in array)
                    {
                        Console.Write(i + " ");
                    }
                }
                else if (array.Length == 0)
                {
                    Console.WriteLine("The array hasn't filled yet");
                }
            }
            else if (menuChoosing == 3)
            {
                runningApp = false;
                Console.WriteLine("The app has been stopped");
            }
            Console.ReadKey();
            Console.Clear();
        }

    }

    static void CounterOfPositiveNegativeNumbers()
    {
        //https://www.codewars.com/kata/576bb71bbbcf0951d5000044
        //Given an array of integers.
        //Return an array, where the first element is the count of positives numbers and
        //    the second element is sum of negative numbers. 0 is neither positive nor negative.
        //If the input is an empty array or is null, return an empty array.
        //Example
        //For input[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        int counterOfPositiveNumbers = 0;
        int counterOfNegativeNumbers = 0;

        foreach (var item in arr)
        {
            //Console.WriteLine($"item = {item}");
            if (item > 0)
            {
                counterOfPositiveNumbers += 1;
            }
            else if (item < 0)
            {
                counterOfNegativeNumbers += item;
            }

        }
        Console.WriteLine($"Positive numbers are {counterOfPositiveNumbers} and sum of negative numbers equal to {counterOfNegativeNumbers}");

    }

    static void RemoveSmallestValueInArray()
    {
        //https://www.codewars.com/kata/563cf89eb4747c5fb100001b
        //Given an array of integers, remove the smallest value.Do not mutate the original array/ list.
        //    If there are multiple elements with the same value, remove the one with a lower index.
        //    If you get an empty array/ list, return an empty array/ list.
        //Don't change the order of the elements that are left.

        //Examples
        //* Input: [1,2,3,4,5], output = [2, 3, 4, 5]
        //* Input: [5,3,2,1,4], output = [5, 3, 2, 4]
        //* Input: [2,2,1,2,1], output = [2, 2, 2, 1]

        ConvertToList(new int[] { 1, 2, 3, 4, 5 });
        ConvertToList(new int[] { 5, 3, 2, 1, 4 });
        ConvertToList(new int[] { 2, 2, 1, 2, 1 });
        ConvertToList(new int[0]);


        static void ConvertToList(int[] Arr1)
        {
            List<int> ArrayConvertedToList = new List<int>();
            foreach (var item in Arr1)
            {
                ArrayConvertedToList.Add(item);
            }

            if (Arr1.Length > 0)
            {
                ArrayConvertedToList.Remove(Arr1.Min());

                foreach (var item in ArrayConvertedToList)
                {
                    Console.Write($"{item} ");
                }
            }
            else if (Arr1.Length == 0)
            {
                Console.WriteLine("No elements in the array");
            }

            Console.WriteLine();
        }
    }

    static void FactorialViaRecursion()
    {
        //https://www.codewars.com/kata/5694cb0ec554589633000036
        //#1 - Factorial
        //In mathematics, the factorial of a non-negative integer n, denoted by n!,
        //        is the product of all positive integers less than or equal to n. For example,
        //5! = 5 * 4 * 3 * 2 * 1 = 120

        //The value of 0! is 1.
        //You have to create the function factorial that receives n and returns n!.You have to use recursion.

        int number;

        Console.Write("Set value and returns factorial number: ");
        Factorial(Convert.ToInt32(Console.ReadLine()));

        static int Factorial(int n)
        {
            int result = 0;
            int b = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = result;
                result = b;
                b += temp;
            }

            Console.WriteLine(b);
            return b;

        }

    }
}