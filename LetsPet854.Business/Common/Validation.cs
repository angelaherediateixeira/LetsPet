using System.Text.RegularExpressions;

namespace LetsPet854.Business.Common
{
    public class Validation
    {
        public static bool IsZipCodeValid(string zipCode)
        {
            Regex RgxZipCode = new(@"^\d{5}-\d{3}$");
            if (!RgxZipCode.Match(zipCode).Success)
            {
                Console.WriteLine("Cep digitado inválido!\nDigite o CEP no formato xxxxx-xxx");
                return false;
            }
            return true;
        }
        public static bool IsPhoneValid(string phone)
        {
            Regex RgxPhone = new(@"^\(?\d{2}\)?\d{4,5}-?\d{4}$");
            if (!RgxPhone.Match(phone).Success)
            {
                Console.WriteLine("Telefone digitado inválido!\nDigite no formato (12)12345-1234");
                return false;
            }
            return true;
        }
        public static bool IsCpfValid(string cpf)
        {
            Regex RgxCpf = new(@"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$");
            if (!RgxCpf.Match(cpf).Success)
            {
                Console.WriteLine("Cpf digitado inválido!\nDigite no formato 123.123.123-12");
                return false;
            }
            return true;
        }
        public static bool IsEmailValid(string email)
        {
            Regex RgxEmail = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!RgxEmail.Match(email).Success)
            {
                Console.WriteLine("Email digitado inválido! \nDigite no formato abcd@abcd.com ");
                return false;
            }
            return true;
        }
        public static bool IsRandomKeyValid(string randomKey)
        {
            Regex RgxRandKey = new(@"^(\w+${8})\-(\w+${4})\-(\w+${4})\-(\w+${4})\-(\w+${12})");
            if (!RgxRandKey.Match(randomKey).Success)
            {
                Console.WriteLine("Chave aleatóroa inválida! \nDigiget no formato ********-****-****-****-************");
                return false;
            }
            return true;
        }
        public static bool IsBirthDateValid(string birthDate)
        {
            Regex RgxBirth = new(@"\d{2}/\d{2}/\d{4}");

            if (!RgxBirth.Match(birthDate).Success)
            {
                Console.WriteLine("Data de nascimento inválida! \nDigite no formato dd/mm/aaaa");
                return false;
            }

            return true;
        }
        public static bool IsBankCodeValid(string bankCode)
        {
            Regex RgxBankCode = new(@"^\d{3}$");
            if (!RgxBankCode.Match(bankCode).Success)
            {
                Console.WriteLine("Código do banco inválido! \nDigite no formato: 123");
                return false;
            }
            return true;
        }
        public static bool IsAgencyCodeValid(string agencyCode)
        {
            Regex RgxAgencyCode = new(@"^\d{4,5}$");
            if (!RgxAgencyCode.Match(agencyCode).Success)
            {
                Console.WriteLine("Codigo da agência inválido! \nDigite no formato: 12341");
                return false;
            }
            return true;
        }
        public static bool IsAccountValid(string account)
        {
            Regex RgxAccount = new(@"^\d{8}\-\d{1}$");
            if (!RgxAccount.Match(account).Success)
            {
                Console.WriteLine("Número da conta inválido! \n Digite no formato: 12345678-1");
                return false;
            }
            return true;
        }
        public static string ValidateStringInput(string question, string ErrorMessage = "O input é inválido")
        {
            string response;
            bool validation;
            do
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
                validation = string.IsNullOrWhiteSpace(response);

                if (validation)
                {
                    Console.WriteLine(ErrorMessage);
                }
            } while (validation);

            return response;
        }
        public static int ValidatePositiveIntInput(string question, string ErrorMessage = "O input é inválido")
        {
            int response;
            bool validation;
            do
            {
                Console.WriteLine(question);
                validation = !int.TryParse(Console.ReadLine(), out response) || response <= 0;

                if (validation)
                {
                    Console.WriteLine(ErrorMessage);
                }
            } while (validation);
            return response;
        }
        public static string ValidateZipCodeInput(string question, string ErrorMessage = "Cep digitado inválido!\nDigite o CEP no formato xxxxx-xxx")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsZipCodeValid(response));
            return response;
        }
        public static string ValidatePhoneInput(string question, string ErrorMessage = "Telefone digitado inválido!\nDigite no formato (12)12345-1234")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsPhoneValid(response));
            return response;
        }
        public static string ValidadeEmailInput(string question, string ErrorMessage = "Email digitado inválido! \nDigite no formato abcd@abcd.com")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsEmailValid(response));
            return response;
        }
        public static string ValidateCPFInput(string question, string ErrorMessage = "Cpf digitado inválido! Digite no formato 123.123.123-12")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsCpfValid(response));
            return response;
        }
        public static string ValidateDateInput(string question, string ErrorMessage = "Data de nascimento inválida! Digite no formato dd/mm/aaaa")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsBirthDateValid(response));
            return response;
        }
        public static string ValidateBankCodeInput(string question, string ErrorMessage = "Código de banco errado. Digite apenas 3 dígitos")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsBankCodeValid(response));
            return response;
        }
        public static string ValidateAgencyNumberInput(string question, string ErrorMessage = "Código de agência errado. Digite apenas 4 ou 5 dígitos")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsAgencyCodeValid(response));
            return response;
        }
        public static string ValidateAccountNumberInput(string question, string ErrorMessage = "Código de agência errado. Digite apenas 4 ou 5 dígitos")
        {
            string response;
            do
            {
                response = ValidateStringInput(question, ErrorMessage);
            } while (!IsAccountValid(response));
            return response;
        }
    }
}
