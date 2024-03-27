using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Saving : Account {
        public DateTime LastWithdrawal { get; set; }
        public override void Withdraw(double amount) {
            double old = Balance;
            base.Withdraw(amount);
            if (Balance != old) {
                LastWithdrawal = DateTime.Now;
            }
        }

        protected override double CalculateInterest()
        {
            return 0.045;
        }
    }
}
