while (true)
{
    try
    {
        while (true)
        {
            Console.Write("Please enter a number of work: ");
            var numberWork = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            switch (numberWork)
            {
                case 1:
                    Work1and2();
                    break;
                case 2:
                    Work1and2();
                    break;
                case 3:
                    Work3();
                    break;
                case 4:
                    Work4();
                    break;
                case 5:
                    Work5();
                    break;
            }

//Work 1 and 2
            static void Work1and2()
            {
                int[] array = new int[10];
                Random random = new();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-10, 11);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0 && i != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"The array index #{i} have number: {array[i]}\n");
                        Console.ResetColor();
                    }
                }

                Console.Write($"Array sum = ({array[0]})" +
                    $" + ({array[1]})" +
                    $" + ({array[2]})" +
                    $" + ({array[3]})" +
                    $" + ({array[4]})" +
                    $" + ({array[5]})" +
                    $" + ({array[6]})" +
                    $" + ({array[7]})" +
                    $" + ({array[8]})" +
                    $" + ({array[9]})" +
                    $" = {array.Sum()} ");

                if (array.Sum() >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("(Is positive number)\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("(Is not positive number)\n");
                    Console.ResetColor();
                }
            }

//Work 3
            static void Work3()
            {
                int[,] multiplicationTable = new int[9, 9];

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        multiplicationTable[i, j] = (i + 1) * (j + 1);
                    }
                }

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(multiplicationTable[i, j].ToString().PadLeft(4));
                    }
                    Console.WriteLine();
                }
            }
            
//Work 4
            static void Work4()
            {
                int[,] array = new int[5, 5];
                Random random = new();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(0, 100);
                    }
                }

                int minValue = array.Cast<int>().Min();
                int maxValue = array.Cast<int>().Max();

                int minIndexRow = -1, minIndexCol = -1;
                int maxIndexRow = -1, maxIndexCol = -1;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == minValue)
                        {
                            minIndexRow = i;
                            minIndexCol = j;
                        }
                        if (array[i, j] == maxValue)
                        {
                            maxIndexRow = i;
                            maxIndexCol = j;
                        }
                    }
                }

                Console.WriteLine($"Min Value: {minValue} at position ({minIndexRow}, {minIndexCol})");
                Console.WriteLine($"Max Value: {maxValue} at position ({maxIndexRow}, {maxIndexCol})");
            }

//Work 5
            static void Work5()
            {
                Console.Write("Enter the number of days, starting from Monday: ");
                int inputDays;

                while (!int.TryParse(Console.ReadLine(), out inputDays) || inputDays < 0)
                {
                    Console.Write("Invalid value, please try again: ");
                }

                int startDay = (int)DaysOfWeek.Monday;
                int targetDayIndex = (startDay + inputDays - 1) % 7 + 1;

                DaysOfWeek resultDay = (DaysOfWeek)targetDayIndex;

                Console.WriteLine($"In {inputDays} days, it will be: {resultDay}");
            }

            Console.WriteLine();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Error 404, sorry, but we need try again\n");
    }
}

enum DaysOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}