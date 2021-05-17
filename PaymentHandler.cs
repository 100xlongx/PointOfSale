namespace PointOfSale
{
    public class PaymentHandler
    {
        private InventoryService inventoryService = new InventoryService();
        private ShippingService shippingService = new ShippingService();
        private PaymentService paymentService = new PaymentService();

        public void createPayment() {
            var payment = new Payment("1234", "pickle rick", "12/20", "123");
            paymentService.addPayment(payment);
        }

        public void removePayment(string creditCardNum) {
            paymentService.removePayment(creditCardNum);
        }

        public void addProduct(string name, int price, int quantity) {
            inventoryService.addProduct(name, price, quantity);
        }

        public void removeProduct(string name) {
            inventoryService.removeProduct(name);
        }

        public Product getProduct(string name) {
            return inventoryService.GetProduct(name);
        }

        public void addShipment() {
            var product = inventoryService.GetProduct("Pogchamp");
            var address = new Address("123 Cauliflower Lane", "Fairy Land", "55555", "Oppression");

            var shipment = new Shipment(address, product, 1);
            shippingService.addShipment(shipment);
        }

        public void removeShipment() {
            shippingService.removeShipment(1);
        }





    }
}