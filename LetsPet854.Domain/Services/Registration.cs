using LetsPet854.Domain.Common.Enuns;
using LetsPet854.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public class Registration
    {
        //private Service Service { get; set; }
        //private static string Type { get; set; }
        //private static string Species { get; set; }
        //private static string Size { get; set; }
        //private static string Name { get; set; }
        //private static bool Special { get; set; }
        //private static bool Lotion { get; set; }
        //private static string GroomingType = "";
        //private static int ServiceTime { get { return 1; } set {; } }
        //private static int Employees { get ;  set; }
        //private static double Price;
        //private readonly int option;
        //internal static string validate;
        public static List<Service> ServicesList = new();
        public static List<Discount> DiscountPackage = new();


        public static void AddService()
        {
            Service newService = new();
            Console.WriteLine("O que você deseja cadastrar?");
            PrintEnum.ServiceType();
            newService.Type = Enum.GetName(typeof(ServiceType), Validations.Options(1, 2));

            if (newService.Type == "Tosa")
            {
                Console.WriteLine("Qual o tipo de tosa a ser realizado?");
                PrintEnum.GroomingType();
                newService.GroomingType = Enum.GetName(typeof(GroomingType), Validations.Options(1, 3));
            }
            else
            {
                newService.GroomingType = null;
            }

            Console.WriteLine("Para qual espécie é este serviço?");
            PrintEnum.Species();
            newService.Species = Enum.GetName(typeof(Species), Validations.Options(1, 2));

            Console.WriteLine("Para qual porte é este serviço?");
            PrintEnum.BreedSize();
            newService.Size = Enum.GetName(typeof(BreedSize), Validations.Options(1, 2));
            newService.Employees = (newService.Size == "Grande")? 2 : 1;

            Console.WriteLine("É um serviço especial (S/N)?");
            newService.Special = Validations.YesOrNo();

            Console.WriteLine("Esse serviço utilizará loção (S/N)?");
            newService.Lotion = Validations.YesOrNo();

            Console.WriteLine("Qual o nome deste serviço?");
            newService.Name = Validations.ExistentName();

            Console.WriteLine("Qual o valor deste serviço?");
            newService.Price = Validations.ValidDouble();

            //Service newService = new Service(Type, Species, Size, Name, Special, Lotion, GroomingType, ServiceTime, Employees, Price);
            ServicesList.Add(newService);
            Console.WriteLine("Cadastro Realizado!\n");

            ShowInfo.ByName(newService.Name);
        }

        public static void AddDiscount()
        {
            //string serviceType;
            //double percentageDiscount;
            //int totalAttendance;

            Discount newDiscount = new();

            Console.WriteLine("Qual o tipo de serviço que terá desconto?");
            PrintEnum.ServiceType();
            newDiscount.ServiceType = Enum.GetName(typeof(ServiceType), Validations.Options(1, 2));

            Console.WriteLine("Após quantos atendimentos?");
            newDiscount.TotalAttendance = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de desconto?");
            newDiscount.PercentageDiscount = Validations.ValidDouble();
            //Discount newDiscount = new Discount(serviceType, percentageDiscount, totalAttendance);
            DiscountPackage.Add(newDiscount);
            Console.WriteLine("Desconto registrado!");
            Console.WriteLine($"Após {newDiscount.TotalAttendance} atendimento(s), " +
                $"o serviço {newDiscount.ServiceType} tem {newDiscount.PercentageDiscount}% de desconto.");
        }
    }
}
