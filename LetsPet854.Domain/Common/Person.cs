using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Common
{
    public class Person
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Contact PersonContact { get; set; }
        public DateTime RegisterDate { get; set; }

        public Person(string cpf, string name, DateTime birthDate, Contact personContact, DateTime registerDate)
        {
            Cpf = cpf;
            Name = name;
            BirthDate = birthDate;
            PersonContact = personContact;
            RegisterDate = registerDate;
        }
    }

}
