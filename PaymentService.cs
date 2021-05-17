namespace PointOfSale
{
    public class PaymentService
    {
          public List<Payment> pending;

        public void addPaymnet(Payment payment) {
            pending.Add(payment);
        }

        public void removePayment(string creditCardNum) {
            pending.RemoveAll(payment => payment._creditCardNum == creditCardNum);
        }
    }
}