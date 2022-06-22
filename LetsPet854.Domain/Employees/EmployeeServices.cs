using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet_Employees.Enums

namespace LetsPet_Employees
{
    public class EmployeeServices
    {
        public Species specie { get; set; }
        public Type type { get; set; }
        public Size size { get; set; }
        public bool MeetsSpecialNeeds { get; set; }
        public bool MeetsAggressiveAnimal { get; set; }


        public EmployeeServices(list type, list specie, list size, bool meetsSpecialNeeds, bool meetsAggressiveAnimal)
        {

            Type type = type;
            Species species = specie;
            Size size = size;
            MeetsSpecialNeeds = meetsSpecialNeeds;
            MeetsAggressiveAnimal = meetsAggressiveAnimal;

        }

    }
}