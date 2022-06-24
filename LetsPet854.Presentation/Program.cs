using LetsPet854.Domain.Services;
using LetsPet_Employees;

namespace LetsPet854.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Bem vindo ao Let's Pet");

            //ServicesMain.DefaultMenu(); // fazer menu Pets
            //ServicesMain.DefaultMenu(); //menu Services
            EmployeeRegister.DefaultMenu();
        }
    }
}