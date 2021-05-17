
namespace PointOfSale
{
    public class Product
    {
        public string name { get; set; }
        public int pricing { get; set; }
        public int quantity { get; set; }

        public Product(string name, int pricing, int quantity) {
            this.name = name;
            this.pricing = pricing;
            this.quantity = quantity;
        }
    }
}