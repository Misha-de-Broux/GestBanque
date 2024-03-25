using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Saving : Account{
        public DateTime LastWithdrawal {  get; set; }
        public override void Withdraw(double amount) {
            if (amount <= 0) {
                Console.WriteLine("retrait d'un montant négatif impossible");
                return;
            }
            if (amount > Balance) {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            LastWithdrawal = DateTime.Now;
            base.Withdraw(amount);
        }
    }
}
