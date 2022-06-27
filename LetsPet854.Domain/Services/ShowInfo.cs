using LetsPet854.Domain.Common.Enuns;
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
                    Console.WriteLine($"Nome do serviço: {service.Name}\n" +
                        $"Informações do serviço:\n" +
                        $"{service.Type}{(service.GroomingType == null ? null : $" {service.GroomingType}")};" +
                        $" Espécie: {service.Species}; " +
                        $"Porte: {service.Size}; " +
                        $"Serviço especial: {Special(service)}; " +
                        $"Loção: {Lotion(service)}; " +
                        $"Tempo: {service.ServiceTime}h; " +
                        $"Número de funcionários: {service.Employees}; " +
                        $"Preço: R${service.Price}.");
                }
            }

        }

        public static void ByName(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Name)
                {
                    Console.WriteLine($"Nome do serviço: {service.Name}\n" +
                        $"Informações do serviço:\n" +
                        $"{service.Type}{(service.GroomingType == null ? null : $" {service.GroomingType}")};" +
                        $" Espécie: {service.Species}; " +
                        $"Porte: {service.Size}; " +
                        $"Serviço especial: {Special(service)}; " +
                        $"Loção: {Lotion(service)}; " +
                        $"Tempo: {service.ServiceTime}h; " +
                        $"Número de funcionários: {service.Employees}; " +
                        $"Preço: R${service.Price}.");
                }
            }
        }

        public static void BySizeOrSpecies(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Species || search == service.Size)
                {
                    Console.WriteLine($"Nome do serviço: {service.Name}\n" +
                        $"Informações do serviço:\n" +
                        $"{service.Type}{(service.GroomingType == null ? null : $" {service.GroomingType}")};" +
                        $" Espécie: {service.Species}; " +
                        $"Porte: {service.Size}; " +
                        $"Serviço especial: {Special(service)}; " +
                        $"Loção: {Lotion(service)}; " +
                        $"Tempo: {service.ServiceTime}h; ]" +
                        $"Número de funcionários: {service.Employees}; " +
                        $"Preço: R${service.Price}.");
                }
            }

        }

        static string Special(Service newService) => newService.Special ? "Sim" : "Não";

        static string Lotion(Service newService) => newService.Lotion ? "Sim" : "Não";

        public static void EnumServiceType()
        {
            foreach (ServiceType service in Enum.GetValues(typeof(ServiceType)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static void EnumBreedSize()
        {
            foreach (BreedSize service in Enum.GetValues(typeof(BreedSize)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static void EnumSpecies()
        {
            foreach (Species service in Enum.GetValues(typeof(Species)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static void EnumGroomingType()
        {
            foreach (GroomingType service in Enum.GetValues(typeof(GroomingType)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static double Discount(string ServiceType, int totalAttendance)
        {
            double discount = 1;
            foreach (var package in Registration.DiscountPackage)
            {
                if ((ServiceType == package.ServiceType) && (totalAttendance % package.TotalAttendance == 0))
                {
                    discount = package.PercentageDiscount;
                }
            }
            return discount;
        }
    }
}
