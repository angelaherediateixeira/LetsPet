using LetsPet854.Domain.Common;
using LetsPet854.Domain.Common.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class VaccineSystemRegister
    {
        //criar vacine type e jogar longe as propriedades (vacine type na domain)
        public string VaccineName { get; set; }
        public Species VaccineSpecies { get; set; }
        public int VaccineValidity { get; set; }

        public List<VaccineSystemRegister> ListVaccine { get; set; }

        public Species GetVaccineSpecies()
        {

            bool valido = true;
            int inputNumerico;
            Species vaccineSpecies;
            do
            {
                Console.WriteLine("Para qual espécie é a vacina a ser cadastrada? (Digite 1 para cachorro ou 2 para gato)");
                if (!valido)
                {
                    Console.WriteLine("Erro na leitura, digite uma das especies acima: ");
                }
                var input = Console.ReadLine();
                valido = int.TryParse(input, out inputNumerico) && (inputNumerico == 1 || inputNumerico == 2);
            } while (!valido);
            vaccineSpecies = (Species)inputNumerico;
            return vaccineSpecies;
        }

        public string GetVaccineName()
        {
            string vaccineName;
            do
            {
                Console.WriteLine("Insira o nome da Vacina a ser cadastrada:");
                vaccineName = Console.ReadLine();
                if (!string.IsNullOrEmpty(vaccineName))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return vaccineName;
        }
        public int GetVaccineValidity()
        {
            int vaccineValidity;
            do
            {
                Console.WriteLine("Qual a validade em meses da vacina? ");
                if (int.TryParse(Console.ReadLine(), out vaccineValidity))
                {
                    if (vaccineValidity > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return vaccineValidity;
        }


        public void AddListVaccine(VaccineSystemRegister newVaccine)
        {
            newVaccine.VaccineName = GetVaccineName();
            newVaccine.VaccineSpecies = GetVaccineSpecies();
            newVaccine.VaccineValidity = GetVaccineValidity();

            ListVaccine.Add(newVaccine);
        }

    }

}
