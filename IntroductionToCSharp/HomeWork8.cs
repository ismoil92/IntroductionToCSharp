using System.Globalization;

namespace IntroductionToCSharp;

public class HomeWork8
{

    /// <summary>
    /// Метод, для выбора задач
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 54");
        Console.WriteLine("Задача номер 56");
        Console.WriteLine("Задача номер 58");
        Console.WriteLine("Задача номер 60");
        Console.WriteLine("Задача номер 62");

        Console.Write("Выберите номер задач:");
        int numberTask = ConsoleReadLineInt();

        switch(numberTask)
        {
            case 54:
                Task54();
                break;
            case 56:
                Task56();
                break;
            case 58:
                Task58();
                break;
            case 60:
                Task60();
                break;
            case 62:
                Task62();
                break;
            default:
                Console.WriteLine("Вы ввели неправильный номер задач");
                break;
        }
    }


    /// <summary>
    /// Задача 54: Задайте двумерный массив. Напишите программу,
    /// которая упорядочит по убыванию элементы каждой строки двумерного массива.
    /// </summary>
    private static void Task54()
    {
        Console.WriteLine("\nЗадача 54: Задайте двумерный массив. Напишите программу," +
            " которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine();

        (int rows, int columns) = ReadLineRowsAndColumns();

        int[,] array = CreateArray(rows, columns);

        PrintArrays(array);
        Console.WriteLine();

        int[,] sortColumnsDesc =  SortDescending(array);

        PrintArrays(sortColumnsDesc);
    }


    /// <summary>
    /// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
    /// которая будет находить строку с наименьшей суммой элементов.
    /// </summary>
    private static void Task56()
    {
        Console.WriteLine("\nЗадача 56: Задайте прямоугольный двумерный массив. Напишите программу," +
            " которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine();

        (int rows, int columns) = ReadLineRowsAndColumns();

        int[,] array = CreateArray(rows, columns);

        PrintArrays(array);

        Console.WriteLine();

        int numberColumns = MinSumColumnsElements(array);

        Console.WriteLine($"Сумма элементов минимального номер строки:{numberColumns}");
    }


    /// <summary>
    /// Задача 58: Задайте две матрицы. Напишите программу,
    /// которая будет находить произведение двух матриц.
    /// </summary>
    private static void Task58()
    {
        Console.WriteLine("\nЗадача 58: Задайте две матрицы. Напишите программу," +
            " которая будет находить произведение двух матриц.");
        Console.WriteLine();

        Console.WriteLine("Введите размер первого матрицы");
        (int rows1, int columns1) = ReadLineRowsAndColumns();
        Console.WriteLine("Введите размер втрого матрицы");
        (int rows2, int columns2) = ReadLineRowsAndColumns();


        int[,] matrix1 = CreateArray(rows1, columns1);

        int[,] matrix2 = CreateArray(rows2, columns2);

        Console.WriteLine("Элементы первого массива");

        PrintArrays(matrix1);

        Console.WriteLine("Элементы второго массива");
        PrintArrays(matrix2);

        int[,] newMatrix = MultiplyMatrix(matrix1, matrix2);

        Console.WriteLine("Элементы нового массива");
        PrintArrays(newMatrix);

    }


    /// <summary>
    /// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    /// Напишите программу, которая будет построчно выводить массив,
    /// добавляя индексы каждого элемента.
    /// Массив размером 2 x 2 x 2
    /// </summary>
    private static void Task60()
    {
        Console.WriteLine("\nЗадача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел." +
            " Напишите программу, которая будет построчно выводить массив," +
            " добавляя индексы каждого элемента.\r\nМассив размером 2 x 2 x 2");
        Console.WriteLine();

        int[,,] array3D = Array3D(2, 2, 2);
        Console.WriteLine();

        PrintArray3D(array3D);
    }

    /// <summary>
    /// * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
    /// </summary>
    private static void Task62()
    {
        Console.WriteLine("\n* Задача 62. Напишите программу," +
            " которая заполнит спирально массив 4 на 4. ");

        int[,] spirallyArray = FillArraySpirally(4);

        PrintArrays(spirallyArray);
    }

    /// <summary>
    /// Метод, для ввода размер массива количество строки и столбца
    /// </summary>
    /// <returns>возвращает кортежи, размер строк и стобца</returns>
    private static (int rows, int columns) ReadLineRowsAndColumns()
    {
        Console.Write("Введите размер строки:");
        int rows = ConsoleReadLineInt();
        Console.Write("Введите размер столбца:");
        int columns = ConsoleReadLineInt();

        return(rows, columns);
    }


    #region Task54

    /// <summary>
    /// Метод, для создание двумерного массива
    /// </summary>
    /// <param name="rows">размер строки</param>
    /// <param name="columns">размер столбца</param>
    /// <returns>возвращает двумерный массив</returns>
    private static int[,] CreateArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];

        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
                array[i, j] = Random.Shared.Next(0, 101);
        }

        return array;
    }

    /// <summary>
    /// Метод, для сортировки двумерного массива
    /// </summary>
    /// <param name="array">двумерный массив</param>
    /// <returns>возвращает сортированный двумерный массив</returns>
    private static int[,] SortDescending(int[,] array)
    {
        int[] rows = new int[array.GetLength(1)];
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                rows[j] = array[i, j];
            }

            rows = SortDescending(rows);

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rows[j];
            }
        }


        return array;
    }

    /// <summary>
    /// Перегруженный метод SortDescending(), для сортировки одномерного массива
    /// </summary>
    /// <param name="array">одномерный массив</param>
    /// <returns>возвращает сортированный одномерный массив</returns>
    private static int[] SortDescending(int[] array)
    {
        for(int i=0;i<array.Length-1;i++)
        {
            for(int j=i+1;j<array.Length;j++)
            {
                if (array[i] < array[j])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        return array;
    }

    /// <summary>
    /// Метод, для печатает двумерный массив
    /// </summary>
    /// <param name="array">двумерный массив</param>
    private static void PrintArrays(int[,] array)
    {
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
    #endregion

    #region Task56
    /// <summary>
    /// Метод, для нахождение номер строки, где сумма элементов в каждой строке  двумерного массива будет наименьшим 
    /// </summary>
    /// <param name="array">двумерный массив</param>
    /// <returns>возвращает номер строки</returns>
    private static int MinSumColumnsElements(int[,] array)
    {
        int sum = 0, minSum = 0, indexColumn = 0;
        for(int j=0;j<array.GetLength(1);j++)
        {
            sum += array[0, j];
        }
        minSum = sum;

        sum = 0;
        for(int i=1;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                sum+=array[i, j];
            }
            if(minSum>sum)
            {
                minSum = sum;
                indexColumn = i;
            }
            sum = 0;
        }


        return indexColumn + 1;
    }
    #endregion

    #region Task58
    /// <summary>
    /// Метод, для умножение элементов двух матриц
    /// </summary>
    /// <param name="matrix1">первая матрица</param>
    /// <param name="matrix2">вторая матрица</param>
    /// <returns>возвращает новую матрицу</returns>
    private static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0), columns = matrix2.GetLength(1), sum=0, J=0;
        int[,] newMatrix = new int[rows, columns];

        for(int i=0;i<newMatrix.GetLength(0);i++)
        {
            while (columns > J)
            {
                for (int j = 0, k = 0, m = 0; j < newMatrix.GetLength(1) && k < matrix1.GetLength(1) && m < matrix2.GetLength(0); j++, k++, m++)
                {
                    sum += matrix1[i, k] * matrix2[m, J];
                }
                newMatrix[i, J] = sum;
                sum = 0;
                J++;
            }
            J = 0;
        }
        return newMatrix;
    }
    #endregion

    #region Task60
    /// <summary>
    /// Метод, для чтение с консоли тип string и конвертировать в тип int
    /// </summary>
    private static int ConsoleReadLineInt()
    {
        string readLine = Console.ReadLine()!;

        int intParse = Convert.ToInt32(readLine);

        return intParse;
    }

    private static int[,,] Array3D (int I, int J, int K)
    {
        int[,,] array3D = new int[I, J, K];

        bool ischecking = false;

        for(int i=0;i<array3D.GetLength(0);i++)
            for(int j=0;j<array3D.GetLength(1);j++)
                for(int k=0;k<array3D.GetLength(2);k++)
                {
                    while(!ischecking)
                    {
                        Console.Write($"array3D[{i}, {j}, {k}]:");
                        int input = ConsoleReadLineInt();
                        if (CheckingElementToRepetition(array3D, input))
                        {
                            array3D[i, j, k] = input;
                            ischecking = true;
                        }
                        else
                            Console.WriteLine("Введенный число либо не двухзначное число," +
                                "либо повторяющая число. Повторите еще раз!");
                    }
                    ischecking = false;
                }


        return array3D;
    }

    /// <summary>
    /// Метод, для печати трехмерного массива
    /// </summary>
    /// <param name="array3D">трехмерный массив</param>
    private static void PrintArray3D(int[,,] array3D)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    Console.Write($"array[{i}, {j}, {k}]:{array3D[i, j, k]}\t");
                }
                Console.WriteLine();
            }
    }

    /// <summary>
    /// Метод, для проверки элемента массива на двухзачное число и повторяющая
    /// </summary>
    /// <param name="array3D">трехмерный массив</param>
    /// <param name="input">элемент для проверки</param>
    /// <returns>возвращает true, если элемент введён правильно, и false, не правильно введён элемент</returns>
    private static bool CheckingElementToRepetition(int[,,] array3D, int input)
    {
        if(input>=10 && input<=99)
        {
            for(int i=0;i<array3D.GetLength(0);i++)
                for(int j=0;j<array3D.GetLength(1);j++)
                    for(int k=0;k<array3D.GetLength(2);k++)
                    {
                        if (array3D[i, j, k] == input)
                            return false;
                    }
            return true;
        }
        return false;
    }

    #endregion

    #region Task62
    /// <summary>
    /// Метод, для заполнение массива спирально
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <returns>возвращает массив</returns>
    private static int[,] FillArraySpirally(int size)
    {
        int temp = 1, j = 0, i = 1;
        int[,] spiralArray = new int[size, size];

        for (; j < spiralArray.GetLength(1); j++)
        {
            spiralArray[0, j] = temp;
            temp++;
        }
        j--; // j=3

        for (; i < spiralArray.GetLength(0); i++)
        {
            spiralArray[i, j] = temp;
            temp++;
        }
        i--; //i=3
        j--; //j=2

        for (; j >= 0; j--)
        {
            spiralArray[i, j] = temp;
            temp++;
        }
        j++; //j=0
        i--; //i=2
        for(;i>=1;i--)
        {
            spiralArray[i, j] = temp;
            temp++;
        }
        i++; // i=1
        j++; // j=1

        for (; j < spiralArray.GetLength(1) - 1; j++)
        {
            spiralArray[i, j] = temp;
            temp++;
        }

        i++; // i=2
        j--; // j=2

        for (; i < spiralArray.GetLength(0) - 1; i++)
        {
            spiralArray[i, j] = temp;
            temp++;
        }
        i--; //i=2
        j--; //j=1

        for (; j > 0; j--)
        {
            spiralArray[i, j] = temp;
        }
        return spiralArray;
    }
    #endregion
}