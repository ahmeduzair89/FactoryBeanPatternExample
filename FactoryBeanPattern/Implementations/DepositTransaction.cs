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
    internal class DepositTransaction : ITransaction
    {
        private readonly IAccountTransactions accountTransactions;
        public DepositTransaction(IAccountTransactions accountTransactions)
        {
            this.accountTransactions = accountTransactions;
        }

        public void Commit(TransactionModel dataModel)
        {
            accountTransactions.DepositFunds(dataModel);

        }
    }

}
