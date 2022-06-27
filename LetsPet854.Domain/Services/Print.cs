using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public static class Print
    {
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
