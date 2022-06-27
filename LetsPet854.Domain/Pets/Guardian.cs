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
        public static List<Guardian> GuardiansList { get; private set; } = new List<Guardian>();

        public List<Animal> PetList { get; set; } = new List<Animal>();

        public Guardian(string cpf, string name, DateTime birthDate, Contact personContact, DateTime registerDate) :base (cpf, name, birthDate, personContact, registerDate) //List<Animal> petList, 
        {
           //PetList = petList;
        }
        

    }
}
