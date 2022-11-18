using System;

namespace a2_conditionalOperators
{
    class conditionals
    {
        static void Main(string[] args)
        {
            //verifyAgeIfElse();
            //verifyMonthSwitch();
            //whileCounter();
            //loopUntillStopMessage();
            //currencyConverter();
            ConsoleProgramForChangingProfileInformetion();  // ref out should be re-wrote
            //Febonachi();
            //NameWithFrame();
            //PasswordChecker();
            //RandomGuess();

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

        static void currencyConverter()
        {
            //Задача:
            //Написать конвертер валют(3 валюты).
            //У пользователя есть баланс в каждой из представленных валют.
            //Он может попросить сконвертировать часть баланса в одной валюты в другую.
            //Тогда у него с баланса одной валюты снимет X и зачислится на баланс другой Y.
            //Курс конвертации должен быть просто прописан в программе.

            //Программа должна завершиться тогда, когда это решит пользователь.

            int courseUSDbuyInUAH = 41;
            int courseUSDsellInUAH = 40;
            int courseEURbuyInUAH = 40;
            int courseEURsellInUAH = 39;
            float courseUSDbuyInEUR = 1f;
            float courseUSDsellInEUR = 1.02f;

            float ballanceUSD = 100;
            float ballanceUAH = 3000;
            float ballanceEUR = 80;

            int programmRunning = 0;
            int programmQuit = 0;
            int changingWay;

            while (programmRunning != 200)
            {
                if (programmQuit == 0)
                {
                    Console.WriteLine("Press 1 to convert USD ");
                    Console.WriteLine("Press 2 to convert EUR ");
                    Console.WriteLine("Press 0 to Quit ");
                    programmRunning = Convert.ToInt32(Console.ReadLine());

                    switch (programmRunning)
                    {
                        case 1:
                            Console.WriteLine("Press 1 to convert UAH -> USD");
                            Console.WriteLine("Press 2 to convert USD -> UAH");
                            Console.WriteLine("Press 3 to convert USD -> EUR");
                            changingWay = Convert.ToInt32(Console.ReadLine());
                            if (changingWay == 1)
                            {
                                Console.WriteLine("UAH ballance is: " + ballanceUAH);
                                Console.Write("How much do you want to change: ");
                                float needsToConvert = Convert.ToSingle(Console.ReadLine());
                                if (needsToConvert <= ballanceUAH && needsToConvert != 0)
                                {
                                    ballanceUSD += needsToConvert / courseUSDbuyInUAH;
                                    ballanceUAH -= needsToConvert;
                                    Console.WriteLine(ballanceUSD + " USD");
                                    programmRunning = 100;
                                    break;
                                }
                                else if (needsToConvert > ballanceUAH)
                                {
                                    Console.WriteLine(
                                        "You don't have enough currency for this trasaction"
                                    );
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    break;
                                }
                            }
                            else if (changingWay == 2)
                            {
                                Console.WriteLine("USD ballance is: " + ballanceUSD);
                                Console.Write("How much do you want to change: ");
                                float needsToConvert = Convert.ToSingle(Console.ReadLine());
                                if (needsToConvert <= ballanceUSD && needsToConvert != 0)
                                {
                                    ballanceUAH += needsToConvert * courseUSDsellInUAH;
                                    ballanceUSD -= needsToConvert;
                                    Console.WriteLine(ballanceUAH + " UAH");
                                    programmRunning = 100;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    if (needsToConvert > ballanceUSD)
                                    {
                                        Console.WriteLine(
                                            "You don't have enough currency for this trasaction"
                                        );
                                    }
                                    break;
                                }
                            }
                            else if (changingWay == 3)
                            {
                                Console.WriteLine("USD ballance is: " + ballanceUSD);
                                Console.Write("How much do you want to change: ");
                                float needsToConvert = Convert.ToSingle(Console.ReadLine());
                                if (needsToConvert <= ballanceUSD && needsToConvert != 0)
                                {
                                    ballanceEUR += needsToConvert * courseUSDsellInEUR;
                                    ballanceUSD -= needsToConvert;
                                    Console.WriteLine(ballanceEUR + " EUR");
                                    programmRunning = 100;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    if (needsToConvert > ballanceEUR)
                                    {
                                        Console.WriteLine(
                                            "You don't have enough currency for this trasaction"
                                        );
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                changingWay = 0;
                                break;
                            }
                        case 2:
                            Console.WriteLine("Press 1 to convert UAH -> EUR");
                            Console.WriteLine("Press 2 to convert EUR -> UAH");
                            Console.WriteLine("Press 3 to convert EUR -> USD");
                            changingWay = Convert.ToInt32(Console.ReadLine());
                            if (changingWay == 1)
                            {
                                Console.WriteLine("UAH ballance is: " + ballanceUAH);
                                Console.Write("How much do you want to change: ");
                                float needsToConvert = Convert.ToSingle(Console.ReadLine());
                                if (needsToConvert <= ballanceUAH && needsToConvert != 0)
                                {
                                    ballanceEUR += needsToConvert / courseEURbuyInUAH;
                                    ballanceUAH -= needsToConvert;
                                    Console.WriteLine(ballanceEUR + " EUR");
                                    programmRunning = 100;
                                    break;
                                }
                                else if (needsToConvert > ballanceUAH)
                                {
                                    Console.WriteLine(
                                        "You don't have enough currency for this trasaction"
                                    );
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    break;
                                }
                            }
                            else if (changingWay == 2)
                            {
                                Console.WriteLine("EUR ballance is: " + ballanceEUR);
                                Console.Write("How much do you want to change: ");
                                float needsToConvert = Convert.ToSingle(Console.ReadLine());
                                if (needsToConvert <= ballanceEUR && needsToConvert != 0)
                                {
                                    ballanceUAH += needsToConvert * courseEURsellInUAH;
                                    ballanceEUR -= needsToConvert;
                                    Console.WriteLine(ballanceUAH + " UAH");
                                    programmRunning = 100;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    if (needsToConvert > ballanceEUR)
                                    {
                                        Console.WriteLine(
                                            "You don't have enough currency for this trasaction"
                                        );
                                    }
                                    break;
                                }
                            }
                            else if (changingWay == 3)
                            {
                                Console.WriteLine("EUR ballance is: " + ballanceEUR);
                                Console.Write("How much do you want to change: ");
                                float needsToConvert = Convert.ToSingle(Console.ReadLine());
                                if (needsToConvert <= ballanceEUR && needsToConvert != 0)
                                {
                                    ballanceUSD += needsToConvert * courseUSDbuyInEUR;
                                    ballanceEUR -= needsToConvert;
                                    Console.WriteLine(ballanceUSD + " USD");
                                    programmRunning = 100;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    if (needsToConvert > ballanceUSD)
                                    {
                                        Console.WriteLine(
                                            "You don't have enough currency for this trasaction"
                                        );
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                changingWay = 0;
                                break;
                            }
                        case 0:
                            programmRunning = 200;
                            programmQuit = 200;
                            break;
                        default:
                            programmRunning = 100;
                            break;
                    }
                }

                if (programmRunning == 100)
                {
                    Console.WriteLine("Do you want to continue converting? ");
                    Console.Write("Yes or No: ");
                    string answerToContinue = Console.ReadLine();
                    switch (answerToContinue)
                    {
                        case "Yes":
                            programmQuit = 0;
                            break;
                        case "No":
                            programmQuit = 200;
                            break;
                    }
                }
                if (programmQuit == 200)
                {
                    Console.WriteLine(
                        "Your balance USD: "
                            + ballanceUSD
                            + ", UAH: "
                            + ballanceUAH
                            + ", EUR: "
                            + ballanceEUR
                    );
                    programmRunning = 200;
                }
            }
        }

        static void ConsoleProgramForChangingProfileInformetion()
        {
            string NameField = null;
            string AddressField = null;
            string PasswordField = null;
            string DescriptionField = null;
            string BithdayField = null;
            string Exit = "";

            int WhatOperationIsTaking;

            string VariableWillBeChanged = "";
            string WhichFieldIsChanging;


            while (Exit != "Exit")
            {
                Console.WriteLine("Input 1 to set Name ");
                Console.WriteLine("Input 2 to set Address ");
                Console.WriteLine("Input 3 to set Password ");
                Console.WriteLine("Input 4 to set Description ");
                Console.WriteLine("Input 5 to set Birth Day ");
                Console.WriteLine("Input 'Exit' to quit");
                WhichFieldIsChanging = Console.ReadLine();

                switch (WhichFieldIsChanging)
                {
                    case "1":
                        int ProgrammRunning = 0;
                        while (ProgrammRunning != 1)
                        {
                            Console.WriteLine("Set 1 to Set");
                            Console.WriteLine("Set 2 to Reset");
                            WhatOperationIsTaking = Convert.ToInt32(Console.ReadLine());
                            if (WhatOperationIsTaking == 1)
                            {
                                Console.Write("Set new data: ");
                                VariableWillBeChanged = Console.ReadLine();
                                Console.Write("Do you want to 'Save' or get 'Back': ");
                                string SaveOrBack = Console.ReadLine();
                                if (SaveOrBack == "Save")
                                {
                                    if (NameField == VariableWillBeChanged)
                                    {
                                        Console.WriteLine("Set unigue data");
                                        break;
                                    }
                                    else
                                    {
                                        NameField = VariableWillBeChanged;
                                        ProgrammRunning = 1;
                                        break;
                                    }
                                }
                                else if (SaveOrBack == "Back")
                                {
                                    ProgrammRunning = 1;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    ProgrammRunning = 0;
                                    break;
                                }

                            }
                            else if (WhatOperationIsTaking == 2)
                            {
                                Console.Write("Do you want to 'Reset' or get 'Back': ");
                                string SaveOrBack = Console.ReadLine();
                                if (SaveOrBack == "Reset")
                                {
                                    NameField = null;
                                    ProgrammRunning = 1;
                                    break;
                                }
                                else if (SaveOrBack == "Back")
                                {
                                    ProgrammRunning = 1;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong");
                                    ProgrammRunning = 0;
                                    break;
                                }
                            }
                        }

                        break;

                    case "2":
                        //MyMethod("AddressField", "Kharkiv");
                        Console.WriteLine(AddressField);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "Exit":
                        Exit = "Exit";
                        Console.WriteLine("Program were stopped");
                        Console.WriteLine("Name: " + NameField);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        static void Febonachi()
        {
            //Нужно написать программу(используя циклы, обязательно пояснить выбор вашего цикла),
            //чтобы она выводила следующую последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98

            int FeboSequence = 7;
            for (int i = 0; i != 14; i++)
            {
                Console.WriteLine(FeboSequence);
                FeboSequence += 7;
            }
        }

        static void NameWithFrame()
        {
            string Name;
            char CharName;
            string NameLenghtChar = null;

            Console.Write("What's your name: ");
            Name = Console.ReadLine();
            Console.Write("Set a char that are you inderested in: ");
            CharName = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i < (Name.Length + 4); i++)
            {
                NameLenghtChar += CharName;
            }
            Console.WriteLine(NameLenghtChar + "\n" + CharName + " " + Name + " " + CharName + "\n" + NameLenghtChar);

        }

        static void PasswordChecker()
        {
            string Password = "Bandera";
            int AllowsCounts = 3;
            int UsedCounts = 0;
            bool RunningApp = true;

            while (RunningApp)
            {
                if (AllowsCounts > UsedCounts)
                {
                    Console.Write("You have " + (AllowsCounts - UsedCounts) + " attempts.\nSet password: ");
                    string GuessPass = Console.ReadLine();
                    if (GuessPass == Password)
                    {
                        Console.Clear();
                        UsedCounts = 0;
                        Console.WriteLine("Got access to the secret message\nAttempt count erased.");
                        RunningApp = false;
                    }
                    else if (GuessPass != Password)
                    {
                        UsedCounts += 1;
                        Console.WriteLine("Wrong password.");
                        Console.Clear();
                    }
                }
                else if (AllowsCounts <= UsedCounts)
                {
                    Console.WriteLine("You don't have more attempts.\nContact with a tecnical support.");
                    RunningApp = false;
                }
            }
        }

        static void RandomGuess()
        {
            Random rand = new Random();
            int GuessNumber;
            int Attempts = 5;
            bool RunningApp = true;

            GuessNumber = rand.Next(10, 100);
            int LessNumber = rand.Next(0, 10);
            int MoreNumber = rand.Next(0, 10);
            Console.Write("Guess number in the range between " + (GuessNumber - LessNumber) + " and " + (GuessNumber + MoreNumber));
            while (RunningApp)
            {
                if (Attempts > 0)
                {
                    Console.WriteLine("\nYou have " + Attempts + " attempts to guess the number.");
                    Console.Write("The number is: ");

                    if (GuessNumber == Convert.ToInt32(Console.ReadLine()))
                    {
                        Console.WriteLine("You right, it was: " + GuessNumber);
                        RunningApp = false;
                    }
                    else
                    {
                        Console.WriteLine("You wrong. Try again!");
                        Attempts -= 1;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You have no attempts! Try again later.");
                    RunningApp = false;
                }
            }
        }
    }
}
