using LetsPet854.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class ContactServices
    {

        public Contact RegisterContact()
        {
            string street, district, city, state, zipcode, mobileNumber, email, phone, addInfo;
            int number;

            Header();
            street = Validation.ValidateStringInput("Informe o nome da rua/avenida:", "O nome da Rua/Avenia é inválido.");

            Header();
            number = Validation.ValidatePositiveIntInput("Informe o número:", "O numero informado é inválido.");

            Header();
            district = Validation.ValidateStringInput("Informe o nome do bairro:", "O nome do bairro é inválido.");

            Header();
            city = Validation.ValidateStringInput("Informe o nome da cidade:", "O nome da cidade é inválida.");

            Header();
            state = Validation.ValidateStringInput("Informe o nome do estado:", "O nome do estado é inválido.");

            Header();
            zipcode = Validation.ValidateZipCodeInput("Informe o CEP");

            Header();
            mobileNumber = Validation.ValidatePhoneInput("Informe o numero de telefone:");

            Header();
            email = Validation.ValidadeEmailInput("Informe o email:");

            Header();
            if (OptionalInfos("Possuiu telefone fixo?"))
            {
                phone = mobileNumber = Validation.ValidatePhoneInput("Informe o numero de telefone fixo:", "Telefone digitado inválido!\nDigite no formato (12)1234-1234");
            }
            else
                phone = "";

            Header();
            if (OptionalInfos("Alguma informamação adicional?"))
            {
                addInfo = Validation.ValidateStringInput("Descreva a observação:", "O campo de observação está em branco.");
            }
            else
                addInfo = "";

            return new Contact(street, number, district, city, state, zipcode, mobileNumber, email, phone, addInfo);
        }
        private void Header()
        {
            Console.Clear();
            Console.WriteLine("------- CADASTRO DE CONTATO -------");
        }

        private bool OptionalInfos(string question, string ErrorMessage = "Input inválido.")
        {
            string response, options = "(S/N)";
            bool validation;
            do
            {
                Console.WriteLine($"{question} {options}");
                response = Console.ReadLine();
                response = response.ToUpper();
                validation = response != "S" && response != "N" || string.IsNullOrWhiteSpace(response);
                if (validation)
                {
                    Console.WriteLine(ErrorMessage);
                }
            } while (validation);

            if (response == "S") return true;

            return false;
        }

    }
}
