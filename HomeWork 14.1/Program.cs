
List<Account> accounts =
[
    new ("Alice's account", 100.00m),
    new ("Bob's account", 200.00m),
    new ("Heikki's account", 300.00m)
];

Console.WriteLine("Welcome to the Bank App!");

while (true)
{
    DisplayAccounts(accounts);

    Console.WriteLine("\nEnter the number of the account you want to manage (or 0 to exit):");

    if (!int.TryParse(Console.ReadLine(), out int accountChoice) || accountChoice < 0 || accountChoice > accounts.Count)
    {
        Console.WriteLine("Invalid choice. Try again.\n");
        continue;
    }

    if (accountChoice == 0)
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    var selectedAccount = accounts[accountChoice - 1];

    while (true)
    {
        ManageAccount(selectedAccount);

        Console.Write("Your choice: ");
        if (!int.TryParse(Console.ReadLine(), out int userAction) || userAction < 1 || userAction > 3)
        {
            Console.WriteLine("Invalid choice. Try again.\n");
            continue;
        }

        if (userAction == 3)
        {
            break;
        }

        Console.WriteLine("Enter amount:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount. Try again.\n");
            continue;
        }

        try
        {
            if (userAction == 1)
            {
                selectedAccount.Deposit(amount);
                Console.WriteLine($"Deposited $ {amount}. New balance: $ {selectedAccount.Balance}\n");
            }
            else if (userAction == 2)
            {
                selectedAccount.Withdrawal(amount);
                Console.WriteLine($"Withdrew $ {amount}. New balance: $ {selectedAccount.Balance}\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }
}

static void DisplayAccounts(List<Account> accounts)
{
    Console.WriteLine("\nAvailable accounts:");
    for (int i = 0; i < accounts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {accounts[i].Name} (Balance: $ {accounts[i].Balance})");
    }
}

static void ManageAccount(Account selectedAccount)
{
    Console.WriteLine($"\nManaging {selectedAccount.Name} (Balance: $ {selectedAccount.Balance})");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Go back to account selection\n");
}

public class Account
{
    public string Name { get; private set; }
    private decimal balance;

    public Account(string name, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Account name cannot be empty or whitespace.\n");
        }

        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be less than 0.\n");
        }

        Name = name;
        balance = initialBalance;
    }

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than 0.");
        }

        balance += amount;
    }

    public void Withdrawal(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than 0.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds for this withdrawal.");
        }

        balance -= amount;
    }
}
