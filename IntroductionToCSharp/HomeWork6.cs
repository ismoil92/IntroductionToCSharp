namespace IntroductionToCSharp;

public class HomeWork6
{

    /// <summary>
    /// Метод, для выбора номер задач
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 41");
        Console.WriteLine("Задача номер 43");
        Console.Write("Выберите номер задачи:");
        int numbTask = Convert.ToInt32(Console.ReadLine());
        switch(numbTask)
        {
            case 41:
                Task41();
                break;
            case 43:
                Task43();
                break;
            default:
                Console.WriteLine("Вы ввели неправльный номер задач");
                break;
        }
    }


    /// <summary>
    /// Задача 41: Пользователь вводит с клавиатуры M чисел.
    /// Посчитайте, сколько чисел больше 0 ввёл пользователь.
    /// </summary>
    private static void Task41()
    {
        Console.WriteLine("\nЗадача 41: Пользователь вводит с клавиатуры M чисел." +
            " Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine();

        Console.Write("Введите количество чисел:");
        int M = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[M];
        for (int i = 0; i < array.Length; i++)
            array[i] = Convert.ToInt32(Console.ReadLine());

        int count = CountPositiveNumber(array);
        Console.WriteLine($"Количество положительных чисел:{count}");
    }

    /// <summary>
    /// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
    /// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
    /// значения b1, k1, b2 и k2 задаются пользователем.
    /// </summary>
    private static void Task43()
    {
        Console.WriteLine("\nЗадача 43: Напишите программу, которая найдёт точку пересечения двух прямых," +
            " заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; " +
            "значения b1, k1, b2 и k2 задаются пользователем.");
        Console.WriteLine("");
        Console.Write("b1:");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("b2:");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("k1:");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("k2:");
        double k2 = Convert.ToDouble(Console.ReadLine());
        (double x, double y) = PointCrossing(k1, k2, b1, b2);
        Console.WriteLine($"X:{x}, Y:{y}");
    }


    /// <summary>
    /// Метод, для нахождение количество чисел ввода больше нуля
    /// </summary>
    /// <param name="arrays">массив чисел</param>
    /// <returns>возвращает количество положительных чисел</returns>
    private static int CountPositiveNumber(int[] arrays)
    {
        int count = 0;

        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] > 0)
                count++;
        }


        return count;
    }


    /// <summary>
    /// Метод, для нахождение точку пересечение двух прямых линии
    /// </summary>
    /// <param name="k1">первый параметр первого прямого</param>
    /// <param name="k2">первый параметр второго прямого</param>
    /// <param name="b1">второй параметр первого прямого</param>
    /// <param name="b2">второй параметр втрого прямого</param>
    /// <returns>возвращают координаты точки х и у</returns>
    private static (double x, double y) PointCrossing(double k1, double k2, double b1, double b2)
    {
        double x = 0, y = 0;

        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        
        
        return (x, y);
    }
}