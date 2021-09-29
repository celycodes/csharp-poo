using System.Globalization;

namespace productStock {
    class Product {
        private string _name; // atributos
        public double Price { get; private set; } // auto properties
        public int Quantity { get; private set; }

        public Product(string name, double price, int quantity) { // construtor
            _name = name;
            Price = price; 
            Quantity = quantity;
        }

        public string Name { 
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            } // property customizadas
        }


        public double TotalValueInStock() {
            return Price * Quantity;
        }

        public void  AddProduct(int quantity) {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity) {
            Quantity -= quantity;
        }

        public override string ToString() {
            return _name + ", $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " unidades, Total: $ "+ TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
