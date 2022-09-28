namespace IntroductionToCSharp;

public class HomeWork9
{

    /// <summary>
    /// Метод, для выбора номер задач
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 66");
        Console.WriteLine("Задача номер 68");

        Console.Write("Выберите номер задачи:");
        int numberTask = Convert.ToInt32(Console.ReadLine());

        switch(numberTask)
        {
            case 66:
                Task66();
                break;
            case 68:
                Task68();
                break;
            default:
                Console.WriteLine("Неверный номер задачи");
                break;
        }
    }

    /// <summary>
    /// Задача 66: Задайте значения M и N. Напишите программу,
    /// которая найдёт сумму натуральных элементов в промежутке от M до N.
    /// </summary>
    private static void Task66()
    {
        Console.WriteLine("\nЗадача 66: Задайте значения M и N. Напишите программу," +
            " которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine();

        (int M, int N) = ConsoleReadLineInt();

        int sum = SumRecurcion(M, N);

        Console.WriteLine($"Сумма чисел от {M}, до {N} включительно, равно:{sum}");
    }


    /// <summary>
    /// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    /// Даны два неотрицательных числа m и n.
    /// </summary>
    private static void Task68()
    {
        Console.WriteLine("\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии." +
            " Даны два неотрицательных числа m и n.");
        Console.WriteLine();

        (int M, int N) = ConsoleReadLineInt();

        int ackermanResult = AckermanFunction(M, N);

        Console.WriteLine($"M={M}, N={N}, Result={ackermanResult}");
    }

    /// <summary>
    /// Метод, для нахождение сумму от M до N, с помощью рекурсию
    /// </summary>
    /// <param name="M">начало положение</param>
    /// <param name="N">конечное положение</param>
    /// <returns>возвращает сумму этих чисел</returns>
    private static int SumRecurcion(int M, int N)
    {
        if(M==N)
            return M;
        return M + SumRecurcion(M + 1, N);
    }


    /// <summary>
    /// Метод, для вычисление функция Аккермана
    /// </summary>
    /// <param name="M">первое число</param>
    /// <param name="N">второе число</param>
    /// <returns></returns>
    private static int AckermanFunction(int M, int N)
    {
        if (M == 0)
            return N + 1;
        else if (M > 0 && N == 0)
            return AckermanFunction(M - 1, 1);
        else 
            return AckermanFunction(M-1, AckermanFunction(M, N-1));
    }


    /// <summary>
    /// Метод, для чтение строку и конвертирование в целое число
    /// </summary>
    /// <returns>Возвращает кортежи из двух целых чисел</returns>
    private static (int M, int N) ConsoleReadLineInt()
    {
        Console.Write("Введите число для M:");
        int M = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Введите число для N:");
        int N = Convert.ToInt32(Console.ReadLine()!);

        return (M, N);
    }
}