using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Current {

        private double _maxCredit;
        public string Number { get; set; }
        public double Balance { get; private set; }
        public double MaxCredit {
            get { return _maxCredit; }
            set { if (value >= 0) _maxCredit = value; }
        }
        public Person Owner { get; set; }

        public void Deposit(double amount) {
            if (amount <= 0) {
                Console.WriteLine("dépot d'un montant négatif impossible");
                return;
            }
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (amount <= 0) {
                Console.WriteLine("retrait d'un montant négatif impossible");
                return;
            }
            if (amount > Balance + MaxCredit) {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            Balance -= amount;
        }
    }
}
