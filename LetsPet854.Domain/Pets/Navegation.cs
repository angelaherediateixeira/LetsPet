using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet854.Domain.Pets;

namespace LetsPet854.Domain.Pets
{
    public class Navegation
    {
        public static int optionInput;
        public static void MenuPet()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Cadastro de Pets e Tutores\n");
                Console.WriteLine(@"Selecione umas das opções abaixo:
1- Cadastrar Tutor
2- Cadastrar Pet
3- Consultar Tutor
4- Consultar Pet
5- Voltar ao menu principal");
                while (!int.TryParse(Console.ReadLine(), out optionInput) || (optionInput < 1 || optionInput > 5))
                {
                    Console.WriteLine("\nDigite um valor válido: ");
                }
                switch (optionInput)
                {
                    case 1:
                        Console.WriteLine("Tela para Cadastrar Tutor");
                        // Guardian.RegisterGuardian(); cadastrar pet
                        break;
                    case 2:
                        Console.WriteLine("Tela para Cadastrar Pet");
                        //Animal.RegisterAnimal();
                        break;
                    case 3:
                        Console.WriteLine("Tela para Consultar Tutor");
                        //Search.Options(); fazer consulta
                        break;
                    case 4:
                        Console.WriteLine("Tela para Consultar Pet");
                        //Search.Options(); fazer consulta
                        break;
                    case 5:
                        Console.WriteLine("volatr ao menu inicial");
                        // voltar a tela inicial
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (true);
        }





    }
}



