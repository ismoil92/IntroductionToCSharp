namespace IntroductionToCSharp;

public class HomeWork3
{
    /// <summary>
    /// Метод, для выбора задачи
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 19");
        Console.WriteLine("Задача номер 21");
        Console.WriteLine("Задача номер 23");
        Console.Write("Выберите номер задачи:");
        int number = Convert.ToInt32(Console.ReadLine());

        switch(number)
        {
            case 19:
                Task19();
                break;
            case 21:
                Task21();
                break;
            case 23:
                Task23();
                break;
            default:
                Console.WriteLine("Вы ввели неправильный номер задач");
                break;
        }
    }


    /// <summary>
    /// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    /// </summary>
    private static void Task19()
    {
        Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число" +
            " и проверяет, является ли оно палиндромом.");
        Console.WriteLine();

        Console.Write("Введите пятизначное число:");
        int numb= Convert.ToInt32(Console.ReadLine());

        while(!(numb>10000 && numb<=99999))
        {
            Console.Write("Вы ввели не пятизначное число, повторите ещё раз:");
            numb = Convert.ToInt32(Console.ReadLine());
        }
        
        if(FindPalindrom(numb))
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
            Console.WriteLine("Число не является палиндромом");
    }


    /// <summary>
    /// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    /// </summary>
    private static void Task21()
    {
        Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек" +
            " и находит расстояние между ними в 3D пространстве.");
        Console.WriteLine();

        int[] A = new int[3];
        int[] B = new int[3];

        for(int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(1, 10);
            B[i] = Random.Shared.Next(1, 10);
        }
        Console.Write("Координаты точки A:");
        for (int i = 0; i < A.Length; i++)
            Console.Write(A[i] + " ");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Координаты точки B:");
        for (int i = 0; i < B.Length; i++)
            Console.Write(B[i] + " ");
        Console.WriteLine();
        Console.WriteLine();
        double distance = DistanceInSpace(A, B);
        Console.Write($"Расстояние между двух точек в 3д пространстве:");
        Console.WriteLine("{0:0.##}", distance);
    }


    /// <summary>
    /// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    /// </summary>
    private static void Task23()
    {
        Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N)" +
            " и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine();

        Console.Write("Введите число:");
        int N = Convert.ToInt32(Console.ReadLine());
        string result = ListPowCube(N);
        Console.WriteLine(result);
    }


    /// <summary>
    /// Метод, для нахождение палиндрома, т.е. 23432 -> первая цифра равна последный, вторая цифра равна предпоследный
    /// </summary>
    /// <param name="number">число</param>
    /// <returns>возвращает true, если число палиндром, false не палинтром</returns>
    private static bool FindPalindrom(int number)
    {
        if (number >= 10000 && number <= 99999)
        {
            int unit = 0, decimals = 0, hundredth = 0, thousandth = 0, tenThousandth = 0;
            while (number > 0)
            {
                if (tenThousandth == 0)
                    tenThousandth = number % 10;
                else if (thousandth == 0)
                    thousandth = number % 10;
                else if (hundredth == 0)
                    hundredth = number % 10;
                else if (decimals == 0)
                    decimals = number % 10;
                else
                    unit = number;
                number /= 10;
            }
            if (unit == tenThousandth && decimals == thousandth)
                return true;
        }
        return false;
    }


    /// <summary>
    /// Метод, для нахождение расстояние между двух точек в 3д пространстве
    /// </summary>
    /// <param name="A">координаты первой точки</param>
    /// <param name="B">координаты второй точки</param>
    /// <returns>возвращает расстояние между двух точек в 3д пространстве</returns>
    private static double DistanceInSpace(int[] A, int[] B)
    {
        double result = 0, distance = 0;
        for (int i = 0; i < A.Length; i++)
        {
            distance += Math.Pow(B[i] - A[i], 2);
        }
        result = Math.Sqrt(distance);
        return result;
    }


    /// <summary>
    /// Метод, для возведение кубов от 1 до N
    /// </summary>
    /// <param name="N">Число</param>
    /// <returns>возвращает таблицу кубок от 1 до N</returns>
    private static string ListPowCube(int N)
    {
        string result = string.Empty;
        for (int i = 1; i <= N; i++)
        {
            if (i < N)
                result += Math.Pow(i, 3) + ", ";
            else
                result += Math.Pow(i, 3);
        }
        return $"Таблица кубов от 1 до {N} --- "+result;
    }
}