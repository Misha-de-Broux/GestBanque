using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Current : Account {

        private double _maxCredit;
        public double MaxCredit {
            get { return _maxCredit; }
            private set { 
                if (value >= 0) _maxCredit = value; 
                else throw new ArgumentOutOfRangeException("La ligne de crédit doit être positive");
            }
        }

        public Current(Person owner, string number) : this(owner, number, 0) {
        }
        public Current(Person owner, string number, double balance) : base(owner, number, balance) {
        }
        public Current(double maxCredit, Person owner, string number) : this(owner, number) {
            this._maxCredit = maxCredit;
        }

        protected override bool IsWithDrawalValid(double amount) {
            if (amount >= Balance + MaxCredit) {
                return false;
            } 
            return true;
        }
        public override void Withdraw(double amount) {
            double balanceBefore = Balance;
            base.Withdraw(amount);
            if(balanceBefore >=0 && Balance < 0) {
                TriggerWentIntoCreditEvent();
            }
        }


        protected override double CalculateInterest() {
            return Balance > 0 ? 0.03 : 0.0975;
        }


    }
}
