using System;

namespace simpleDollarConverter {
    class CurrencyConverter {
        public static double iof = 0.06; // iof - imposto sobre importações financeiras

        public static double DollarConverter(double c, double v) {
            return c * v + (c * v * iof); 
        }
    }
}
