class TodoListApp
{
    private static readonly List<string> todoList = [];
    private static readonly List<bool> completionStatus = [];

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Показать список задач");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите опцию: ");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    private static void AddTask()
    {
        Console.Write("Введите название задачи: ");
        string task = Console.ReadLine()!;
        if (!string.IsNullOrWhiteSpace(task))
        {
            todoList.Add(task);
            completionStatus.Add(false);
            Console.WriteLine("Задача добавлена.");
        }
        else
        {
            Console.WriteLine("Название задачи не может быть пустым.");
        }
    }

    private static void ShowTasks()
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач (Красным - не выполненно | Зеленым - выполнена):");
            for (int i = 0; i < todoList.Count; i++)
            {
                if (completionStatus[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }

            Console.ResetColor();
        }
    }

    private static void MarkTaskAsCompleted()
    {
        ShowTasks();
        if (todoList.Count == 0) return;

        Console.Write("Введите номер задачи для отметки как выполненной: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoList.Count)
        {
            completionStatus[taskNumber - 1] = true;
            Console.WriteLine("Задача отмечена как выполненная.");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }

    private static void DeleteTask()
    {
        ShowTasks();
        if (todoList.Count == 0) return;

        Console.Write("Введите номер задачи для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoList.Count)
        {
            todoList.RemoveAt(taskNumber - 1);
            completionStatus.RemoveAt(taskNumber - 1);
            Console.WriteLine("Задача удалена.");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }
}
