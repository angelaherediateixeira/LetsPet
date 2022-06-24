using LetsPet854.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class Guardian : Person
    {

        public List<Animal> PetList { get; set; }

        public Guardian(string cpf, string name, DateTime birthDate, Contact personContact, DateTime registerDate) :base (cpf, name, birthDate, personContact, registerDate) //List<Animal> petList, 
        {
            //PetList = petList;
        }




        
        // MÉTODOS
        public void PrintGuardian()
        {
            Console.WriteLine("IMPRIMINDO TUTOR:");
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"CPF: {Cpf}");
            PersonContact.PrintContact();
            PrintPetList();
        }

        public void PrintPetList()
        {
            foreach(Animal pet in PetList)
                Console.WriteLine(pet);
        }

        public void AddPet(Animal pet)
        {
            PetList.Add(pet);
        }

    }
}
