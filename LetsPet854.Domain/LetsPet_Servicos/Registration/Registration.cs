using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public class Registration
    {
        public static string Type;
        public static string Species;
        public static string Size;
        public static string Name;
        public static bool Special;
        public static bool Lotion;
        public static string GroomingType = "";
        public static int ServiceTime = 1;
        public static double Price;
        public static int option;
        public static int order;
        public static string validate;
        public static List<Service> ServicesList = new();

        public static void AddService()
        {
            do
            {
                Console.WriteLine("O que você deseja cadastrar?");
                order = 1;
                foreach (Type service in Enum.GetValues(typeof(Type)))
                {
                    Console.WriteLine($"{order} - {service}");
                    order++;
                }
            } while (!int.TryParse(Console.ReadLine(), out order) || (order < 1 || order > 2));
            Type = Enum.GetName(typeof(Type), order);

            if (order == 2)
            {
                do
                {
                    order = 1;
                    Console.WriteLine("Qual o tipo de tosa a ser realizado?");
                    foreach (GroomingType service in Enum.GetValues(typeof(GroomingType)))
                    {
                        Console.WriteLine($"{order} - {service}");
                        order++;
                    }
                } while (!int.TryParse(Console.ReadLine(), out order) || (order < 1 || order > 3));
                GroomingType = Enum.GetName(typeof(GroomingType), order);
            }
            else
            {
                GroomingType = null;
            }

            do
            {
                order = 1;
                Console.WriteLine("Para qual espécie é este serviço?");
                foreach (Species especie in Enum.GetValues(typeof(Species)))
                {
                    Console.WriteLine($"{order} - {especie}");
                    order++;
                }
            } while (!int.TryParse(Console.ReadLine(), out order) || (order < 1 || order > 2));
            Species = Enum.GetName(typeof(Species), order);

            do
            {
                order = 1;
                Console.WriteLine("Para qual porte é este serviço?");
                foreach (Size especie in Enum.GetValues(typeof(Size)))
                {
                    Console.WriteLine($"{order} - {especie}");
                    order++;
                }
            } while (!int.TryParse(Console.ReadLine(), out order) || (order < 1 || order > 2));
            Size = Enum.GetName(typeof(Size), order);
            order = 1;

            do
            {
                Console.WriteLine("É um serviço especial (S/N)?");
                validate = Console.ReadLine().ToUpper();
            } while (!Validations.Resposta(validate));
            Special = Validations.SimNao(validate);

            do
            {
                Console.WriteLine("Esse serviço utilizará loção (S/N)?");
                validate = Console.ReadLine().ToUpper();
            } while (!Validations.Resposta(validate));
            Lotion = Validations.SimNao(validate);

            do
            {
                Console.WriteLine("Qual o nome deste serviço?");
                Name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Name)); //não aceitar nomes já existentes

            do
            {
                Console.WriteLine("Qual o valor deste serviço?");
            } while (!double.TryParse(Console.ReadLine(), out Price));

            Service newService = new Service(Type, Species, Size, Name, Special, Lotion, GroomingType, ServiceTime, Price);
            ServicesList.Add(newService);
            Console.WriteLine("Cadastro Realizado!\n");

              foreach (var service in ServicesList)
            {
                if (newService.Name == service.Name)
                {
                    Console.WriteLine($"Nome do serviço: {service.Name}");
                    Console.Write("Informações do serviço: ");
                    Console.Write(service.Type);
                    if (GroomingType != null)
                    {
                        Console.Write($" {service.GroomingType}");
                    }
                    Console.Write($"; Porte {service.Size}; ");
                    Console.Write($"Serviço especial: {service.Special}; ");
                    Console.Write($"Loção: {service.Lotion}; ");
                    Console.Write($"Tempo: {service.ServiceTime}h; ");
                    Console.WriteLine($"Preço: {service.Price}.");
                }
            }
        }
    }
}
