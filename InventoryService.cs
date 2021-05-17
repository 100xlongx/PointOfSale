


using System.Collections.Generic;

namespace PointOfSale {

    class InventoryService {
        public List<Product> products;

        public void addProduct(Product product) {
            products.Add(product);
        }

        public void removeProduct(string name) {
            products.RemoveAll(product => product.name == name);
        }
    }
}