using LetsPet854.Domain.Common.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet854.Domain;

namespace LetsPet854.Business
{
    public class ShowInfo
    {
        public static int count = 0;
        public static void ByType(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Type)
                {
                    PrintService(service);
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine((count == 0) ? null : "Serviço não encontrado");
        }

        public static void ByName(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Name)
                {
                    PrintService(service);
                }
            }
        }

        

        public static void BySizeOrSpecies(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Species || search == service.Size)
                {
                    PrintService(service);
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine((count == 0) ? null : "Serviço não encontrado");
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

        public static void PrintService(Service service)
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
        static string Special(Service newService) => newService.Special ? "Sim" : "Não";

        static string Lotion(Service newService) => newService.Lotion ? "Sim" : "Não";
    }
}
