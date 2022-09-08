namespace IntroductionToCSharp;

public class HomeWork2
{
    /// <summary>
    /// Метод, для выбора задачи
    /// </summary>
    public static void SelectTasks()
    {
        Console.WriteLine("Задача номер 10");
        Console.WriteLine("Задача номер 13");
        Console.WriteLine("Задача номер 15");
        Console.Write("Выберите номер задачи:");
        int numb= Convert.ToInt32(Console.ReadLine());
        switch(numb)
        {
            case 10:
                Task10();
                break;
            case 13:
                Task13();
                break;
            case 15:
                Task15();
                break;
            default:
                Console.WriteLine("Неправильный номер задач");
                break;
        }
    }


    /// <summary>
    /// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    /// </summary>
    private static void Task10()
    {
        Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число" +
            " и на выходе показывает вторую цифру этого числа.");
        Console.WriteLine();

        Console.Write("Введите трёхзначную цифру:");
        int number = Convert.ToInt32(Console.ReadLine());
        while (!(100 <= number && number <= 999))
        {
            Console.Write("Вы ввели не трехзначное число, повторите ещё раз:");
            number = Convert.ToInt32(Console.ReadLine());
        }
        int result = FindNumber(number);
        Console.WriteLine($"вторая цифра, из трёхзначного числа, равно:{result}");
    }


    /// <summary>
    /// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    /// </summary>
    private static void Task13()
    {
        Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа" +
            " или сообщает, что третьей цифры нет.");
        Console.WriteLine();

        Console.Write("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = FindNumberPart2(number);
        if (result > 0)
            Console.WriteLine($"Третья цифра:{result}");
        else
            Console.WriteLine("Третья цифра не существует");
    }


    /// <summary>
    /// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    /// </summary>
    private static void Task15()
    {
        Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру," +
            " обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine();
        Console.Write("Введите день недели:");
        int numberDay= Convert.ToInt32(Console.ReadLine());
        string result = FindWeekDayOff(numberDay);
        Console.WriteLine(result);
    }


    /// <summary>
    /// Метод, для возврата вторую цифру из трёхзначного числа
    /// </summary>
    /// <param name="number">трёхзначное число</param>
    /// <returns>возвращает вторую цифру</returns>
    private static int FindNumber(int number)
    {
        int numb = 0, index = 1;
        while (number > 0)
        {
            numb = number % 10;
            if (index == 2)
            {
                return numb;
            }
            number /= 10;
            index++;
        }
        return -1;
    }


    /// <summary>
    /// Метод, для нахождение третую цифру или сообщить что третья цифра не существует
    /// </summary>
    /// <param name="number">число</param>
    /// <returns>возвращает третую цифру, если найдено, или -1 если не найдена</returns>
   private static int FindNumberPart2(int number)
    {
        int result = 0, i = 0;
        if(number>=100)
        {
            int numb = number;
            while(numb>0)
            {
                numb /= 10;
                i++;
            }
            int count = i - 3;
            i = 0;
            while(number>0)
            {
                result = number % 10;
                if(i == count)
                {
                    return result;
                }
                number /= 10;
                i++;
            }
        }
        return -1;
    }


    /// <summary>
    /// Метод, для определение выходного день недели
    /// </summary>
    /// <param name="numberDay">номер недели</param>
    /// <returns>Возвращает строку выходной день или рабочий день или нет такого день недели</returns>
    private static string FindWeekDayOff(int numberDay)
    {
        if (numberDay >= 6 && numberDay <= 7)
            return "Выходной день недели";
        else if (numberDay >= 1 && numberDay <= 5)
            return "Рабочий день недели";
        else
            return "Нет такого день недели";
    }
}