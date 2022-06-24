using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet_Employees.Enums;

namespace LetsPet_Employees
{
    public static class EmployeeRegister
    {
        private static int response;
        private static bool validation = false;
        private static List<string> OptionsList = new List<string> {
            "1 - Cadastrar Funcionário",
            "2 - Pesquisar Funcionário",
            "3 - Consultar Agenda Funcionário",
            "4 - Sair"
        };
        public static List<Employee> EmployeesList { get; private set; } = new List<Employee>();
        public static void DefaultMenu()
        {
            MenuHeader();
            do
            {
                do
                {
                    response = Validation.ValidatePositiveIntInput("Selecione uma opção:");
                    if (response > OptionsList.Count() || response <= 0)
                    {
                        validation = true;
                        Console.WriteLine("Essa opção não existe!");
                    }
                } while (validation);

                switch (response)
                {
                    case 1:
                        CreateEmployee();
                        MenuHeader();
                        break;
                    case 2:
                        SearchInterface();
                        MenuHeader();
                        break;
                    case 3:
                        MenuHeader();
                        Console.WriteLine("Opção em desenvolvimento");
                        Console.ReadKey();
                        break;
                    case 4:
                        return;
                }
            } while (true);
        }
        private static void CreateEmployee()
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
            do
            {
                Console.WriteLine("Digite o código do banco:");
                aux = Console.ReadLine();
                Validation.IsBankCodeValid(aux);
            } while (!Validation.IsBankCodeValid(aux));
            bankCode = aux;

            Header();
            do
            {
                Console.WriteLine("Digite o número da agência:");
                aux = Console.ReadLine();
                Validation.IsAgencyCodeValid(aux);

            } while (!Validation.IsAgencyCodeValid(aux));
            agency = aux;

            Header();
            do
            {
                Console.WriteLine("Digite o número da conta:");
                aux = Console.ReadLine();
                Validation.IsAccountValid(aux);

            } while (!Validation.IsAccountValid(aux));
            accountNumber = aux;

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
                speciesAnimals.Add(Species.Dog);
            if (aux.Equals("2"))
                speciesAnimals.Add(Species.Cat);
            if (aux.Equals("3"))
            {
                speciesAnimals.Add(Species.Dog);
                speciesAnimals.Add(Species.Cat);
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

            Header();
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

            List<SizeAnimal> sizeAnimals = new List<SizeAnimal>();

            if (aux.Equals("1"))
                sizeAnimals.Add(SizeAnimal.Small);
            if (aux.Equals("2"))
                sizeAnimals.Add(SizeAnimal.Large);
            if (aux.Equals("3"))
            {
                sizeAnimals.Add(SizeAnimal.Small);
                sizeAnimals.Add(SizeAnimal.Large);
            }

            Header();
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
            if (aux.Equals("1"))
                specialNeeds = true;

            Header();
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

            if (EmployeesList.Count<Employee>() % 2 == 1)
            {
                defaultSchedule[1] = Convert.ToDateTime("13:00:00");
                defaultSchedule[2] = Convert.ToDateTime("14:00:00");
            }

            BankInfo bankInfo = new BankInfo(bankCode, agency, accountNumber, pixType, pixKey);
            EmployeeServices employeeServices = new EmployeeServices(sizeAnimals, serviceTypes, speciesAnimals, specialNeeds, agressiveAnimal);
            Employee newEmployee = new Employee(cpf, name, birthDate, bankInfo, salary, employeeServices, defaultSchedule);

            EmployeesList.Add(newEmployee);
        }

        public static void SearchEmployeeByCPF(string CPF)
        {
            var FilterdEmployee = (
                from employee in EmployeesList
                where employee.Cpf.Equals(CPF)
                select employee
                );
            if (FilterdEmployee.Count() == 0)
            {
                Console.WriteLine($"Nenhum funcionário com o CPF {CPF} foi encontrado no sistema.");
                return;
            }

            foreach (Employee employee in FilterdEmployee)
            {
                PrintEmployee(employee);
                return;
            }
        }

