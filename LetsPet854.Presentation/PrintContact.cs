using LetsPet854.Domain.Common;

namespace LetsPet854.Presentation
{
    public static class PrintContact
    {
        public static void PrintContactInfo(Contact contact)
        {
            Console.WriteLine($@"

--- Informações de contato ---
Endereço: {contact.Street}, Nº{contact.Number} - {contact.District},{contact.City} - {contact.State}, {contact.ZipCode}
Telefone celular: {contact.MobileNumber}
Email: {contact.Email}");

            if (!string.IsNullOrWhiteSpace(contact.AdditionalAddressInfo))
            {
                Console.WriteLine($"Informação adicionais: {contact.AdditionalAddressInfo}");
            }
            if (!string.IsNullOrWhiteSpace(contact.Phone))
            {
                Console.WriteLine($"Informação adicionais: {contact.Phone}");
            }
        }
    }
}
