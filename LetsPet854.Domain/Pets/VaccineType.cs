using LetsPet854.Domain.Common.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class VaccineType
    {
        public string VaccineName { get; set; }
        public Species VaccineSpecies { get; set; }
        public int VaccineValidity { get; set; }

        public static List<VaccineType> VaccineTypeList = new();

        public VaccineType(string vaccineName, Species vaccineSpecies, int vaccineValidity)
        {
            VaccineName = vaccineName;
            VaccineSpecies = vaccineSpecies;
            VaccineValidity = vaccineValidity;
        }
    }
}