        public static void SearchEmployeeByName(string Name)
        {
            var FilterdEmployees = (
                from employee in EmployeesList
                where employee.Name.Contains(Name)
                select employee
                );
            var ListResult = FilterdEmployees.ToList();

            if (ListResult.Count() == 0)
            {
                Console.WriteLine($"Nenhum funcionário com o nome {Name} foi encontrado no sistema.");
                return;
            }

            Console.Clear();
            Console.WriteLine("--- Lista de funcionários ---");

            for (int i = 0; i < ListResult.Count(); i++)
            {
                Console.WriteLine($" {i + 1} - {ListResult[i].Name}");
            }
            int response;
            do
            {
                response = Validation.ValidatePositiveIntInput("Digite o numero do funcionário desejado:");
                if (response > ListResult.Count() || response == 0) Console.WriteLine("Numero inválido");
            } while (response > ListResult.Count() || response == 0);

            PrintEmployee(ListResult[response - 1]);
        }

        public static void SearchEmployeeScheduleByCPF(string CPF)
        {
            var FilterdEmployee = (
                from employee in EmployeesList
                where employee.Cpf.Equals(CPF)
                select employee
                );
            if (FilterdEmployee.Count() == 0)
            {
                Console.WriteLine($"Nenhum funcionário com o CPF {CPF} foi encontrado no sistema.");
                return;
            }
            foreach (Employee employee in FilterdEmployee)
            {
                PrintEmployeeSchedule(employee);
                return;
            }
        }

