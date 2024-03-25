using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Current : Account{

        private double _maxCredit;
        public double MaxCredit {
            get { return _maxCredit; }
            set { if (value >= 0) _maxCredit = value; }
        }

        public void Withdraw(double amount) {
            if (amount > Balance + MaxCredit) {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            base.Withdraw(amount);
        }

    }
}
