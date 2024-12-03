try
{
    Console.Write("Введите путь до исходного файла: ");
    string sourcePath = Console.ReadLine();

    Console.Write("Введите путь до файла, в который нужно скопировать данные: ");
    string destinationPath = Console.ReadLine();

    File.Copy(sourcePath, destinationPath, overwrite: true);

    Console.WriteLine("Файл успешно скопирован!");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Ошибка: Исходный файл не найден.");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Ошибка: Доступ к файлу запрещён.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}