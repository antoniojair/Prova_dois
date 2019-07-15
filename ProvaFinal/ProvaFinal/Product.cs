using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFinal {
    class Product {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public Product(int id, string name, double price) {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
