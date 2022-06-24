using LetsPet_Employees;
using LetsPet_Employees.Enums;

namespace LetsPet854.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister Teste = new();

            List<SizeAnimal> animals = new List<SizeAnimal>();
            animals.Add(SizeAnimal.Large);

            List<TypeService> typeServices = new List<TypeService>();
            typeServices.Add(TypeService.Grooming);

            List<Species> species = new List<Species>();
            species.Add(Species.Cat);

            DateTime[] DateTimeTeste = new DateTime[]{ new DateTime(1,1,1,9,0,0) , new DateTime(1, 1, 1, 12, 0, 0), new DateTime(1, 1, 1, 13, 0, 0), new DateTime(1, 1, 1, 18, 0, 0) };

            BankInfo BankInfoTeste = new BankInfo("Banco do Brasil", "02349-32", "123451", "cpf", "09570524642");

            EmployeeServices employeeServicesTeste = new(animals,typeServices, species, false, true);


            Employee NovoEmp = new("09570524642", "Marco", new DateTime(2000, 09, 22), BankInfoTeste, 1000.00M, employeeServicesTeste, DateTimeTeste);
            Teste.EmployeesList.Add(NovoEmp);

            NovoEmp = new("09570524642", "Marco Batista", new DateTime(2000, 09, 22), BankInfoTeste, 1000.00M, employeeServicesTeste, DateTimeTeste);
            Teste.EmployeesList.Add(NovoEmp);

            NovoEmp = new("09570524642", "Marco Antonio", new DateTime(2000, 09, 22), BankInfoTeste, 1000.00M, employeeServicesTeste, DateTimeTeste);
            Teste.EmployeesList.Add(NovoEmp);

            Teste.SearchEmployeeScheduleByName("Marco");
        }
    }
}