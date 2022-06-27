using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet854.Domain.Common.Enuns;

namespace LetsPet854.Domain
{
    public static class PrintEnum
    {

        public static void ServiceType()
        {
            foreach (ServiceType service in Enum.GetValues(typeof(ServiceType)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static void BreedSize()
        {
            foreach (BreedSize service in Enum.GetValues(typeof(BreedSize)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static void Species()
        {
            foreach (Species service in Enum.GetValues(typeof(Species)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }

        public static void GroomingType()
        {
            foreach (GroomingType service in Enum.GetValues(typeof(GroomingType)))
            {
                Console.WriteLine($"{((int)service)} - {service}");
            }
        }
    }
}
