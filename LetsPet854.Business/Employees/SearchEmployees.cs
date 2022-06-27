using LetsPet854.Domain.Employees;
namespace LetsPet854.Business.Employees
{
    public class SearchEmployees
    {
        public static Employee SearchEmployeeByCPF(string CPF)
        {
            var FilteredEmployee = (
                from employee in EmployeeRegister.EmployeesList
                where employee.Cpf.Equals(CPF)
                select employee
                );
            if (FilteredEmployee.Count() == 0)
            {
                Console.WriteLine($"Nenhum funcionário com o CPF {CPF} foi encontrado no sistema.");
                return null;
            }
            return FilteredEmployee.First();
        }

        public static List<Employee> SearchEmployeeByName(string Name)
        {
            var FilteredEmployees = (
                from employee in EmployeeRegister.EmployeesList
                where employee.Name.Contains(Name)
                select employee
                ).ToList();

            if (FilteredEmployees.Count() == 0)
            {
                Console.WriteLine($"Nenhum funcionário com o nome {Name} foi encontrado no sistema.");
                return null;
            }

            return FilteredEmployees;
        }

        public static void SearchEmployeeScheduleByCPF(string CPF)
        {
            // Falta implementar. Aguardando desenvolvimento da squad de agenda
        }

        public static void SearchEmployeeScheduleByName(string Name)
        {
            // Falta implementar. Aguardando desenvolvimento da squad de agenda
        }
        private static void PrintEmployeeSchedule(Employee employee)
        {
            // Falta implementar. Aguardando desenvolvimento da squad de agenda
            //Console.Clear();
            //Console.WriteLine($"--- Agenda do funcionário {employee.Name}---");
            //Console.WriteLine($"Horário de entrada: {employee.Schedule[0]:HH:mm}");
            //Console.WriteLine($"Horário de inicio intervalo: {employee.Schedule[1]:HH:mm}");
            //Console.WriteLine($"Horário de fim intervalo: {employee.Schedule[2]:HH:mm}");
            //Console.WriteLine($"Horário de saída: {employee.Schedule[3]:HH:mm}");
        }
    }
}
