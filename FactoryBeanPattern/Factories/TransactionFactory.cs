using FactoryBeanPattern.Implementations;
using FactoryBeanPattern.Interfaces;
using FactoryBeanPattern.Models;
using FactoryBeanPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBeanPattern.Factories
{
    public class TransactionManager
    {
        readonly IAccountTransactions accountTransactions;

        TransactionManager(IAccountTransactions accountTransactions)
        {
            this.accountTransactions = accountTransactions;
        }

        public static ITransaction Init(TransactionType type,DemoData demoData)
        {
            IAccountTransactions accountTransactions = new AccountTransactions(demoData);

            ITransaction obj;
          if(type == TransactionType.Deposit)
            {
                obj = new DepositTransaction(accountTransactions);
            }
            else
            {
                obj = new WithdrawTransaction(accountTransactions);
            }

            return obj;
        }
    }
}
