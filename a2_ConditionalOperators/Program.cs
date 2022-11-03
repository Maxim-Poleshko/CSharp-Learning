using System;

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
            currencyConverter();
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
    }
}
