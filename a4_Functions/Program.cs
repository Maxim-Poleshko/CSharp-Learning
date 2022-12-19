using System;

namespace a3_Arrays_Methods
{
    class ArraysAndMethods
    {
        //Будет 2 массива: 1) фио 2) должность.
        //Описать функцию заполнения массивов – досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.
        //Функция расширяет уже имеющийся массив на 1 и дописывает туда новое значение.

        //Программа должна быть с меню, которое содержит пункты:
        //1) добавить досье
        //2) вывести все досье(в одну строку через “-” фио и должность с порядковым номером в начале)
        //3) удалить досье
        //4) поиск по фамилии
        //5) выход
        static void Main(string[] args)
        {
            //Досьє
            string[] names = new string[0];
            string[] jobTitle = new string[0];
            bool appRunning = true;

            while (appRunning)
            {
                Console.Write("-=-App Menu-=-\n1.Add new profile\n2.Display all profiles\n3.Delete profile\n4.Find profile by name\n5.Exit\n\nChoose option:");

                int menuChoosing = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (menuChoosing == 1)
                {
                    Console.Write("Set name: ");
                    string employeeName = Console.ReadLine();
                    Console.Write("Set your job title: ");
                    string employeeJobPosition = Console.ReadLine();

                    AddProfile(ref names, employeeName, ref jobTitle, employeeJobPosition);
                }

                else if (menuChoosing == 2)
                {
                    DisplayAll(ref names, ref jobTitle);
                }

                else if (menuChoosing == 3)
                {
                    if (names.Length > 0)
                    {
                        Console.Write("Set name for delete portfolio by the name: ");
                        string deleteByName = Console.ReadLine();
                        DeletePortfolioByName(deleteByName, ref names, ref jobTitle);
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine("The list of employee is empty.");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }

                else if (menuChoosing == 4)
                {
                    if (names.Length > 0) { 
                    Console.Write("Set name that you want to find: ");
                    string searchingName = Console.ReadLine();
                    SearchByName(searchingName, ref names, ref jobTitle);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The list of employee is empty.");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }

                else if (menuChoosing == 5)
                {
                    Console.WriteLine("App was stopped");
                    appRunning = false;

                }
            }


            static void AddProfile(ref string[] arrNames, string name, ref string[] arrJobTitle, string employeeJobPosition)
            {
                string[] tempNames = new string[arrNames.Length + 1];
                string[] tempJobTitles = new string[arrJobTitle.Length + 1];

                for (int i = 0; i < arrNames.Length; i++)
                {
                    tempNames[i] = arrNames[i];
                    tempJobTitles[i] = arrJobTitle[i];

                }
                tempNames[^1] = name;
                arrNames = tempNames;

                tempJobTitles[^1] = employeeJobPosition;
                arrJobTitle = tempJobTitles;

            }


            static void DisplayAll(ref string[] arrNames, ref string[] arrJobTitle)
            {
                if (arrNames.Length == arrJobTitle.Length)
                {
                    Console.WriteLine("Employees list: ");
                    for (int i = 0; i < arrJobTitle.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " " + arrNames[i] + " " + arrJobTitle[i]);

                    }
                }
                else
                {
                    Console.WriteLine("Something wrong, Lenght of arrays are different");
                    Console.ReadKey();
                }
                Console.ReadKey();
                Console.Clear();

            }


            static void SearchByName(string nameToFind, ref string[] name, ref string[] jobTitle)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (nameToFind.ToLower() == name[i].ToLower())
                    {
                        Console.WriteLine("Found by search result '"+ nameToFind + "': " + (i + 1) + " - " + name[i] + " - " + jobTitle[i]);

                    }
                }
                Console.ReadKey();
                Console.Clear();

            }


            static void DeletePortfolioByName(string nameToFind, ref string[] name, ref string[] jobTitle)
            {
                int indexToDelete = 0;
                bool shouldBeDeleted = false;
                  
                for (int i = 0; i < name.Length; i++)
                {
                    if (nameToFind.ToLower() == name[i].ToLower())
                    {
                        indexToDelete = i;
                        shouldBeDeleted = true;
                    }
                }

                if (shouldBeDeleted) {
                    for (int i = indexToDelete; i < name.Length - 1; i++)
                    {
                        name[i] = name[i + 1];
                        jobTitle[i] = jobTitle[i + 1];
                    }

                    string[] tempNames = new string[name.Length - 1];
                    Array.Copy(name, tempNames, name.Length - 1);

                    string[] tempJobTitles = new string[jobTitle.Length - 1];
                    Array.Copy(jobTitle, tempJobTitles, jobTitle.Length - 1);

                    name = tempNames;
                    jobTitle = tempJobTitles;

                }

                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}