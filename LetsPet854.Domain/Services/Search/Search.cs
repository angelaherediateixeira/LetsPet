using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    internal class Search
    {
        public static void TypeSearch(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Type)
                {
                    Console.WriteLine($"Nome do serviço: {service.Name}");
                    Console.Write("Informações do serviço: ");
                    Console.Write(service.Type);
                    if (service.GroomingType != null)
                    {
                        Console.Write($" {service.GroomingType}");
                    }
                    Console.Write($"; Espécie: {service.Species}; ");
                    Console.Write($"; Porte {service.Size}; ");
                    Console.Write($"Serviço especial: {service.Special}; ");
                    Console.Write($"Loção: {service.Lotion}; ");
                    Console.Write($"Tempo: {service.ServiceTime}h; ");
                    Console.WriteLine($"Preço: {service.Price}.");
                }
            }

        }

        public static void SizeOrSpeciesSearch(string search)
        {

            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Species || search == service.Size)
                {
                    Console.WriteLine($"Nome do serviço: {service.Name}");
                    Console.Write("Informações do serviço: ");
                    Console.Write(service.Type);
                    if (service.GroomingType != null)
                    {
                        Console.Write($" {service.GroomingType}");
                    }
                    Console.Write($"; Espécie: {service.Species}; ");
                    Console.Write($"; Porte {service.Size}; ");
                    Console.Write($"Serviço especial: {service.Special}; ");
                    Console.Write($"Loção: {service.Lotion}; ");
                    Console.Write($"Tempo: {service.ServiceTime}h; ");
                    Console.WriteLine($"Preço: {service.Price}.");
                }
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
                    TypeSearch("Banho");
                }
                else if (input == 2)
                {
                    TypeSearch("Tosa");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Digite um porte ou espécie");
                search = Console.ReadLine();
                SizeOrSpeciesSearch(search);
            }
        }
    }
}
