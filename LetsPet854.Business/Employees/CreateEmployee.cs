using LetsPet854.Business.Common;
using LetsPet854.Domain.Common;
using LetsPet854.Domain.Common.Enuns;
using LetsPet854.Domain.Employees;

namespace LetsPet854.Business.Employees
{
    public class CreateEmployee
    {
        public static void CreateNewEmployee()
        {
            string name;
            string cpf;
            DateTime birthDate;
            string bankCode;
            string agency;
            string accountNumber;
            string pixType;
            string pixKey;
            decimal salary;
            string aux;
            Header();
            name = Validation.ValidateStringInput("Digite o nome do funcionário", "Nome digitado está em branco");
            Header();
            cpf = Validation.ValidateCPFInput("Digite o CPF do funcionário:");
            Header();            
            birthDate = Convert.ToDateTime(Validation.ValidateDateInput("Digite a data de nascimento do funcionário:"));
            Header();
            bankCode = Validation.ValidateBankCodeInput("Digite o código do banco:");

            Header();
            agency = Validation.ValidateAgencyNumberInput("Digite o número da agência:");

            Header();
            accountNumber = Validation.ValidateAccountNumberInput("Digite o número da conta:");

            Header();
            do
            {
                Console.WriteLine("Digite o tipo da chave pix que deseja usar: \n1 - CPF \n2 - Email \n3 - Número de celular \n4 - Chave aleatória");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3") || aux.Equals("4")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente!");
                    Console.WriteLine();
                }

            } while (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3") || aux.Equals("4")));
            pixType = aux;
            bool exit = false;

            Header();
            do
            {
                while (!exit && pixType.Equals("1"))
                {
                    Console.WriteLine("Digite o CPF da chave pix: ");
                    aux = Console.ReadLine();
                    Validation.IsCpfValid(aux);
                    if (Validation.IsCpfValid(aux))
                        exit = true;
                }
                while (!exit && pixType.Equals("2"))
                {
                    Console.WriteLine("Digite o email da chave pix: ");
                    aux = Console.ReadLine();
                    Validation.IsEmailValid(aux);
                    if (Validation.IsEmailValid(aux))
                        exit = true;
                }
                while (!exit && aux.Equals("3"))
                {
                    Console.WriteLine("Digite o número de celular da chave pix: ");
                    aux = Console.ReadLine();
                    Validation.IsPhoneValid(aux);
                    if (Validation.IsPhoneValid(aux))
                        exit = true;
                }
                while (exit && aux.Equals("4"))
                {
                    Console.WriteLine("Digite a chave pix aleatória: ");
                    aux = Console.ReadLine();
                    Validation.IsRandomKeyValid(aux);
                    if (Validation.IsRandomKeyValid(aux))
                        exit = true;
                }

            } while (!exit);
            pixKey = aux;

            Header();
            do
            {
                Console.WriteLine("Digite o salário do funcionário: ");
                aux = Console.ReadLine().Trim();
                if (!Decimal.TryParse(aux, out salary))
                {
                    Console.WriteLine("Valor do salario digitado invalido, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(Decimal.TryParse(aux, out salary)));

            Header();
            do
            {
                Console.WriteLine("Digite a espécie de animal que o funcionário vai atender: \n1 - Cachorro \n2 - Gato \n3 - Ambos ");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")));

            List<Species> speciesAnimals = new List<Species>();

            if (aux.Equals("1"))
                speciesAnimals.Add(Species.Cachorro);
            if (aux.Equals("2"))
                speciesAnimals.Add(Species.Gato);
            if (aux.Equals("3"))
            {
                speciesAnimals.Add(Species.Cachorro);
                speciesAnimals.Add(Species.Gato);
            }

            Header();
            do
            {
                Console.WriteLine("Digite o tipo de serviços que o funcionário executará: \n1 - Banho \n2 - Tosa \n3 - Ambos");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }

            } while (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")));

            List<ServiceType> serviceTypes = new List<ServiceType>();

            if (aux.Equals("1"))
                serviceTypes.Add(ServiceType.Banho);
            if (aux.Equals("2"))
                serviceTypes.Add(ServiceType.Tosa);
            if (aux.Equals("3"))
            {
                serviceTypes.Add(ServiceType.Banho);
                serviceTypes.Add(ServiceType.Tosa);
            }
            Header();
            do
            {
                Console.WriteLine("Digite o porte de animal que o funcionário irá atender: \n1 - Pequeno porte \n2 - Grande porte \n3 - Ambos ");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")));

            List<BreedSize> sizeAnimals = new List<BreedSize>();

            if (aux.Equals("1"))
                sizeAnimals.Add(BreedSize.Pequeno);
            if (aux.Equals("2"))
                sizeAnimals.Add(BreedSize.Grande);
            if (aux.Equals("3"))
            {
                sizeAnimals.Add(BreedSize.Pequeno);
                sizeAnimals.Add(BreedSize.Grande);
            }

            Header();
            do
            {
                Console.WriteLine("O funcionário consegue lidar com animais que precisam de necessidades especiais? \n1 - Sim \n2 - Não");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(aux.Equals("1") || aux.Equals("2")));

            bool specialNeeds = false;
            if (aux.Equals("1"))
                specialNeeds = true;

            Header();
            do
            {
                Console.WriteLine("O funcionário consegue lidar com animais agressigos? \n1 - Sim \n2 - Não");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(aux.Equals("1") || aux.Equals("2")));

            bool agressiveAnimal = false;
            if (aux.Equals("1"))
                specialNeeds = true;

            DateTime[] defaultSchedule = new DateTime[4];
            defaultSchedule[0] = Convert.ToDateTime("09:00:00");
            defaultSchedule[1] = Convert.ToDateTime("12:00:00");
            defaultSchedule[2] = Convert.ToDateTime("13:00:00");
            defaultSchedule[3] = Convert.ToDateTime("18:00:00");

            if (EmployeeRegister.EmployeesList.Count % 2 == 1)
            {
                defaultSchedule[1] = Convert.ToDateTime("13:00:00");
                defaultSchedule[2] = Convert.ToDateTime("14:00:00");
            }

            BankInfo bankInfo = new BankInfo(bankCode, agency, accountNumber, pixType, pixKey);
            EmployeeServices employeeServices = new(sizeAnimals, serviceTypes, speciesAnimals, specialNeeds, agressiveAnimal);
            Contact employeeContact = CreateContact.GenerateContact();
            Employee newEmployee = new(cpf, name, employeeContact, birthDate, bankInfo, salary, employeeServices, defaultSchedule);

            EmployeeRegister.EmployeesList.Add(newEmployee);
        }
        private static void Header()
        {
            Console.Clear();
            Console.WriteLine("------- Cadastro de funcionário --------");
        }
    }
}
