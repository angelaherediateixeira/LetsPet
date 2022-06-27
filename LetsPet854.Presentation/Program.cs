using LetsPet_Employees;
using LetsPet854.Domain.Pets;
using LetsPet854.Domain.Services;
using LetsPet854.Presentation.Animals;

namespace LetsPet854.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Let's Pet");

            Console.WriteLine(AnimalScrens.MenuPet);

            ServicesMain.DefaultMenu(); //menu Services
            EmployeeRegister.DefaultMenu(); //menu Employee
        }
    }
}