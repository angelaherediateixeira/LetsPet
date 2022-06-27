using LetsPet854.Business.Common;
using LetsPet854.Business.Employees;

namespace LetsPet854.Presentation
{
    public class MenuEmployee
    {
        private static int response;
        private static bool validation = false;
        private static List<string> OptionsList = new List<string> {
            "1 - Cadastrar Funcionário",
            "2 - Pesquisar Funcionário",
            "3 - Consultar Agenda Funcionário",
            "4 - Sair"
        };
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
                        CreateEmployee.CreateNewEmployee();
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
        private static void SearchInterface()
        {
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
            switch (response)
            {
                case 1:
                    Console.WriteLine("Digite um nome:");
                    var response = Console.ReadLine();
                    var employeesSearchResult = SearchEmployees.SearchEmployeeByName(response);
                    if (employeesSearchResult == null)
                    {
                        Console.ReadKey();
                        break;
                    }
                    PrintEmployee.PrintListEmployee(employeesSearchResult);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite um CPF:");
                    response = Console.ReadLine();
                    var employeeSearchResult = SearchEmployees.SearchEmployeeByCPF(response);
                    if (employeeSearchResult == null) {
                        Console.ReadKey();
                        break;
                    }
                    PrintEmployee.PrintSelectedEmployee(employeeSearchResult);
                    Console.ReadKey();
                    break;
                default:
                    return;
            }
        }
    }
}
