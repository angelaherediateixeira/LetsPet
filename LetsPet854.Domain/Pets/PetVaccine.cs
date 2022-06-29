using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class PetVaccine
    {
        public VaccineType VaccineType { get; set; }
        public DateTime ImmunizationDate { get; set; }

        public DateTime ReapplicationDate { get { return ImmunizationDate.AddMonths(VaccineType.VaccineValidity); } }
        public DateTime RegistrationDate { get { return DateTime.Today; } }

        public PetVaccine(VaccineType vaccineType, DateTime immunizationDate)
        {
            VaccineType = vaccineType;
            ImmunizationDate = immunizationDate;

        }

        public DateTime GetReapplicationDate()
        {
            return ImmunizationDate.AddMonths(VaccineType.VaccineValidity);
        }
    }
}
