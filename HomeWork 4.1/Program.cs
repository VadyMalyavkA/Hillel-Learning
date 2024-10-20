using System.Threading.Channels;

namespace HomeWork_4._1
{
    internal class Program
    {
        static void Main()
        {
            while (true) {
            Console.Write("Enter number of weekday: ");
            string numbWeek = Console.ReadLine()!;
            Console.Clear();
                switch (numbWeek)
                {
                    case "1":
                        Console.WriteLine("You have chosen Monday");
                        break;
                    case "2":
                        Console.WriteLine("You have chosen Tuesday");
                        break;
                    case "3":
                        Console.WriteLine("You have chosen Wednesday");
                        break;
                    case "4":
                        Console.WriteLine("You have chosen Thursday");
                        break;
                    case "5":
                        Console.WriteLine("You have chosen Friday");
                        break;
                    case "6":
                        Console.WriteLine("You have chosen Saturday");
                        break;
                    case "7":
                        Console.WriteLine("You have chosen Sunday");
                        break;
                    default:
                        Console.Write("Error 404 ");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine("=)");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine("=|");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine("=(");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                }

            }
        }
    }
}
