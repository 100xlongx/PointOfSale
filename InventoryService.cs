


using System.Collections.Generic;
using System;

namespace PointOfSale {

    class InventoryService {
        public List<Product> products = new List<Product>();

        public void addProduct(string name, int price, int quantity) {
            products.Add(new Product(name, price, quantity));
        }

        public void removeProduct(string name) {
            products.RemoveAll(product => product.name == name);
        }

        public Product GetProduct(string name) {
            return products.Find(prod => prod.name == name);
        }
    }
}