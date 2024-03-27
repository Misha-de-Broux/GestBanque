using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Person {
        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public DateTime Birthday { get; private set; }

        public Person(string name, string firstName, DateTime birtday) {
            Name = name;
            FirstName = firstName;
            Birthday = birtday;
        }
    }
}
