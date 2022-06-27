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
        public static int count = 0;
        public static void ByType(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Type)
                {
                    Print.PrintService(service);
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
                    Print.PrintService(service);
                }
            }
        }

        

        public static void BySizeOrSpecies(string search)
        {
            foreach (var service in Registration.ServicesList)
            {
                if (search == service.Species || search == service.Size)
                {
                    Print.PrintService(service);
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
    }
}
