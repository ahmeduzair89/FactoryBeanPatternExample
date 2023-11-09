using FactoryBeanPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBeanPattern.Interfaces
{
   
    public interface ITransaction
    {
        public void Commit(TransactionModel dataModel);
    }
}

