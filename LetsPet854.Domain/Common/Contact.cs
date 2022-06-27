namespace LetsPet854.Domain.Common
{
    public class Contact
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string AdditionalAddressInfo { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }

        public Contact(string street, int number, string district,
            string city, string state, string zipcode,
            string mobileNumber, string email,
            string phone = "", string addInfo = "")
        {
            Street = street;
            Number = number;
            AdditionalAddressInfo = addInfo;
            District = district;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
            MobileNumber = mobileNumber;
            Email = email;
        }

        public void UpdateAdress(string street, int number, string district,
            string city, string state, string zipcode,
            string mobileNumber, string email,
            string phone = "", string addInfo = "")
        {
            Street = street;
            Number = number;
            AdditionalAddressInfo = addInfo;
            District = district;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
            MobileNumber = mobileNumber;
            Email = email;
        }
    }
}

