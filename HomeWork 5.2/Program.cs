while (true)
{
    try
    {
        Console.Write("Please enter you number: ");
        int number = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"You enter: {number}\n");
    }
    catch (FormatException)
    {
        Console.WriteLine($"The input was not in a correct format.\nYou need write in \"INT\" format...\n");
    }
}