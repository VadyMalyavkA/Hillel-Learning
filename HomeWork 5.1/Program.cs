while (true)
{
    try
    {
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine()!);

        Console.Write("Enter char of operation ( + or - or * or / ): ");
        string operation = Console.ReadLine()!;

        if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid operation.\n");
            continue;
        }

        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine()!);

        var plus = firstNum + secondNum;
        var minus = firstNum - secondNum;
        var mult = firstNum * secondNum;
        var divide = firstNum / secondNum;

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Your result: {plus}\n");
                break;
            case "-":
                Console.WriteLine($"Your result: {minus}\n");
                break;
            case "*":
                Console.WriteLine($"Your result: {mult}\n");
                break;
            case "/":
                Console.WriteLine($"Your result: {divide}\n");
                break;
        }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: Division by zero is not allowed.\n");
    }
}
