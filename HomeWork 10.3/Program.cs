while (true)
{
    Console.Write("Please enter the text where you need deleted \" \": ");

    string input = Console.ReadLine()!;
    string result = input.Replace(" ", "");

    Console.WriteLine(result);
    Console.WriteLine();
}
