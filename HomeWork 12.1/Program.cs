while (true)
{
    Console.WriteLine("Введите номер числа Фибоначчи:");
    if (!decimal.TryParse(Console.ReadLine(), out decimal number))
    {
        Console.WriteLine("Пожалуйста, введите корректное целое число.");
        continue;
    }

    try
    {
        decimal result = FibonacciCalculator.CalculateFibonacci(number);
        Console.WriteLine($"Число Фибоначчи {number}-го порядка: {result}\n");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

public static class FibonacciCalculator
{
    public static decimal CalculateFibonacci(decimal n)
    {
        if (n <= 0) throw new ArgumentException("Номер числа Фибоначчи должен быть положительным.");
        if (n == 1) return 0;
        if (n == 2) return 1;

        decimal previous = 0, current = 1;
        for (int i = 3; i <= n; i++)
        {
            decimal next = previous + current;
            previous = current;
            current = next;
        }

        return current;
    }
}
