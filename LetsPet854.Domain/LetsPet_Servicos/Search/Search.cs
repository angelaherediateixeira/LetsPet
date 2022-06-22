using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    internal class Search
    {
        public static void ServicesSearch(string search)
        {
            var internalSearch = Registration.ServicesList.Where(s => s.Type == search);

            foreach (var service in internalSearch)
            {
                Console.WriteLine(service.Name);
            }
        }

        public static void Options()
        {
            string search;
            int input;
            Console.WriteLine("Qual o tipo de pesquisa que deseja realizar?");
            Console.WriteLine("1 - Tipo de Serviços\n2 - Por porte ou espécie");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Opções de serviço são:\n1 - Banho\n2 - Tosa");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    ServicesSearch("Banho");
                }
                else if (input == 2)
                {
                    ServicesSearch("Tosa");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Digite um porte ou espécie");
                search = Console.ReadLine();
                ServicesSearch(search);
            }
        }
    }
}
