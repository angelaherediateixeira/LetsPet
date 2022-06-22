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
        public TypeService type { get; set; }
        public Size size { get; set; }
        public bool MeetsSpecialNeeds { get; set; }
        public bool MeetsAggressiveAnimal { get; set; }


        public EmployeeServices(string typeInput, string specie, string size, bool meetsSpecialNeeds, bool meetsAggressiveAnimal)
        {

            type = typeInput;
            Species species = specie;
            Size size = size;
            MeetsSpecialNeeds = meetsSpecialNeeds;
            MeetsAggressiveAnimal = meetsAggressiveAnimal;

        }

    }
}