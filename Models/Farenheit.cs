using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    internal struct Farenheit {
        public double Temperature { get; set; }

        public static explicit operator Celsius(Farenheit farenheit) {
            return new Celsius() { Temperature = (farenheit.Temperature - 32) / 1.8 };
        }
    }
}
