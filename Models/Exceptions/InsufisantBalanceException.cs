using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    internal class InsufisantBalanceException : Exception{
        public InsufisantBalanceException(string message) : base(message) { }
    }
}
