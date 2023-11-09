using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryBeanPattern.Models;

namespace FactoryBeanPattern.Repositories
{
    public class DemoData
    {

        public List<AccountModel> accounts = new List<AccountModel>();

   public DemoData()
        {

            accounts.Add(new AccountModel{
            Name="Ahmed",
            Id=1,
            Balance=100000
            });

            accounts.Add(new AccountModel
            {
                Name = "Kashif",
                Id = 2,
                Balance = 25000000
            });

            accounts.Add(new AccountModel
            {
                Name = "Zeeshan",
                Id = 3,
                Balance = 2000000
            });
        }
    }
}
