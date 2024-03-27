using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public abstract class Account : IBanker {
        public string Number { get; set; }
        public double Balance { get; private set; }
        public Person Owner { get; set; }

        public void Deposit(double amount) {
            if (amount <= 0) {
                Console.WriteLine("dépot d'un montant négatif impossible");
                return;
            }
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (IsWithDrawalValid(amount))
                Balance -= amount;
        }

        protected virtual Boolean IsWithDrawalValid(double amount) {
            if (amount > 0) {
                Console.WriteLine("retrait d'un montant négatif impossible");
                return false;
            } else if (amount <= Balance) {
                Console.WriteLine("Solde insufisant");
                return false;
            }
            return true;
        }

        abstract protected double CalculateInterest();

        public void ApplyInterest()
        {
            Balance *= (1+ CalculateInterest());
        }

        public static double operator +(double d, Account c) {
            return c.Balance > 0 ? d + c.Balance : d;
        }
    }
}
