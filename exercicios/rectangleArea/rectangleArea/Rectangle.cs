using System;

namespace rectangleArea {
    class Rectangle {

        public double b; // base
        public double h; // altura

        public double Area() {
            return b * h;
        }

        public double Perimeter() {
            return (b + h) * 2;
        }

        public double Diagonal() {
            return Math.Sqrt((b*b) + (h*h));
        }
    }
}
