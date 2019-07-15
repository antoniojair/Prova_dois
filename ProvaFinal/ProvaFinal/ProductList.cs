using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFinal {
    class ProductList {
        public List<Product> productList;

        public ProductList() {
            productList = new List<Product>();
        }

        public void Add(Product product) {
            productList.Add(product);

        }

        public List<Product> All() {
            return productList;
        }


    }
}
