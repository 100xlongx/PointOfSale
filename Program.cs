using System;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new PaymentHandler();

            handler.addProduct("Pogchamp", 420, 8);
            handler.createPayment("1234", "John Doe", "12/20", "567");
            handler.addShipment("Pogchamp", "123 Cauliflower Lane", "Fairy Land", "55555", "Califorinia");
            
            var prod = handler.getProduct("Pogchamp");
            var payment = handler.getPaymentName("John Doe");

            Console.WriteLine($"Product Name: {prod.name}");
            Console.WriteLine($"Payment Name: {payment._cardHolderName}");
        }
    }
}
