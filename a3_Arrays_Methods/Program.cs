using System;

namespace a3_Arrays_Methods
{
    class ArraysAndMethods
    {

        static void Main(string[] args)
        {
            //TwoDArray();
            //MaxElement();
            //GetLocalMaximum();
            DynamicArray();

        }

        static void TwoDArray()
        {
            //Дан двумерный массив.
            //Вычислить сумму второй строки и произведение первого столбца.
            //Вывести исходную матрицу и результаты вычислений.

            int[,] TwoDArray = {
                {10, 30, 45, 20},
                {30, 10, 25, 42},
                {20, 90, 32, 45}
            };

            int[] SumOfRow = new int[TwoDArray.GetLength(1)];
            int[] FirstCol = new int[TwoDArray.GetLength(0)];
            int MultipleEachElementInFirstCol = 1;

            for (int i = 0; i < TwoDArray.GetLength(0); i++)
            {
                FirstCol[i] = TwoDArray[i, 0];
                for (int j = 0; j < TwoDArray.GetLength(1); j++)
                {
                    Console.Write(TwoDArray[i, j] + " ");
                    if (i < 1)
                    {
                        SumOfRow[j] = TwoDArray[1, j];
                    }
                }
                Console.Write("\n");
            }

            foreach (int item in FirstCol)
            {
                MultipleEachElementInFirstCol *= item;
            }

            Console.WriteLine("\nSum of second row is: " + SumOfRow.Sum());
            Console.WriteLine("Multiple of first column is: " + MultipleEachElementInFirstCol);

        }

        static void MaxElement()
        {
            //Задача:
            //Найти наибольший элемент матрицы A(10, 10) и записать ноль в ту ячейку,
            //где он находится. Вывести наибольший элемент, исходную и полученную матрицу.
            //Массив под измененную версию не нужен.

            int[,] Array = new int[10, 10];
            int MaxElement = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Random rand = new Random();
                    Array[i, j] = rand.Next(100, 1000);
                    Console.Write(Array[i, j] + " ");

                    if (MaxElement < Array[i, j])
                    {
                        MaxElement = Array[i, j];
                    }
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nNew array.");
            for (int i = 0; i < Array.GetLength(0); i++)
            {
<<<<<<< Updated upstream
                for (int j = 0;  j < Array.GetLength(1);  j++)
=======
                for (int j = 0; j < Array.GetLength(1); j++)
>>>>>>> Stashed changes
                {
                    if (Array[i, j] != MaxElement)
                    {
                        Console.Write(Array[i, j] + " ");
                    }
                    else if (Array[i, j] == MaxElement)
                    {
                        Array[i, j] = 0;
                        Console.Write(Array[i, j] + " ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n" + MaxElement + " max number.");
        }

        static void GetLocalMaximum()
        {
            //Дан массив целых чисел из 30 элементов.
            //Найдите все локальные максимумы и вывести их.
            //(Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)
            //Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.
            //Программа должна работать с массивом любого размера.
            //Массив всех локальных максимумов не нужен.

            int[] Array = new int[30];
            Random rand = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(0, 10);
                Console.Write(Array[i] + " ");
            }

            Console.WriteLine("\n");
            for (int i = 0; i < Array.Length; i++)
            {
                //Console.WriteLine(Array.Length);
                if (Array.Length > 1)
                {
                    if (i == 0 && Array[i] > Array[(i + 1)])
                    {
                        Console.Write(Array[i] + " ");
                    }
                    else if (Array.Length != (i + 1) && i > 0 && Array[i] > Array[(i - 1)] && Array[i] > Array[(i + 1)])
                    {
                        Console.Write(Array[i] + " ");
                    }
                    else if (Array.Length == (i + 1) && Array[i] > Array[(i - 1)])
                    {
                        Console.Write(Array[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Won't be defined. The list contains only one element.");
                }
            }
        }

        static void DynamicArray()
        {
            //Пользователь вводит числа, и программа их запоминает.
            //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
            //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
            //Программа должна работать на основе расширения массива.
            //Внимание, нельзя использовать List<T> и Array.Resize
            bool RunningApp = false;
            int[] UserNumbers = new int[1];

            while (RunningApp)
            {
                Console.Write("Set numbers Or input 'Sum' Or 'Exit: ");
                //Console.WriteLine(Console.ReadLine().GetType().isint);

            }
        }
    }
}