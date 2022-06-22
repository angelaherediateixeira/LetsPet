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
        public SizeAnimal size { get; set; }
        public bool MeetsSpecialNeeds { get; set; }
        public bool MeetsAggressiveAnimal { get; set; }


        public EmployeeServices(SizeAnimal size, TypeService type, Species specie, bool meetsSpecialNeeds, bool meetsAggressiveAnimal)
        {

            TypeService Type = type;
            Species Specie = specie;
            SizeAnimal Size = size;
            MeetsSpecialNeeds = meetsSpecialNeeds;
            MeetsAggressiveAnimal = meetsAggressiveAnimal;

        }

    }
}