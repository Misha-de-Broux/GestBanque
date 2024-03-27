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

        protected override bool IsWithDrawalValid(double amount) {
            if (amount > 0) {
                Console.WriteLine("retrait d'un montant négatif impossible");
                return false;
            } else if (amount <= Balance + MaxCredit) {
                Console.WriteLine("Solde insufisant");
                return false;
            }
            return true;
        }

        protected override double CalculateInterest()
        {
            return Balance > 0 ? 0.03 : 0.0975;
        }

    }
}
