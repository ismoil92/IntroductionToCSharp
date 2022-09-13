namespace IntroductionToCSharp;

public class HomeWork4
{
    /// <summary>
    /// Метод, для выбора задачи
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 25");
        Console.WriteLine("Задача номер 27");
        Console.WriteLine("Задача номер 29");


        Console.Write("Выберите номер задачу:");
        int numbTask = Convert.ToInt32(Console.ReadLine());

        switch(numbTask)
        {
            case 25:
                Task25();
                break;
            case 27:
                Task27();
                break;
            case 29:
                Task29();
                break;
            default:
                Console.WriteLine("Вы ввели неправильный номер задач");
                break;
        }
    }



    /// <summary>
    /// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    /// </summary>
    private static void Task25()
    {
        Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B)" +
            " и возводит число A в натуральную степень B.");
        Console.WriteLine();

        Console.Write("Введите число A:");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите число B:");
        int B = Convert.ToInt32(Console.ReadLine());

        int pow = GetPowNumber(A, B);
        Console.WriteLine($"Результат числа, {A} возведения в степень на {B}, получиться:{pow}");
    }


    /// <summary>
    /// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    /// </summary>
    private static void Task27()
    {
        Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число" +
            " и выдаёт сумму цифр в числе.");
        Console.WriteLine();

        Console.Write("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = GetDigitSum(number);

        Console.WriteLine($"Сумма цифр в числе {number}, равно:{sum}");
    }



    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    /// </summary>
    private static void Task29()
    {
        Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов" +
            " и выводит их на экран.");
        Console.WriteLine();

        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arrays = GetArrays(size);

        Console.WriteLine($"Элементы массива:[{string.Join(", ", arrays)}]");
    }



    /// <summary>
    /// Метод, для возведение в степень число
    /// </summary>
    /// <param name="A">Число</param>
    /// <param name="B">степень числа</param>
    /// <returns>возвращает результат число возведенную в степень</returns>
    private static int GetPowNumber(int A, int B)
    {
        int pow = 1;
        for(int i=0; i < B; i++)
        {
            pow *= A;
        }
        return pow;
    }



    /// <summary>
    /// Метод, для нахождение сумму цифр в числе
    /// </summary>
    /// <param name="number">число</param>
    /// <returns>возвращает сумму цифр в числе</returns>
    private static int GetDigitSum(int number)
    {
        int sum = 0;
        while(number > 0)
        {
            int numb = number % 10;
            sum += numb;
            number /= 10;
        }
        return sum;
    }


    /// <summary>
    /// Метод, для ввода элементов для массива
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <returns>возвращает массив</returns>
    private static int[] GetArrays(int size)
    {
        int[] arrays = new int[size];

        for(int i=0;i<arrays.Length;i++)
        {
            Console.Write($"arrays[{i + 1}]:");
            arrays[i] = Convert.ToInt32(Console.ReadLine());
        }

        return arrays;
    }
}