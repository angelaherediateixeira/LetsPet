using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Common
{
    public class Contact
    {
        protected string Street { get; set; }
        protected int Number { get; set; }
        protected string AdditionalAddressInfo { get; set; }
        protected string District { get; set; }
        protected string City { get; set; }
        protected string State { get; set; }
        protected string ZipCode { get; set; }
        protected string Phone { get; set; }
        protected string MobileNumber { get; set; }
        protected string Email { get; set; }

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

        public void PrintContact()
        {
            Console.WriteLine($"WhatsApp: {MobileNumber}");
            Console.WriteLine($"Telefone Fixo: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"CEP: {ZipCode}");
            Console.WriteLine($"Endereço: {Street}, {Number}");
            Console.WriteLine($"Complemento: {AdditionalAddressInfo}");
            Console.WriteLine($"Bairro:{District}");
            Console.WriteLine($"Cidade: {City} - {State}");
            Console.WriteLine("\nPETS DO TUTOR:");
        }


    }
}

