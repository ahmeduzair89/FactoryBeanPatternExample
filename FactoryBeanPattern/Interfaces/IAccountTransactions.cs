using FactoryBeanPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBeanPattern.Interfaces
{
    internal interface IAccountTransactions
    {
        void WithdrawFunds(TransactionModel transactionModel);
        void DepositFunds(TransactionModel transactionModel);

    }
}
