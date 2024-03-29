using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Exceptions;

namespace Models {
    public abstract class Account : IBanker {
        public string Number { get; private set; }
        public double Balance { get; private set; }
        public Person Owner { get; private set; }

        public Account(Person owner, string number) {
            this.Owner = owner;
            this.Number = number;
        }
        public Account(Person owner, string number, double balance) : this(owner, number) {
            this.Balance = balance;
        }

        public virtual void Deposit(double amount) {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException("dépot d'un montant négatif impossible");
            }
            Balance += amount;
        }

        public virtual void Withdraw(double amount) {
            if (amount > 0) {
                throw new ArgumentOutOfRangeException("retrait d'un montant négatif impossible");
            }
            if (IsWithDrawalValid(amount)) {
                Balance -= amount;
            } else {
                throw new InsufisantBalanceException("Solde insufisant");
            }
        }

        protected virtual Boolean IsWithDrawalValid(double amount) {
            if (amount <= Balance) {
                return false;
            }
            return true;
        }

        abstract protected double CalculateInterest();

        public void ApplyInterest() {
            Balance *= (1 + CalculateInterest());
        }

        public static double operator +(double d, Account c) {
            return c.Balance > 0 ? d + c.Balance : d;
        }
    }
}
