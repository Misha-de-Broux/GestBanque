using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Bank {
        private Dictionary<String, Current> _currents = new Dictionary<String, Current>();
        public string Name { get; set; }

        public Current this[string number] {
            get {
                if (this._currents.ContainsKey(number)) {
                    return this._currents[number];
                }
                Console.WriteLine("Numéro inconnu");
                return null;
            }
        }

        void Add(Current account) {
            if (account == null) {
                Console.WriteLine("Ce compte n'existe pas");
                return;
            }
            if (_currents.ContainsKey(account.Number)) {
                Console.WriteLine("Numéro de compte déjà existant");
                return;
            }
            _currents[account.Number] = account;
        }

        void Remove(string number) {
            if (!_currents.ContainsKey(number)) {
                Console.WriteLine("Ce compte n'est pas présent dans notre liste'");
                return;
            }
            _currents.Remove(number);
        }
    }
}
