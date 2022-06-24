using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    internal class Search
    {
        public static void Options()
        {
            string search;
            int input;
            Console.WriteLine("Qual o tipo de pesquisa que deseja realizar?");
            Console.WriteLine("1 - Tipo de Serviços\n2 - Por porte ou espécie");
            while(!int.TryParse(Console.ReadLine(), out input) || (input < 1 || input > 2))
            {
                Console.WriteLine("Digite um valor válido:");
            }
            if (input == 1)
            {
                Console.WriteLine("Opções de serviço são:\n1 - Banho\n2 - Tosa");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    ShowInfo.ByType("Banho");
                }
                else if (input == 2)
                {
                    ShowInfo.ByType("Tosa");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Digite um porte ou espécie");
                search = Console.ReadLine();
                ShowInfo.BySizeOrSpecies(search);
            }
        }
    }
}
