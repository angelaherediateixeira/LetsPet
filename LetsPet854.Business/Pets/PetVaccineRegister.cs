using LetsPet854.Domain.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Business.Pets
{
    public class PetVaccineRegister
    {


        public DateTime GetImmunizationDate()
        {
            DateTime immunizationDate;
            
            do
            {
                Console.WriteLine("Qual a data da aplicação da vacina? (DD/MM/YYYY)");
                if (DateTime.TryParse(Console.ReadLine(), out immunizationDate))
                {
                    break;
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return immunizationDate;
        }
        //fazer a busca do tipo de vacina e
        // fazer a busca do animal para inserir na lista dele?
        public void RegisterPetVaccine(Animal pet, VaccineType vaccineType)
        {
            var immunizationDate = GetImmunizationDate();
            var petVaccine = new PetVaccine(vaccineType, immunizationDate);
            pet.PetVaccineList.Add(petVaccine);
        }
    }
}
