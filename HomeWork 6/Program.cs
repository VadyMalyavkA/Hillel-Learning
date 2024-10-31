//Домашнее задание #1---------------------------------------------------------------------------------------------------------------

// while (true)
//{
//    try
//    {
//        int countEmployee = 5;
//Console.WriteLine("You have 5 employees:");
//Console.WriteLine
//                 ("Alex\n" +
//                  "Petr\n" +
//                  "Max\n" +
//                  "Oksana\n" +
//                  "Maria\n");

//Console.Write("Please, enter salary Alex: ");
//double salaryAlex = double.Parse(Console.ReadLine()!);

//Console.Write("Please, enter salary Petr: ");
//double salaryPetr = double.Parse(Console.ReadLine()!);

//Console.Write("Please, enter salary Max: ");
//double salaryMax = double.Parse(Console.ReadLine()!);

//Console.Write("Please, enter salary Oksana: ");
//double salaryOksana = double.Parse(Console.ReadLine()!);

//Console.Write("Please, enter salary Maria: ");
//double salaryMaria = double.Parse(Console.ReadLine()!);

//double averageSalary = (salaryAlex + salaryMaria + salaryPetr + salaryMax + salaryOksana) / countEmployee;

//string messageSallary = $"According to your data, the average salary of employees is: {averageSalary:F2}";
//Console.WriteLine(messageSallary);
//Console.WriteLine(new string('-', messageSallary.Length));
//    }
//    catch (FormatException exception)
//    {
//        Console.Clear();
//Console.WriteLine(exception.Message);
//string messageExeption = exception.Message;
//Console.WriteLine($"{new string('-', messageExeption.Length)}\n");
//continue;
//    }
//        break;
//}

// Домашнее задание #2

// while (true)
//{
//    Console.Write("Enter numbers of strings: ");
//byte numberOfStrings = byte.Parse(Console.ReadLine()!);

//int count = 0;
//while (count < numberOfStrings)
//{
//    Console.WriteLine(new string('*', count + 1));
//    count++;
//}
//}

//Домашнее задание #3---------------------------------------------------------------------------------------------------------------

//while (true)
//{
//    Console.Write("Please enter a number: ");
//int number = int.Parse(Console.ReadLine()!);

//Console.WriteLine($"Prime numbers up to {number}:");

//for (int primeNumbers = 2; primeNumbers <= number; primeNumbers++)
//{
//    bool isPrime = true;

//    for (int divisor = 2; divisor < primeNumbers; divisor++)
//    {
//        if (primeNumbers % divisor == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.WriteLine(primeNumbers);
//    }
//}
//}


//Домашнее задание #4---------------------------------------------------------------------------------------------------------------

// while (true)
//{
//    Console.Write("Enter password: ");
//string password = Console.ReadLine()!;

//if (IsPasswordValid(password))
//{
//    Console.WriteLine("Password accepted\n");
//}
//else
//{
//    Console.WriteLine("Password not accepted. Need length min 8 chars and include a digit and special char.\n");
//}

//static bool IsPasswordValid(string password)
//{
//    if (password.Length < 8)
//        return false;

//    bool hasDigit = false;
//    bool hasSpecialChar = false;

//    char[] specialChars = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', ';', ':', '\'', '"', ',', '.', '<', '>', '?', '/', '\\', '|'];

//    foreach (char c in password)
//    {
//        if (char.IsDigit(c))
//            hasDigit = true;

//        if (Array.Exists(specialChars, specialChar => specialChar == c))
//            hasSpecialChar = true;

//        if (hasDigit && hasSpecialChar)
//            return true;
//    }

//    return false;
//}
//}

//Домашнее задание #5---------------------------------------------------------------------------------------------------------------

//while (true)
//{


//    Console.Write("Enter the number of Fibonacci numbers to generate: ");
//int n = int.Parse(Console.ReadLine()!);

//GenerateFibonacci(n);

//static void GenerateFibonacci(int n)
//{
//    if (n <= 0)
//    {
//        Console.WriteLine("Please enter a number greater than 0.");
//        return;
//    }

//    long first = 0, second = 1;

//    Console.WriteLine("The first {0} Fibonacci numbers:", n);
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write(first + " \n");

//        long next = first + second;
//        first = second;
//        second = next;
//    }

//    Console.WriteLine();
//}
//}

//Домашнее задание #6---------------------------------------------------------------------------------------------------------------

//while (true)
//{
//    Console.Write("Enter the number of hours worked in a day: ");
//double hoursWorked = double.Parse(Console.ReadLine()!);

//Console.Write("Enter the hourly rate: ");
//double hourlyRate = double.Parse(Console.ReadLine()!);

//double dailyPay = hoursWorked * hourlyRate;

//Console.WriteLine("Daily pay: {0:F2}", dailyPay);
//}

//Домашнее задание #7---------------------------------------------------------------------------------------------------------------

//while (true)
//{
//    Console.Write("Enter a number to generate its multiplication table: ");
//int number = int.Parse(Console.ReadLine()!);

//Console.WriteLine($"\nMultiplication Table for {number}:");

//for (int i = 1; i <= 10; i++)
//{
//    int result = number * i;
//    Console.WriteLine($"{number} x {i} = {result}\n");
//}
//}

//Домашнее задание #8---------------------------------------------------------------------------------------------------------------

//while (true)
//{
//    Console.Write("Enter a number to check if it is prime: ");
//    int number = int.Parse(Console.ReadLine()!);

//    bool isPrime = true;

//    if (number <= 1)
//    {
//        isPrime = false;
//    }
//    else
//    {
//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }
//    }

//    if (isPrime)
//    {
//        Console.WriteLine($"{number} is a prime number.\n");
//    }
//    else
//    {
//        Console.WriteLine($"{number} is not a prime number.\n");
//    }
//}