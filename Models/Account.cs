using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Account {
        public string Number { get; set; }
        public double Balance { get; private set; }
        public Person Owner { get; set; }

        public virtual void Deposit(double amount) {
            if (amount <= 0) {
                Console.WriteLine("dépot d'un montant négatif impossible");
                return;
            }
            Balance += amount;
        }

        public virtual void Withdraw(double amount) {
            if (amount <= 0) {
                Console.WriteLine("retrait d'un montant négatif impossible");
                return;
            }
            Balance -= amount;
        }

        public static double operator +(double d, Account c) {
            return c.Balance > 0 ? d + c.Balance : d;
        }
    }
}
