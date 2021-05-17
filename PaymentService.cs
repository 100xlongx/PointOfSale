using System.Collections.Generic;

namespace PointOfSale
{
    public class PaymentService
    {
        public List<Payment> pending = new List<Payment>();

        public void addPayment(Payment payment) {
            pending.Add(payment);
        }

        public void removePayment(string creditCardNum) {
            pending.RemoveAll(payment => payment._creditCardNum == creditCardNum);
        }

        public Payment GetPaymentName(string name) {
            return pending.Find(pay => pay._cardHolderName == name);
        }
    }
}