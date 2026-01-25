// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//Console.WriteLine("a");
//Console.WriteLine("b");
//Console.WriteLine("c");
//Console.WriteLine("d");
//Console.WriteLine("e");

Start:
Console.WriteLine("Welcome to PLM ATM");
Console.WriteLine("1. Withdraw");
Console.WriteLine("2. Deposit");
Console.Write("Choose action: ");
string action = Console.ReadLine();

//if (action == "Withdraw")
//{

//}
//else if (action == "Deposit")
//{

//}
//else if (action == "Transfers")
//{

//}


//bool result = int.TryParse(action, out int resultAction);
//if (result == false)
//{
//    Console.WriteLine("Invalid Action!");
//    goto Start;
//}

bool result = Enum.TryParse(action, ignoreCase: true, out EnumAtmType atmType);

//EnumAtmType atmType = (EnumAtmType)resultAction;
switch (atmType)
{
    case EnumAtmType.Withdraw:
        Console.WriteLine("Withdraw Action!");
        break;
    case EnumAtmType.Deposit:
        Console.WriteLine("Deposit Action!");
        break;
    case EnumAtmType.None:
    default:
        Console.WriteLine("Invalid Action!");
        goto Start;
}

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars[4]);

Console.ReadLine();

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