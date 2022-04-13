using System;
using System.Globalization;

namespace triangleArea {
    class Triangle {
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override string ToString() {
            return Area().ToString("f4", CultureInfo.InvariantCulture) + " m²";
        }
    }
}
