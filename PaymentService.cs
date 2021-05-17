using System.Collections.Generic;

namespace PointOfSale
{
    public class PaymentService
    {
        public List<Payment> pending;

        public void addPayment(Payment payment) {
            pending.Add(payment);
        }

        public void removePayment(string creditCardNum) {
            pending.RemoveAll(payment => payment._creditCardNum == creditCardNum);
        }
    }
}