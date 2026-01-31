// See https://aka.ms/new-console-template for more information
using IPB2.ConsoleApp;
using System.Collections;

//Console.WriteLine("Hello, World!");

////Console.WriteLine("a");
////Console.WriteLine("b");
////Console.WriteLine("c");
////Console.WriteLine("d");
////Console.WriteLine("e");

//Start:
//Console.WriteLine("Welcome to PLM ATM");
//Console.WriteLine("1. Withdraw");
//Console.WriteLine("2. Deposit");
//Console.Write("Choose action: ");
//string action = Console.ReadLine();

////if (action == "Withdraw")
////{

////}
////else if (action == "Deposit")
////{

////}
////else if (action == "Transfers")
////{

////}


////bool result = int.TryParse(action, out int resultAction);
////if (result == false)
////{
////    Console.WriteLine("Invalid Action!");
////    goto Start;
////}

//bool result = Enum.TryParse(action, ignoreCase: true, out EnumAtmType atmType);

////EnumAtmType atmType = (EnumAtmType)resultAction;
//switch (atmType)
//{
//    case EnumAtmType.Withdraw:
//        Console.WriteLine("Withdraw Action!");
//        break;
//    case EnumAtmType.Deposit:
//        Console.WriteLine("Deposit Action!");
//        break;
//    case EnumAtmType.None:
//    default:
//        Console.WriteLine("Invalid Action!");
//        goto Start;
//}

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//Console.WriteLine(cars[4]);

//Console.Write("Please enter your name: ");
//string yourName = Console.ReadLine();
//yourName = "sddafd";

//Test test = new Test();
//test.GetName(yourName);
////test.GetName();
///

Account account = new Account();
string message = account.ToString();
Console.WriteLine(message);
account.Balance += 90000;
Console.WriteLine($"AvailableBalance: {account.AvailableBalance}");
//Console.WriteLine($"Initial Balance: {account.Balance}");
//account.Balance += 500;
//Console.WriteLine("After Deposit Balance: " + account.Balance);

File.WriteAllText("account.txt", message);  // Create a file and write the content of writeText to it



try
{
    //int[] myNumbers = { 1, 2, 3 };
    //Console.WriteLine(myNumbers[10]);

    string readText = File.ReadAllText("1.txt");  // Read the contents of the file
    Console.WriteLine(readText);  // Output the content
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.ReadLine();

public enum EnumAtmType
{
    None,
    Withdraw,
    Deposit
}

public enum EnumStatusType
{
    None,
    Pending,
    Approved,
    Rejected
}

public class Account
{
    public Account()
    {
        balance = 10000;
    }

    public decimal AvailableBalance
    {
        get
        {
            return
                balance > 10000 ? balance - 10000 : balance;
        }
    }

    private decimal balance; // field

    public decimal Balance   // property
    {
        get { return balance; }   // get method
        set
        {
            Console.WriteLine($"Initial Balance: {balance}");
            balance = value;
            Console.WriteLine($"After Deposit Balance: {balance}");
        }  // set method
    }

    public override string ToString()
    {
        return $"AvailableBalance: {AvailableBalance}";
    }

    //public override string ToString()
    //{
    //    return base.ToString();
    //}
}

// Abstract class
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Pig : Animal
{
    public override void animalSound()
    {

    }
}

interface WalletService
{
    void ShowBalance();
    void Transfer();
    void TransactionHistory();
}

public class KPayService : WalletService
{
    public void ShowBalance()
    {
        throw new NotImplementedException();
    }

    public void TransactionHistory()
    {
        throw new NotImplementedException();
    }

    public void Transfer()
    {
        throw new NotImplementedException();
    }
}
