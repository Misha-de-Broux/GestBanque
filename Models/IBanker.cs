using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal interface IBanker : ICustomer
    {
        Person Owner { get; }
        string Number { get; }

        void ApplyInterest();
    }
}
