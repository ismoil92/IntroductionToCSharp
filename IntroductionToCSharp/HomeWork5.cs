namespace IntroductionToCSharp;

public class HomeWork5
{

    /// <summary>
    /// Метод, для выбора задачи
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 34");
        Console.WriteLine("Задача номер 36");
        Console.WriteLine("Задача номер 38");

        Console.Write("Выберите номер задачи:");
        int numbTask = Convert.ToInt32(Console.ReadLine());

        switch(numbTask)
        {
            case 34:
                Task34();
                break;
            case 36:
                Task36();
                break;
            case 38:
                Task38();
                break;
            default:
                Console.WriteLine("Вы ввели неправильный номер.");
                break;
        }
    }


    /// <summary>
    /// Задача 38: Задайте массив вещественных чисел.
    /// Найдите разницу между максимальным и минимальным элементов массива.
    /// </summary>
    private static void Task38()
    {
        Console.WriteLine("\nЗадача 38: Задайте массив вещественных чисел." +
            " Найдите разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine();

        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        double[] arrays = new double[size];

        for(int i=0;i<arrays.Length;i++)
            arrays[i] = Random.Shared.NextDouble()*100;

        for (int i = 0; i < arrays.Length; i++)
            Console.WriteLine(string.Format("{0:#.##}", arrays[i]));

        double diff = DifferenceMaxAndMinElements(arrays);

        Console.WriteLine("\n"+string.Format("{0:#.##}", diff));
    }



    /// <summary>
    /// Задача 36: Задайте одномерный массив, заполненный случайными числами.
    /// Найдите сумму элементов, стоящих на нечётных позициях.
    /// </summary>
    private static void Task36()
    {
        Console.WriteLine("\nЗадача 36: Задайте одномерный массив, заполненный случайными числами." +
            " Найдите сумму элементов, стоящих на нечётных позициях.");
        Console.WriteLine();

        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arrays = new int[size];

        for (int i = 0; i < arrays.Length; i++)
            arrays[i] = Random.Shared.Next(-5, 10);

        Console.WriteLine($"Элементы массива:{string.Join(", ", arrays)}");
        int sum = SumOddIndexElements(arrays);
        Console.WriteLine($"Сумма элементов нечётных индексов:{sum}");
    }


    /// <summary>
    /// Задача 34: Задайте массив заполненный случайными положительными 
    /// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    /// </summary>
    private static void Task34()
    {
        Console.WriteLine("\nЗадача 34: Задайте массив заполненный случайными положительными трёхзначными числами." +
            " Напишите программу, которая покажет количество чётных чисел в массиве.");
        Console.WriteLine();

        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arrays = new int[size];
        for (int i = 0; i < arrays.Length; i++)
            arrays[i] = Random.Shared.Next(100, 1000);
        int count = GetCountEvenNumbers(arrays);

        Console.WriteLine($"Элементы массива:[{string.Join(", ", arrays)}]");

        Console.WriteLine($"Количество четных чисел в массиве:{count}");
    }



    /// <summary>
    /// Метод, для нахождение разница между максимального элемента и минимального элемента
    /// </summary>
    /// <param name="arrays">массив</param>
    /// <returns>возвращает разницу</returns>
    private static double DifferenceMaxAndMinElements(double[] arrays)
    {
        double min = arrays[0], max = arrays[0];

        for(int i = 1; i < arrays.Length; i++)
        {
            if (min > arrays[i])
                min = arrays[i];
            if (max < arrays[i])
                max = arrays[i];
        }
        return max - min;
    }



    /// <summary>
    /// Метод, для суммы элементов массива для нечётных индексов элемента
    /// </summary>
    /// <param name="arrays"></param>
    /// <returns></returns>
    private  static int SumOddIndexElements(int[] arrays)
    {
        int sum = 0;


        for(int i=1;i<arrays.Length;i+=2)
            sum+=arrays[i];


        return sum;
    }

    

    /// <summary>
    /// Метод, для нахождение количество чётных чисел в трехзначном элементы массива
    /// </summary>
    /// <param name="arrays">массив</param>
    /// <returns>возвращает количество чётных чисел</returns>
    private static int GetCountEvenNumbers(int[] arrays)
    {
        int count = 0;

        for(int i=0;i<arrays.Length;i++)
        {
            if (arrays[i] % 2 == 0)
                count++;
        }

        return count;
    }

}