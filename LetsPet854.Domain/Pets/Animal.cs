using LetsPet854.Domain.Common.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class Animal
    {
        public string Name { get; set; }    
        public Species Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public BreedSize BreedSize { get; set; }
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public int Age { get { return AgeCalculator(); } }
        public bool CastratedBool { get; set; }  
        public bool DiseasesBool { get; set; }
        public bool AggressiveBool { get; set; }
        public bool AllergiesBool { get; set; }
        public bool PhysicalDisabilityBool { get; set; }
        public DateTime RegistrationDate { get { return DateTime.Now; } }

        public List<string> AllergiesList { get; set; }
        public List<string> DiseasesList { get; set; }
        public List<string> PhysicalDisabilityList { get; set;}
        public List<PetVaccine> PetVaccineList { get; set; }


        // ----------------- MÉTODOS -----------------

        public int AgeCalculator()
        {
            int idade = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                idade--;
            }
            return idade;
        }

        public void BirthRegistration(int year, int month, int day= 1)
        {
            BirthDate = new DateTime(year, month, day);
        }

        public void AddAllergies(string Allergie)
        {
            AllergiesList.Add(Allergie);
        }

        public void AddDiseases(string Disease)
        {
            DiseasesList.Add(Disease);
        }

        public void AddPhysicalDisability(string PhysicalDisability)
        {
            PhysicalDisabilityList.Add(PhysicalDisability);
        }

        public void PrintPet()
        {
            Console.Clear();
            Console.WriteLine("---------- IMPRIMINDO PET ----------");
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Espécie: {Species}");
            Console.WriteLine($"Raça: {Breed}");
            Console.WriteLine($"Cor: {Color}");
            Console.WriteLine($"Porte: {BreedSize}");
            Console.WriteLine($"Peso: {Weight} Kg");
            Console.WriteLine($"Nascimento: {BirthDate}");
            Console.WriteLine($"Idade: {Age} ano(s)");
            Console.WriteLine($"Sexo: {Gender}");

            Console.Write($"Castrado: ");
            if (CastratedBool)
                Console.WriteLine("SIM");
            else
                Console.WriteLine("NÃO");


            Console.Write($"Agressivo: ");
            if (AggressiveBool)
                Console.WriteLine("SIM");
            else
                Console.WriteLine("NÃO");


            if (DiseasesBool)
            {
                Console.WriteLine("Doenças do pet:");
                foreach (string disease in DiseasesList)
                    Console.WriteLine(disease);
            }
            else
                Console.WriteLine("O pet não possui nenhuma doença");
             

            if (AllergiesBool)
            {
                Console.WriteLine("Alergias do pet:");
                foreach (string allergie in AllergiesList)
                    Console.WriteLine(allergie);
            }
            else
                Console.WriteLine("O pet não possui nenhuma alergia");


            if (PhysicalDisabilityBool)
            {
                Console.WriteLine("Deficiências físicas do pet:");
                foreach (string deficiencia in PhysicalDisabilityList)
                    Console.WriteLine(deficiencia);
            }
            else
                Console.WriteLine("O pet não possui nenhuma deficiência física");

            Console.WriteLine("CARTEIRA DE VACINAÇÃO DO PET:");
            foreach(PetVaccine vacina in PetVaccineList)
                Console.WriteLine(vacina);
            
            Console.WriteLine($"Data de cadastro: {RegistrationDate}");
            Console.WriteLine();

        }

    }
}
