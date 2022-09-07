SelectTasks();



/// <summary>
/// Метод, для выбора задачи
/// </summary>
static void SelectTasks()
{
    Console.WriteLine("Задача номер 2");
    Console.WriteLine("Задача номер 4");
    Console.WriteLine("Задача номер 6");
    Console.WriteLine("Задача номер 8");
    Console.Write("Выберите номер задач, 2-4-6-8:");
    int numb = Convert.ToInt32(Console.ReadLine());
    switch (numb)
    {
        case 2:
            Task2();
            break;
        case 4:
            Task4();
            break;
        case 6:
            Task6();
            break;
        case 8:
            Task8();
            break;
        default:
            Console.WriteLine("Вы ввели неправильный номер задач!");
            break;
    }
}


/// <summary>
/// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/// </summary>
static void Task2()
{
    Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт," +
        " какое число большее, а какое меньшее.");
    Console.WriteLine();

    Console.Write("Введите число, a:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число, b:");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
        Console.WriteLine($"максимальный число:{a}, минимальный число:{b}");
    else if (a < b)
        Console.WriteLine($"максимальный число:{b}, минимальный число:{a}");
    else
        Console.WriteLine("Оба числа одинаково");
}


/// <summary>
/// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/// </summary>
static void Task4()
{
    Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа" +
        " и выдаёт максимальное из этих чисел.");
    Console.WriteLine();

    Console.Write("Введите первое число:");
    int numb1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число:");
    int numb2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третий число:");
    int numb3 = Convert.ToInt32(Console.ReadLine());

    if (numb1 > numb2 && numb1 > numb3)
        Console.WriteLine($"Максммальный число из трех чисел равен:{numb1}");
    else if (numb2 > numb1 && numb2 > numb3)
        Console.WriteLine($"Максммальный число из трех чисел равен:{numb2}");
    else if (numb3 > numb1 && numb3 > numb2)
        Console.WriteLine($"Максммальный число из трех чисел равен:{numb3}");
    else
        Console.WriteLine($"три числа равны");
}



/// <summary>
/// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/// </summary>
static void Task6()
{
    Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт," +
        " является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine();

    Console.Write("Введите число:");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb % 2 == 0)
        Console.WriteLine($"Число {numb}, четное");
    else
        Console.WriteLine($"Число {numb}, нечетное");
}


/// <summary>
/// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/// </summary>
static void Task8()
{
    Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N)," +
        " а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine();

    Console.Write("Введите число:");
    int N = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= N; i += 2)
        Console.Write(i + " ");
    Console.WriteLine();
}
