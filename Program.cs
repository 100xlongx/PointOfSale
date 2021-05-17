using System;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new PaymentHandler();

            handler.addProduct("Pogchamp", 420, 8);
            
            var pog = handler.getProduct("Pogchamp");

            Console.WriteLine(pog.name);
        }
    }
}
