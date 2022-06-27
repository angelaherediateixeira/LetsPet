using LetsPet854.Domain.Pets;
using LetsPet854.Domain.Services;

namespace LetsPet854.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Let's Pet");

            //Navegation.MenuPet();//menu Pets
            //ServicesMain.DefaultMenu(); //menu Services
            //ServicesMain.DefaultMenu(); // fazer menu Pets
            //ServicesMain.DefaultMenu(); //menu Services
            MenuEmployee.DefaultMenu();
        }
    }
}