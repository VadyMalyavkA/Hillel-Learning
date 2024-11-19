while (true)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Введите номер задания (1-4): ");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        int numberOfWork = int.Parse(Console.ReadLine()!);
        Console.ResetColor();

        switch (numberOfWork)
        {
            case 1:
                Work1();
                break;
            case 2:
                Work2();
                break;
            case 3:
                Work3();
                break;
            case 4:
                Work4();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Такого номера задания нет, повторите попытку");
                Console.ResetColor();
                break;
        }
        Console.WriteLine();
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Не верный формат номера задания, повторите попытку\n");
        Console.ResetColor();
    }
}

static void Work1()
{
    Random random = new();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 51);
    }

    Console.WriteLine($"Твой массив:\n{string.Join(", ", array)}\n");

    int? secondLargest = array.Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();

    Console.WriteLine(secondLargest.HasValue ? $"Второй найбольший элемент: {secondLargest}" : "Массив имеет меньше двух уникальных элементов");
}

static void Work2()
{
    int rows = 3;
    int cols = 3;
    int[,] matrix = new int[rows, cols];
    Random random = new();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = random.Next(1, 101);
        }
    }

    Console.WriteLine("Исходная матрица:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    int[] sorted = matrix.Cast<int>().OrderBy(x => x).ToArray();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = sorted[i * cols + j];
        }
    }

    Console.WriteLine("\nСортированная матрица:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static void Work3()
{
    Random random = new();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 51);
    }

    Console.WriteLine($"Твой массив:\n{string.Join(", ", array)}\n");
    Console.Write("Введи индекс, который удалить из массива: ");
    int indexToRemove = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    if (indexToRemove >= 0 && indexToRemove < array.Length)
    {
        int[] newArray = array.Where((val, idx) => idx != indexToRemove).ToArray();
        Console.WriteLine("Массив после удаления:");
        Console.WriteLine(string.Join(", ", newArray));
    }
    else
    {
        Console.WriteLine("Индекс выходит за грани массива");
    }
}

static void Work4()
{
    Console.Write("Введите число, которое будет соответствовать массиву в ввиде квадрата (прим: 3 - соответственно массив 3 на 3): ");
    int rows = int.Parse(Console.ReadLine()!);
    int cols = rows;

    int[,] matrix = new int[rows, cols];
    Random random = new();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = random.Next(1, 51);
        }
    }

    int mainDiagonalSum = 0;
    int secondaryDiagonalSum = 0;
    int n = matrix.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        mainDiagonalSum += matrix[i, i];
        secondaryDiagonalSum += matrix[i, n - i - 1];
    }

    Console.WriteLine("Исходная матрица:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine($"Сумма первой диагонали: {mainDiagonalSum}");
    Console.WriteLine($"Сумма второй диагонали: {secondaryDiagonalSum}");
}