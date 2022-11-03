﻿using System;

namespace a2_conditionalOperators
{
    class conditionals
    {
        static void Main(string[] args)
        {
            verifyAgeIfElse();
            verifyMonthSwitch();
            whileCounter();
            loopUntillStopMessage();
        }

        static void verifyAgeIfElse()
        {
            // Написать проверку по возрасту до 18 лет отказ, если больше разрешить
            int age;

            Console.Write("How old are you: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Allowed");
            }
            else if (age < 18)
            {
                Console.WriteLine("Rejected");
            }
        }

        static void verifyMonthSwitch()
        {
            // Switch checks
            string month;
            int persons;

            Console.Write("What's month are you interested in: ");
            month = Console.ReadLine();
            Console.Write("How many person should be placed in appartment: ");
            persons = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case "September":
                    Console.WriteLine("All dates has already reserved in September");
                    break;
                case "November":
                case "December":
                    Console.WriteLine("All dates has already reserved in these months");
                    break;
                case "January":
                    if (persons >= 3)
                    {
                        Console.WriteLine("All dates has already reserved in this month");
                        break;
                    }
                    else if (persons == 2 || persons == 1)
                    {
                        if (persons == 2)
                        {
                            Console.WriteLine("2 appartments free");
                            break;
                        }
                        if (persons == 1)
                        {
                            Console.WriteLine("10 appartments free");
                            break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Not found any information");
                    break;
            }
        }

        static void whileCounter()
        {
            // Задача:
            // При помощи циклов вы можете повторять один и тот же код множество раз.
            //Напишите простейшую программу которая выводит заданное пользователем сообщение заданное пользователем количество раз.

            int attempts;
            string message;

            Console.Write("Put description here: ");
            message = Console.ReadLine();
            Console.Write("How many reminders do you need: ");
            attempts = Convert.ToInt32(Console.ReadLine());

            while (attempts > 0)
            {
                Console.WriteLine(message);
                attempts--;
            }
        }

        static void loopUntillStopMessage()
        {
            //Задача:
            //Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
            //Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
            //Это нужно чтобы любой разработчик взглянув на ваш код понял четкие границы вашего цикла.

            string exitWord = "exit";
            string userInput = "";

            while (exitWord != userInput)
            {
                Console.Write("Set 'exit' command to quit: ");
                userInput = Console.ReadLine();
            }
        }

    }
}