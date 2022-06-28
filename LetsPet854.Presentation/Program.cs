using LetsPet854.Domain.Pets;
using LetsPet854.Domain.Services;
using LetsPet854.Presentation.Animals;
using LetsPet854.Presentation.Pets;

namespace LetsPet854.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Let's Pet");

            Console.WriteLine(AnimalScrens.MenuPet);
            Navigation.MenuPrincipal();//menu Pet Tutor

            MenuEmployee.DefaultMenu();//menu Employee

            ServicesMain.DefaultMenu(); //menu Services
        }
    }
}