        public static void SearchEmployeeScheduleByName(string Name)
        {
            var FilterdEmployees = (
                    from employee in EmployeesList
                    where employee.Name.Contains(Name)
                    select employee
                    );
            var ListResult = FilterdEmployees.ToList();

            if (ListResult.Count() == 0)
            {
                Console.WriteLine($"Nenhum funcionário com o nome {Name} foi encontrado no sistema.");
                return;
            }

            Console.Clear();
            Console.WriteLine("--- Lista de funcionários ---");

            for (int i = 0; i < ListResult.Count(); i++)
            {
                Console.WriteLine($" {i + 1} - {ListResult[i].Name}");
            }
            int response;
            do
            {
                response = Validation.ValidatePositiveIntInput("Digite o numero do funcionário desejado:");
                if (response > ListResult.Count() || response == 0) Console.WriteLine("Numero inválido");
            } while (response > ListResult.Count() || response == 0);

            PrintEmployeeSchedule(ListResult[response - 1]);
        }
        //Mudar isso daqui pra private dps dos testes 
        private static void PrintEmployee(Employee employee)
        {
            Console.Clear();
            Console.WriteLine("-------- Ficha do funcionário ---------");
            Console.WriteLine($"Nome do colaborador: {employee.Name}");
            Console.WriteLine($"CPF: {employee.Cpf}");
            Console.WriteLine($"Nascimento: {employee.BirthDate:dd/MM/yyyy}");
            Console.WriteLine($"Data de registro: {employee.RegisterDate:dd/MM/yyyy}");
            if (employee.ActiveEmployee)
            {
                Console.WriteLine("Funcinário Ativo");
            }
            else
            {
                Console.WriteLine($"Funcionário Inativo \n Data de Demissão: {employee.DismissalDate:dd/MM/yyyy}");
                Console.WriteLine();

                Console.WriteLine("--- Informações de contrato ---");
                foreach (var Valor in employee.Salaries)
                {
                    Console.WriteLine($"Data Efetiva {Valor.Key:dd/MM/yyyy} Valor do Salário: {Valor.Value}");
                }
                return;
            }
            Console.WriteLine();

            Console.WriteLine("--- Informações de contato ---");
            Console.WriteLine($"Endereço: {employee.PersonContact.Street}, Nº{employee.PersonContact.Number} - {employee.PersonContact.District}," +
                $"{employee.PersonContact.City} - {employee.PersonContact.State}, {employee.PersonContact.ZipCode}");
            Console.WriteLine($"Telefone celular: {employee.PersonContact.MobileNumber}");
            Console.WriteLine($"Email: {employee.PersonContact.Email}");

            if (!string.IsNullOrWhiteSpace(employee.PersonContact.AdditionalAdressInfo))
            {
                Console.WriteLine($"Informação adicionais: {employee.PersonContact.AdditionalAdressInfo}");
            }
            if (!string.IsNullOrWhiteSpace(employee.PersonContact.Phone))
            {
                Console.WriteLine($"Informação adicionais: {employee.PersonContact.Phone}");
            }
            Console.WriteLine();

            Console.WriteLine($"--- Informações bancárias ---");
            Console.WriteLine($"Banco: {employee.BankData.Bank}");
            Console.WriteLine($"Agência: {employee.BankData.Agency}");
            Console.WriteLine($"Nº da conta: {employee.BankData.AccountNumber}");
            Console.WriteLine($"- Informações para pagamento -");
            Console.WriteLine($"Salário: ${employee.GetSalary()}");
            Console.WriteLine();
            Console.WriteLine($"PIX\nTipo: {employee.BankData.PixType}\nChave: {employee.BankData.Pix}");
            Console.WriteLine();

            Console.WriteLine("--- Serviços prestados ---");
            Console.WriteLine("Espécies atendidas:");
            foreach (var Specie in employee.ServicesType.Species)
            {
                Console.WriteLine($" - {Specie}");
            }

            Console.WriteLine("Portes atendidos:");
            foreach (var Size in employee.ServicesType.Sizes)
            {
                Console.WriteLine($" - {Size}");
            }

            Console.WriteLine("Tipos de serviços:");
            foreach (var Type in employee.ServicesType.Types)
            {
                Console.WriteLine($" - {Type}");
            }
            var response = employee.ServicesType.MeetsSpecialNeeds ? "Atende" : "Não atende";
            Console.WriteLine($"{response} animais com necessidades especiais.");

            response = employee.ServicesType.MeetsAggressiveAnimal ? "Atende" : "Não atende";
            Console.WriteLine($"{response} animais agressivos.");
            Console.WriteLine();
        }
        private static void PrintEmployeeSchedule(Employee employee)
        {
            Console.Clear();
            Console.WriteLine($"--- Agenda do funcionário {employee.Name}---");
            Console.WriteLine($"Horário de entrada: {employee.Schedule[0]:HH:mm}");
            Console.WriteLine($"Horário de inicio intervalo: {employee.Schedule[1]:HH:mm}");
            Console.WriteLine($"Horário de fim intervalo: {employee.Schedule[2]:HH:mm}");
            Console.WriteLine($"Horário de saída: {employee.Schedule[3]:HH:mm}");
        }
        private static void Header()
        {
            Console.Clear();
            Console.WriteLine("------- Cadastro de funcionário --------");
        }
        private static void MenuHeader()
        {
            Console.Clear();
            Console.WriteLine("------- MENU DE FUNCIONÁRIOS -----------");
            foreach (var Option in OptionsList)
            {
                Console.WriteLine(Option);
            }
            Console.WriteLine();
        }
        private static void MenuSearch()
        {
            Console.Clear();
            Console.WriteLine("------- MENU DE FUNCIONÁRIOS -----------");
            Console.WriteLine("Opções de pesquisa:");
            Console.WriteLine(" 1 - Pesquisar por Nome");
            Console.WriteLine(" 2 - Pesquisar por CPF");
            Console.WriteLine(" 3 - Voltar ao menu");
        }
        private static void SearchInterface() {
            MenuSearch();
            do
            {
                response = Validation.ValidatePositiveIntInput("Selecione uma opção:");
                if (response > 3 || response <= 0)
                {
                    validation = true;
                    Console.WriteLine("Essa opção não existe!");
                }
            } while (validation);
            switch (response) {
                case 1:
                    Console.WriteLine("Digite um nome:");
                    var response = Console.ReadLine();
                    SearchEmployeeByName(response);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite um CPF:");
                    response = Console.ReadLine();
                    SearchEmployeeByCPF(response);
                    Console.ReadKey();
                    break;
                default:
                    return;
            }
        }
    }
}
