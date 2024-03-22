using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    internal struct Celsius {
        public double Temperature { get; set; }

        public static implicit operator Farenheit(Celsius c) {
            return new Farenheit() { Temperature = 1.8 * c.Temperature + 32 };
        }

    }
}
