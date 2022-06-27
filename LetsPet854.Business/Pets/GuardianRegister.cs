
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
            Console.Clear();
            Console.WriteLine("Cadastrando Tutor");
            var guardian = new GuardianRegister();
            var name = guardian.GetGuardianName();
            var cpf = guardian.GetGuardianCPF();
            var birthDate = guardian.GetBirthDate();
            //var petlist = guardian.PetList;
            ContactServices newcontact = new ContactServices();
            var contact = newcontact.RegisterContact();
            var dateRegister = DateTime.Now;

            //(List<Animal> petList, string cpf, string name, DateTime birthDate, Contact personContact, DateTime registerDate) :base (cpf, name, birthDate, personContact, registerDate)

            Console.WriteLine("Tutor Cadastrado com Sucesso!!");

            Guardian newGuardian = new(cpf, name, birthDate, contact, dateRegister); //petList
            Guardian.GuardiansList.Add(newGuardian);  


        }
        private static void HeaderGuardian()
        {
            Console.Clear();
            Console.WriteLine("------- CADASTRO DE TUTOR -------");
        }
    }
}
