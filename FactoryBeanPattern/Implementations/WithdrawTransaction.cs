using FactoryBeanPattern.Interfaces;
using FactoryBeanPattern.Models;
using FactoryBeanPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBeanPattern.Implementations
{
    internal class WithdrawTransaction : ITransaction
    {
         readonly IAccountTransactions accountTransactions;
        public WithdrawTransaction(IAccountTransactions accountTransactions)
        {
            this.accountTransactions = accountTransactions;
        }

        public void Commit(TransactionModel dataModel)
        {
           accountTransactions.WithdrawFunds(dataModel);
        }
    }
}
