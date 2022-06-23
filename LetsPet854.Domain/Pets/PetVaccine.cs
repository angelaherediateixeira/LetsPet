using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{ 
    public class PetVaccine
    {
        //public VaccineSystemRegister VaccineType { get; set; }
        public DateTime ImmunizationDate { get; set; }
        public DateTime RegistrationDate { get; set; }

        //public DateTime GetReapplicationDate()
        //{
           
        //    return ImmunizationDate.AddMonths(VaccineType.VaccineValidity);
        //}

    }
}
