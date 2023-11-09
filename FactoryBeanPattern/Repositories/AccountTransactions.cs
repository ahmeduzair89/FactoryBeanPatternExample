using FactoryBeanPattern.Interfaces;
using FactoryBeanPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBeanPattern.Repositories
{
    internal class AccountTransactions:IAccountTransactions
    {
        private readonly DemoData data;

        public AccountTransactions(DemoData data)
        {
            this.data = data;
        }

        public void WithdrawFunds(TransactionModel transactionModel)
        {
          AccountModel account=  data.accounts.Where((a)=>a.Id.Equals(transactionModel.AccountId)).FirstOrDefault();

            if(account is null)
            {
                Console.WriteLine("\n\nNo account found\n\n");
                return;
            }
            else
            {
                Console.WriteLine("::::::::::Account Details::::::::::");

                Console.WriteLine($"Name: {account.Name}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.WriteLine($"Account ID: {account.Id}\n\n");

                if (account.Balance < transactionModel.Amount)
                {
                    Console.WriteLine("\n\nInsufficient Funds\n\n");
                    return;
                }
                else
                {
                    account.Balance = account.Balance - transactionModel.Amount;

                    data.accounts.Where((a) => a.Id.Equals(transactionModel.AccountId)).FirstOrDefault().Balance = account.Balance;

                    Console.WriteLine("Account balance updated");
                    Console.WriteLine($"New balance is {account.Balance}");
                }
            }
        }
        public void DepositFunds(TransactionModel transactionModel)
        {

            AccountModel account = data.accounts.Where((a) => a.Id.Equals(transactionModel.AccountId)).FirstOrDefault();

            if (account is null)
            {

                Console.WriteLine("No account found");
                return;
            }
            else
            {
                Console.WriteLine("::::::::::Account Details::::::::::");

                Console.WriteLine($"Name: {account.Name}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.WriteLine($"Account ID: {account.Id}\n\n");

                account.Balance = account.Balance +transactionModel.Amount;

                data.accounts.Where((a) => a.Id.Equals(transactionModel.AccountId)).FirstOrDefault().Balance = account.Balance;

                Console.WriteLine("Account balance updated");
                Console.WriteLine($"New balance is {account.Balance}");


            }
            }


    }
}
