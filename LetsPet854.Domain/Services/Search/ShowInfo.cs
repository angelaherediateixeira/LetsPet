using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public class ShowInfo
    {
        public static void ByType(string search)
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
                    Console.Write($"Porte {service.Size}; ");
                    Console.Write($"Serviço especial: {service.Special}; ");
                    Console.Write($"Loção: {service.Lotion}; ");
                    Console.Write($"Tempo: {service.ServiceTime}h; ");
                    Console.WriteLine($"Preço: {service.Price}.");
                }
            }

        }

        public static void ByName(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Name)
                {
                    Console.WriteLine($"Nome do serviço: {service.Name}");
                    Console.Write("Informações do serviço: ");
                    Console.Write(service.Type);
                    if (service.GroomingType != null)
                    {
                        Console.Write($" {service.GroomingType}");
                    }
                    Console.Write($"; Espécie: {service.Species}; ");
                    Console.Write($"Porte {service.Size}; ");
                    Console.Write($"Serviço especial: {service.Special}; ");
                    Console.Write($"Loção: {service.Lotion}; ");
                    Console.Write($"Tempo: {service.ServiceTime}h; ");
                    Console.WriteLine($"Preço: {service.Price}.");
                }
            }

        }

        public static void BySizeOrSpecies(string search)
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
                    Console.Write($"Porte {service.Size}; ");
                    Console.Write($"Serviço especial: {service.Special}; ");
                    Console.Write($"Loção: {service.Lotion}; ");
                    Console.Write($"Tempo: {service.ServiceTime}h; ");
                    Console.WriteLine($"Preço: {service.Price}.");
                }
            }

        }
    }
}
