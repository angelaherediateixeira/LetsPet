using LetsPet854.Domain.Common.Enuns;
using LetsPet854.Domain.Pets;

namespace LetsPet854.Business.Pets
{
    public class VaccineRegister
    {
        
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
                    Console.WriteLine("Valor inválido, digite uma das opções acima: ");
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

        public void RegisterVaccineType()
        {
            var newVaccineType = new VaccineRegister();
            var name = newVaccineType.GetVaccineName();
            var species = newVaccineType.GetVaccineSpecies();
            var validity = newVaccineType.GetVaccineValidity();

            var newVaccine = new VaccineType(name, species, validity);
            VaccineType.VaccineTypeList.Add(newVaccine);
        }



    }

}
