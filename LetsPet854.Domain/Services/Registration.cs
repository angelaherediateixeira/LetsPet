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
        private static string Type { get; set; }
        private static string Species { get; set; }
        private static string Size { get; set; }
        private static string Name { get; set; }
        private static bool Special { get; set; }
        private static bool Lotion { get; set; }
        private static string GroomingType = "";
        private static int ServiceTime { get { return 1; } set {; } }
        private static int Employees { get ;  set; }
        private static double Price;
        internal static int option;
        internal static string validate;
        public static List<Service> ServicesList = new();
        public static List<Discount> DiscountPackage = new();


        public static void AddService()
        {
            Console.WriteLine("O que você deseja cadastrar?");
            ShowInfo.EnumServiceType();
            Type = Enum.GetName(typeof(ServiceType), Validations.Options(1, 2));

            if (Type == "Tosa")
            {
                Console.WriteLine("Qual o tipo de tosa a ser realizado?");
                ShowInfo.EnumGroomingType();
                GroomingType = Enum.GetName(typeof(GroomingType), Validations.Options(1, 3));
            }
            else
            {
                GroomingType = null;
            }

            Console.WriteLine("Para qual espécie é este serviço?");
            ShowInfo.EnumSpecies();
            Species = Enum.GetName(typeof(Species), Validations.Options(1, 2));

            Console.WriteLine("Para qual porte é este serviço?");
            ShowInfo.EnumBreedSize();
            Size = Enum.GetName(typeof(BreedSize), Validations.Options(1, 2));
            Employees = (Size == "Grande")? 2 : 1;

            Console.WriteLine("É um serviço especial (S/N)?");
            Special = Validations.YesOrNo();

            Console.WriteLine("Esse serviço utilizará loção (S/N)?");
            Lotion = Validations.YesOrNo();

            Console.WriteLine("Qual o nome deste serviço?");
            Name = Validations.ExistentName();

            Console.WriteLine("Qual o valor deste serviço?");
            Price = Validations.ValidDouble();

            Service newService = new Service(Type, Species, Size, Name, Special, Lotion, GroomingType, ServiceTime, Employees, Price);
            ServicesList.Add(newService);
            Console.WriteLine("Cadastro Realizado!\n");

            ShowInfo.ByName(newService.Name);
        }

        public static void AddDiscount()
        {
            string serviceType;
            double percentageDiscount;
            int totalAttendance;

            Console.WriteLine("Qual o tipo de serviço que terá desconto?");
            serviceType = Console.ReadLine();

            Console.WriteLine("Após quantos atendimentos?");
            totalAttendance = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de desconto?");
            percentageDiscount = double.Parse(Console.ReadLine());

            Discount newDiscount = new Discount(serviceType, percentageDiscount, totalAttendance);
            DiscountPackage.Add(newDiscount);
        }
    }
}
