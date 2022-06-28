using LetsPet854.Business.Common;
using LetsPet854.Domain.Common;
using LetsPet854.Domain.Pets;

namespace LetsPet854.Domain.Pets

{
    public class GuardianRegister
    {
        public string GetGuardianName()
        {
            string guardianName;
            HeaderGuardian();
            do
            {
                Console.WriteLine("Insira o nome do tutor:");
                guardianName = Console.ReadLine();
                if (!string.IsNullOrEmpty(guardianName))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return guardianName;
        }

        public string GetGuardianCPF()
        {
            string guardianCPF;
            HeaderGuardian();
            Console.WriteLine("Insira o CPF do tutor:");
            do
            {
                guardianCPF = Console.ReadLine();
            } while (!Validation.IsCpfValid(guardianCPF));
            return guardianCPF;
        }

        public DateTime GetBirthDate()
        {
            DateTime guardianBirthDate;
            HeaderGuardian();
            do
            {
                Console.WriteLine("Qual a data de nascimento do tutor? (DD/MM/YYYY)");
                if (DateTime.TryParse(Console.ReadLine(), out guardianBirthDate))
                {
                    break;
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return guardianBirthDate;
        }

        public static void RegisterGuardian()
        {
            var guardian = new GuardianRegister();
            var name = guardian.GetGuardianName();
            var cpf = guardian.GetGuardianCPF();
            var birthDate = guardian.GetBirthDate();
            //var petlist = guardian.PetList;
            Contact newcontact = CreateContact.GenerateContact();
            var dateRegister = DateTime.Now;

            //(List<Animal> petList, string cpf, string name, DateTime birthDate, Contact personContact, DateTime registerDate) :base (cpf, name, birthDate, personContact, registerDate)

            Guardian newGuardian = new(cpf, name, birthDate, newcontact, dateRegister); //petList
            Guardian.GuardiansList.Add(newGuardian);
        }
        private void HeaderGuardian()
        {
            Console.Clear();
            Console.WriteLine("------- CADASTRO DE TUTOR -------");
        }

    }
}
