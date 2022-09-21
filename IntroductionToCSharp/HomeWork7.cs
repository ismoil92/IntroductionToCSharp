using System.Diagnostics.CodeAnalysis;

namespace IntroductionToCSharp;

public class HomeWork7
{
    /// <summary>
    /// Метод, для выбора задач
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 47");
        Console.WriteLine("Задача номер 50");
        Console.WriteLine("Задача номер 52");
        Console.Write("Выберите номер задач:");
        int selectTask = Convert.ToInt32(Console.ReadLine());

        switch(selectTask)
        {
            case 47:
                Task47();
                break;
            case 50:
                Task50();
                break;
            case 52:
                Task52();
                break;
            default:
                Console.WriteLine("Вы выбрали неверный номер задачи");
                break;
        }
    }



    /// <summary>
    /// Задача 47. Задайте двумерный массив размером m×n,
    /// заполненный случайными вещественными числами.
    /// </summary>
    private static void Task47()
    {
        Console.WriteLine("\nЗадача 47. Задайте двумерный массив размером m×n," +
            " заполненный случайными вещественными числами.");
        Console.WriteLine();

        Console.Write("Введите размер строки:");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размер столбца:");
        int N = Convert.ToInt32(Console.ReadLine());

        double[,] doubleArray = CreateDoubleArray(M, N);

        PrintDoubleArray(doubleArray);
    }


    /// <summary>
    /// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    /// и возвращает значение этого элемента или же указание, что такого элемента нет.
    /// </summary>
    private static void Task50()
    {
        Console.WriteLine("\nЗадача 50. Напишите программу," +
            " которая на вход принимает позиции элемента в двумерном массиве," +
            " и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine();

        Console.Write("Введите размер строки:");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размер столбца:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите индекс массива:");

        string input = Console.ReadLine()!;

        int[,] doubleArray = CreateDoubleArrayTypeInt(M, N);

        PrintDoubleArrayTypeInt(doubleArray);
        Console.WriteLine();

        int findElementArray = FindDoubleArrayElementsByIndex(doubleArray, input);

        string[] inputs = input.Split(", ");
        int rowIndex = Convert.ToInt32(inputs[0]);
        int columnIndex = Convert.ToInt32(inputs[1]);

        if (findElementArray >= 0)
            Console.WriteLine($"В двумерном массиве, индекс строки:{rowIndex}, " +
                $"индекс столбца:{columnIndex}, элемент равен:{findElementArray}");
        else
            Console.WriteLine("Такого элемента нету");
    }


    /// <summary>
    /// Задача 52. Задайте двумерный массив из целых чисел.
    /// Найдите среднее арифметическое элементов в каждом столбце.
    /// </summary>
    private static void Task52()
    {
        Console.WriteLine("\nЗадача 52. Задайте двумерный массив из целых чисел." +
            " Найдите среднее арифметическое элементов в каждом столбце.\n");

        Console.Write("Введите размер строки:");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размер столбца:");
        int N = Convert.ToInt32(Console.ReadLine());

        int[,] doubleArray = CreateDoubleArrayTypeInt(M, N);

        PrintDoubleArrayTypeInt(doubleArray);

        double[] middleArifmethics = MiddleArifmethicsColumn(doubleArray);

        Console.WriteLine();
        Console.WriteLine();
        PrintMiddleArifmethics(middleArifmethics);

    }



    /// <summary>
    /// Метод, для создание двумерного массива вещественного типа
    /// </summary>
    /// <param name="m">размер строки</param>
    /// <param name="n">размер столбцов</param>
    /// <returns>возвращает двумерный массив вещественного типа</returns>
    private static double[,] CreateDoubleArray(int m, int n)
    {
        double[,] doubleArray = new double[m, n];

        for(int i=0;i<doubleArray.GetLength(0);i++)
        {
            for(int j=0;j<doubleArray.GetLength(1);j++)
                doubleArray[i, j] = Random.Shared.NextDouble() * 100;
        }

        return doubleArray;
    }

    /// <summary>
    /// Метод, для вывода двумерный массив вещественного типа
    /// </summary>
    /// <param name="doubleArray">массив вещественного типа</param>
    private static void PrintDoubleArray(double[,] doubleArray)
    {
        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int j = 0; j < doubleArray.GetLength(1); j++)
            {
                Console.Write(String.Format("{0:0.##}", doubleArray[i,j])+"\t");
            }
            Console.WriteLine();
        }
    }


    /// <summary>
    /// Метод, для создание двумерного массива целого типа
    /// </summary>
    /// <param name="m">размер строки</param>
    /// <param name="n">размер столбцов</param>
    /// <returns>возвращает двумерный массив целого типа</returns>
    private static int[,] CreateDoubleArrayTypeInt(int m, int n)
    {
        int[,] doubleArray = new int[m, n];

        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int j = 0; j < doubleArray.GetLength(1); j++)
                doubleArray[i, j] = Random.Shared.Next(0, 101);
        }

        return doubleArray;
    }

    /// <summary>
    /// Метод, для вывода двумерный массив целого типа
    /// </summary>
    /// <param name="doubleArray">массив целого типа</param>
    private static void PrintDoubleArrayTypeInt(int[,] doubleArray)
    {
        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int j = 0; j < doubleArray.GetLength(1); j++)
            {
                Console.Write(doubleArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }


    /// <summary>
    /// Метод, для нахождение элемента массива по индексу
    /// </summary>
    /// <param name="doubleArrays">массив</param>
    /// <param name="input">индекс элемента массива</param>
    /// <returns>возвращает элемент массива по индексу, если существует, иначе возвращает -1</returns>
    private static int FindDoubleArrayElementsByIndex(int[,] doubleArrays, string input)
    {
        string[] inputs = input.Split(", ");

        int rowIndex = Convert.ToInt32(inputs[0]);
        int columnIndex = Convert.ToInt32(inputs[1]);

        if (rowIndex <= doubleArrays.GetLength(0) && columnIndex <= doubleArrays.GetLength(1))
        {
            for (int i = 0; i < doubleArrays.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArrays.GetLength(1); j++)
                {
                    if (doubleArrays[i, j] == doubleArrays[rowIndex, columnIndex])
                    {
                        return doubleArrays[i, j];
                    }
                }
            }
        }

        return -1;
    }


    /// <summary>
    /// Метод, для нахождение в двумерном массиве средный арифметический для каждого столбца 
    /// </summary>
    /// <param name="doubleArray">двумерный массив</param>
    /// <returns>возвращает одномерный массив средный арифметический для каждого столбца</returns>
    private static double[] MiddleArifmethicsColumn(int[,] doubleArray)
    {
        double[] middleArifmethics = new double[doubleArray.GetLength(1)];

        for(int i=0;i< doubleArray.GetLength(1);i++)
        {
            int sum = 0;
            for (int j=0;j<doubleArray.GetLength(0);j++)
            {
                sum += doubleArray[j, i];
            }
            middleArifmethics[i] = sum /(double) doubleArray.GetLength(0);
        }


        return middleArifmethics;
    }


    /// <summary>
    /// Метод, для печати одномерного массива т.е. средный арифметический двумерного массива для каждого столбца 
    /// </summary>
    /// <param name="array">однмерный массив</param>
    private static void PrintMiddleArifmethics(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + "\t");
        Console.WriteLine();
    }
}