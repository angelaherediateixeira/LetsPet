using LetsPet854.Business.Common;
using LetsPet854.Domain.Employees;

namespace LetsPet854.Presentation
{
    public static class PrintEmployee
    {
        public static void PrintSelectedEmployee(Employee employee)
        {
            Console.Clear();
            Console.WriteLine($@"
-------- Ficha do funcionário ---------;
Nome do colaborador: {employee.Name}
CPF: {employee.Cpf}
Nascimento: {employee.BirthDate:dd/MM/yyyy}
Data de registro: {employee.RegisterDate:dd/MM/yyyy}
{ (employee.ActiveEmployee ? "Funcinário Ativo" : "Funcionário Inativo \n Data de Demissão: {employee.DismissalDate:dd/MM/yyyy}")}

--- Informações de contrato ---
");
            foreach (var Valor in employee.Salaries)
            {
                Console.WriteLine($"Data Efetiva {Valor.Key:dd/MM/yyyy} Valor do Salário: {Valor.Value}");
            }
            Console.WriteLine($@"

--- Informações de contato ---
Endereço: {employee.PersonContact.Street}, Nº{employee.PersonContact.Number} - {employee.PersonContact.District},{employee.PersonContact.City} - {employee.PersonContact.State}, {employee.PersonContact.ZipCode}
Telefone celular: {employee.PersonContact.MobileNumber}
Email: {employee.PersonContact.Email}");

            if (!string.IsNullOrWhiteSpace(employee.PersonContact.AdditionalAddressInfo))
            {
                Console.WriteLine($"Informação adicionais: {employee.PersonContact.AdditionalAddressInfo}");
            }
            if (!string.IsNullOrWhiteSpace(employee.PersonContact.Phone))
            {
                Console.WriteLine($"Informação adicionais: {employee.PersonContact.Phone}");
            }
            Console.WriteLine($@"
--- Informações bancárias ---
Banco: {employee.BankData.Bank}
Agência: {employee.BankData.Agency}
Nº da conta: {employee.BankData.AccountNumber}
- Informações para pagamento -
Salário: ${employee.GetSalary()}

PIX\nTipo: {employee.BankData.PixType}
Chave: {employee.BankData.Pix}

--- Serviços prestados ---
Espécies atendidas:");
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
        public static void PrintListEmployee(List<Employee> employeeSearchResult)
        {
            Console.Clear();
            Console.WriteLine("--- Lista de funcionários ---");

            for (int i = 0; i < employeeSearchResult.Count(); i++)
            {
                Console.WriteLine($" {i + 1} - {employeeSearchResult[i].Name}");
            }
            int response;
            do
            {
                response = Validation.ValidatePositiveIntInput("Digite o numero do funcionário desejado:");
                if (response > employeeSearchResult.Count() || response == 0) Console.WriteLine("Numero inválido");
            } while (response > employeeSearchResult.Count() || response == 0);
            PrintSelectedEmployee(employeeSearchResult[response - 1]);
        }
    }
}
