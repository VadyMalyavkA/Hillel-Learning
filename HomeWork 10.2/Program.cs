using System.Text;

StringBuilder eventsBuilder = new();

string reportTitle = "Текстовый отчет о событиях";
string reportDate = DateTime.Now.ToString("dd.MM.yyyy");

Console.WriteLine(reportTitle);
Console.WriteLine($"Дата: {reportDate}");
Console.WriteLine(new string('-', 30));

while (true)
{
    Console.WriteLine("Введите событие (или введите 'выход' для завершения):");
    string input = Console.ReadLine()!;
    Console.WriteLine();

    if (input.Equals("выход", StringComparison.OrdinalIgnoreCase))
        break;

    eventsBuilder.AppendLine($"- {input}");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Текущий список событий:");
    Console.ResetColor();

    Console.ForegroundColor= ConsoleColor.Yellow;
    Console.WriteLine(eventsBuilder.ToString());
    Console.ResetColor();
}

Console.WriteLine(new string('=', 30));
Console.WriteLine("Итоговый текстовый отчет:");
Console.WriteLine(reportTitle);
Console.WriteLine($"Дата: {reportDate}");
Console.WriteLine(new string('-', 30));

if (eventsBuilder.Length > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Список событий:");
    Console.WriteLine(eventsBuilder.ToString());
    Console.ResetColor();
}
else
{
    Console.WriteLine("Список событий пуст.");
}