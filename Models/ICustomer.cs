using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal interface ICustomer
    {
        double Balance { get; }
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
