namespace PointOfSale
{
    public class Payment
    {
        public string _creditCardNum;
        public string _cardHolderName;
        private string _expirationDate;
        private string _cVNum;

        public Payment(string creditNum, string holderName, string expirationDate, string cv) {
            this._creditCardNum = creditNum;
            this._cardHolderName = holderName;
            this._expirationDate = expirationDate;
            this._cVNum = cv;
        }

        public string getName()
        {
            return _cardHolderName;
        }
    }
}