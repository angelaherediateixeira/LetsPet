using LetsPet854.Domain.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Presentation.Animals
{
    public static class PrintGuardian
    {
        public static void PrintTutor (Guardian guardian)
        {
            Console.WriteLine(@$"IMPRIMINDO TUTOR:
Nome: {guardian.Name}
CPF: {guardian.Cpf}");
            //PersonContact.PrintContact();
            //PrintPetList();

            foreach (var item in guardian.PetList)
            {
                PrintAnimal.PrintPet(item);
            }
        }

        
    }
}
