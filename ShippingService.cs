using System.Collections.Generic;

namespace PointOfSale
{
    public class ShippingService
    {
        public List<Shipment> pending = new List<Shipment>();

        public void addShipment(Shipment shipment) {
            pending.Add(shipment);
        }

        public void removeShipment(int id) {
            pending.RemoveAll(shipment => shipment.ShipmentID == id);
        }
    }
}