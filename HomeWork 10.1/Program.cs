while (true)
{
    Console.Write($"Please enter a first and last name: ");

    Console.ForegroundColor = ConsoleColor.Green;
    string fullName = (Console.ReadLine()!).Trim();
    Console.ResetColor();

    string[] nameParts = fullName.Split(' ');

    if (nameParts.Length == 2)
    {
        char firstNameInitial = char.ToUpper(nameParts[0][0]);
        char lastNameInitial = char.ToUpper(nameParts[1][0]);

        if (firstNameInitial == lastNameInitial)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The last name starts with the same letter as the first name");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The last name does not start with the same letter as the first name");
            Console.ResetColor();
        }
    }
    else
    {
        Console.WriteLine("The string does not contain a valid first and last name");
    }
    Console.WriteLine();
}
