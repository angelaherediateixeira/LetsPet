using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet_Employees.Enums;

namespace LetsPet_Employees
{
    public class EmployeeRegister
    {
        List<Employee> EmployeesList = new List<Employee>();

        public void CreateEmployee()
        {

            Console.WriteLine("Cadastrando Funcionário: ");

            string cpf;
            string name;
            DateTime birthDate;
            string bankCode;
            string agency;
            string accountNumber;
            string pixType;
            string pixKey;
            decimal salary;

            string aux;

            do
            {
                Console.WriteLine("Digite o CPF do funcionário:");
                aux = Console.ReadLine();
                Validation.IsCpfValid(aux);
                Console.ReadKey();

            } while (!Validation.IsCpfValid(aux));
            cpf = aux;
            Console.Clear();

            do
            {
                Console.WriteLine("Digite o nome do funcionário:");
                aux = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(aux))
                    Console.WriteLine("Nome digitado está em branco");

            } while (!String.IsNullOrWhiteSpace(aux));
            name = aux;
            Console.Clear();

            do
            {
                Console.WriteLine("Digite a data de nascimento do funcionário:");
                aux = Console.ReadLine();
                Validation.IsBirthDateValid(aux);

            } while (!Validation.IsBirthDateValid(aux));
            birthDate = Convert.ToDateTime(aux);
            Console.Clear();

            do
            {
                Console.WriteLine("Digite o código do banco:");
                aux = Console.ReadLine();
                Validation.IsBankCodeValid(aux);
            } while (!Validation.IsBankCodeValid(aux));
            bankCode = aux;
            Console.Clear();

            do
            {
                Console.WriteLine("Digite o número da agência:");
                aux = Console.ReadLine();
                Validation.IsAgencyCodeValid(aux);

            } while (!Validation.IsAgencyCodeValid(aux));
            agency = aux;
            Console.Clear();

            do
            {
                Console.WriteLine("Digite o número da conta:");
                aux = Console.ReadLine();
                Validation.IsAccountValid(aux);

            } while (!Validation.IsAccountValid(aux));
            accountNumber = aux;
            Console.Clear();

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
            Console.Clear();
            bool exit = false;

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
                    Validation.IsCellphoneValid(aux);
                    if (Validation.IsCellphoneValid(aux))
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
            Console.Clear();

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
            Console.Clear();

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
                speciesAnimals.Add(Species.Dog);
            if (aux.Equals("2"))
                speciesAnimals.Add(Species.Cat);
            if (aux.Equals("3"))
            {
                speciesAnimals.Add(Species.Dog);
                speciesAnimals.Add(Species.Cat);
            }
            Console.Clear();

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

            List<TypeService> serviceTypes = new List<TypeService>();

            if (aux.Equals("1"))
                serviceTypes.Add(TypeService.Bath);
            if (aux.Equals("2"))
                serviceTypes.Add(TypeService.Grooming);
            if (aux.Equals("3"))
            {
                serviceTypes.Add(TypeService.Bath);
                serviceTypes.Add(TypeService.Grooming);
            }

            do
            {
                Console.WriteLine("Digite o porte de animal que o funcionário irá atender: \n1 - Pequeno porte \n2 - Grande porte \n3- Ambos ");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(aux.Equals("1") || aux.Equals("2") || aux.Equals("3")));

            List<SizeAnimal> sizeAnimals = new List<SizeAnimal> ();

            if (aux.Equals("1"))
                sizeAnimals.Add(SizeAnimal.Small);
            if (aux.Equals("2"))
                sizeAnimals.Add(SizeAnimal.Large);
            if (aux.Equals("3"))
            {
                sizeAnimals.Add(SizeAnimal.Small);
                sizeAnimals.Add(SizeAnimal.Large);
            }

            do
            {
                Console.WriteLine("O funcionário consegue lidar com animais que precisam de necessidades especiais? \n1 - sim \n 2 - não");
                aux = Console.ReadLine().Trim();
                if (!(aux.Equals("1") || aux.Equals("2")))
                {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    Console.WriteLine();
                }
            } while (!(aux.Equals("1") || aux.Equals("2")));

            bool specialNeeds = false;
            if(aux.Equals("1"))
                specialNeeds = true;

            do
            {
                Console.WriteLine("O funcionário consegue lidar com animais agressigos? \n1 - sim \n2 - não");
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

            if(EmployeesList.Count<Employee>() % 2 == 1)
            {
                defaultSchedule[1] = Convert.ToDateTime("13:00:00");
                defaultSchedule[2] = Convert.ToDateTime("14:00:00");
            }

            BankInfo bankInfo = new BankInfo(bankCode, agency, accountNumber, pixType, pixKey);
            EmployeeServices employeeServices = new EmployeeServices(sizeAnimals, serviceTypes, speciesAnimals, specialNeeds, agressiveAnimal);
            Employee newEmployee = new Employee(cpf, name, birthDate, bankInfo, salary, employeeServices, defaultSchedule);

            EmployeesList.Add(newEmployee);
        }
    }
}
