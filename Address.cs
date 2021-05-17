namespace PointOfSale
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }

        public Address(string street, string city, string zip, string state) {
            this.Street = street;
            this.City = city;
            this.ZipCode = zip;
            this.State = state;
        }
    }
}