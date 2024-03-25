using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Bank {
        private Dictionary<String, Account> _accounts = new Dictionary<String, Account>();
        public string Name { get; set; }

        public Account this[string number] {
            get {
                if (this._accounts.ContainsKey(number)) {
                    return this._accounts[number];
                }
                Console.WriteLine("Numéro inconnu");
                return null;
            }
        }

        public void Add(Account account) {
            if (account == null) {
                Console.WriteLine("Ce compte n'existe pas");
                return;
            }
            if (_accounts.ContainsKey(account.Number)) {
                Console.WriteLine("Numéro de compte déjà existant");
                return;
            }
            _accounts[account.Number] = account;
        }

        public void Remove(string number) {
            if (!_accounts.ContainsKey(number)) {
                Console.WriteLine("Ce compte n'est pas présent dans notre liste'");
                return;
            }
            _accounts.Remove(number);
        }

        public double TotalAssets(Person owner) {
            double total = 0;
            foreach (Account account in _accounts.Values) {
                if (account.Owner == owner) {
                    total += account;
                }
            }
            return total;
        }
    }
}
