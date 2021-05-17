namespace PointOfSale
{
    public class PaymentHandler
    {
        private InventoryService inventoryService = new InventoryService();
        private ShippingService shippingService = new ShippingService();
        private PaymentService paymentService = new PaymentService();

        public void createPayment(string cardNums, string name, string exp, string cv) {
            var payment = new Payment(cardNums, name, exp, cv);
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

        public Payment getPaymentName(string name) {
            return paymentService.GetPaymentName(name);
        }

        public void addShipment(string productName, string street, string city, string zip, string state) {
            var product = inventoryService.GetProduct(productName);
            var address = new Address(street, city, zip, state);

            var shipment = new Shipment(address, product, 1);
            shippingService.addShipment(shipment);
        }

        public void removeShipment() {
            shippingService.removeShipment(1);
        }





    }
}