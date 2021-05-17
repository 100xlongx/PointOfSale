namespace PointOfSale
{
    public class Shipment
    {
        public Address Address { get; set; }
        public Product Product { get; set; }
        public int ShipmentID { get; set; }
    }
}