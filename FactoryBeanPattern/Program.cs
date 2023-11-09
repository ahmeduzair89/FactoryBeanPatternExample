using FactoryBeanPattern.Factories;
using FactoryBeanPattern.Interfaces;
using FactoryBeanPattern.Models;
using FactoryBeanPattern.Repositories;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        DemoData data = new DemoData();

        Console.Write("BANK ACCOUNT MANAGEMENT PORTAL");
        Console.Write("==============================\n\n\n");
    restart:

    accountNumberEnter:
        int accountNumber = 0;
        Console.WriteLine("Enter account number to update: ");
        string accountNumberInput =   Console.ReadLine();

        try
        {
            accountNumber = int.Parse(accountNumberInput);

        }
        catch (Exception)
        {
            Console.WriteLine("\n\n!!!!!!!!!!Invalid Input!!!!!!!!!!\n\n");
            goto accountNumberEnter;
        }

        transactionSelection:
        Console.WriteLine("\n\nEnter Operation: \n1.Deposit\n2.Withdraw\n");
        ConsoleKeyInfo operationKey = Console.ReadKey();
        TransactionType transactionType = TransactionType.None;
        if (operationKey.Key.Equals(ConsoleKey.NumPad1))
        {
            transactionType = TransactionType.Deposit;
        }
        if (operationKey.Key.Equals(ConsoleKey.NumPad2)) {
            transactionType = TransactionType.Withdraw;
        }
        if(transactionType== TransactionType.None){

            Console.WriteLine("\n\n!!!!!!!!!!Invalid Input!!!!!!!!!!\n\n");
            goto transactionSelection;

        }





    enterAmount:
        int amount = 0;
        Console.WriteLine("\n\nEnter Amount: ");
        string amountInput = Console.ReadLine();

        try
        {
            amount = int.Parse(amountInput);

        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Input");
            goto enterAmount;
        }

        try
        {
            ITransaction transactionManager = TransactionManager.Init(transactionType, data);
            TransactionModel transactionModel = new TransactionModel();
            transactionModel.Amount = amount;
            transactionModel.AccountId = accountNumber;

              transactionManager.Commit(transactionModel);
            goto restart;
        }
        catch (Exception e )
        {
            Console.Clear();
            Console.WriteLine($"Error {e}");
            goto restart;

        }










    }
}

public enum TransactionType
{
   Withdraw,
   Deposit,
   None,
}