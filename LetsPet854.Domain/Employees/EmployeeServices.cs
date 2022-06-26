using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet_Employees.Enums;

namespace LetsPet_Employees
{
    public class EmployeeServices
    {
        public List<Species> Species { get; set; }
        public List<TypeService> Types { get; set; }
        public List<SizeAnimal> Sizes { get; set; }
        public bool MeetsSpecialNeeds { get; set; }
        public bool MeetsAggressiveAnimal { get; set; }


        public EmployeeServices(List<SizeAnimal> sizes, List<TypeService> types, List<Species> species, bool meetsSpecialNeeds, bool meetsAggressiveAnimal)
        {

            Types = types;
            Species = species;
            Sizes = sizes;
            MeetsSpecialNeeds = meetsSpecialNeeds;
            MeetsAggressiveAnimal = meetsAggressiveAnimal;

        }

    }
}