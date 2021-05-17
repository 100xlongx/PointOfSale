namespace PointOfSale
{
    public class Shipment
    {
        public Address Address { get; set; }
        public Product Product { get; set; }
        public int ShipmentID { get; set; }

        public Shipment(Address address, Product product, int ID) {
            this.Address = address;
            this.Product = product;
            this.ShipmentID = ID;
        }
    }
}