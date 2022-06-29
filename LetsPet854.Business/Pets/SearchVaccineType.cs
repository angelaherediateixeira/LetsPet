using LetsPet854.Domain.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Business.Pets
{
    public class SearchVaccineType
    {
        public static VaccineType SearchVaccinebyName(string name)
        {
            var FilteredVaccine = (
                from vaccine in VaccineType.VaccineTypeList
                where vaccine.VaccineName.Equals(name)
                select vaccine
                );
            if (FilteredVaccine.Count() == 0)
            {
                Console.WriteLine($"Nenhuma vacina com o nome {name} foi encontrado no sistema.");
                return null;
            }
            return FilteredVaccine.First();
        }
    }
}
