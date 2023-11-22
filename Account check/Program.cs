using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }
        public void Deposit()
        {
            Console.WriteLine("Please enter amount to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Balance: " + GetBalance());
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter amount you would like to withdraw:");
            int amount = Convert.ToInt32(Console.ReadLine());

        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Balance: " + GetBalance());
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }

    }
        public decimal GetBalance()
        {
            return balance;
        }
public static void Main(string[] args)
{
        BankAccount myaccount = new BankAccount(35000);

    myaccount.Deposit();
        myaccount.Withdraw();
        myaccount.GetBalance();
}
}