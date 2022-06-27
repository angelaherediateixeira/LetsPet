using LetsPet854.Domain.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Presentation.Animals
{
    public static class PrintAnimal
    {

        public static void PrintPet(Animal animal)
        {
            Console.WriteLine(@$"
---------- IMPRIMINDO PET ----------
Nome: {animal.Name}
Espécie: {animal.Species}
Raça: {animal.Breed}
Cor: {animal.Color}
Porte: {animal.BreedSize}
Peso: {animal.Weight} Kg
Nascimento: {animal.BirthDate}
Idade: {animal.Age} ano(s)
Sexo: {animal.Gender}
Castrado: {(animal.CastratedBool ? "Sim" : "Não")}
Agressivo: {(animal.AggressiveBool ? "Sim" : "Não")}
Doenças: {Diseases(animal)}
Alergias: {Allergies(animal)}
Deficiência Física: {PhysicalDisability(animal)}
Carterinha de vacinação: {PetVaccine(animal)}
Data de cadastro: {animal.RegistrationDate}
");
            #region
            //if (animal.DiseasesBool)
            //{
            //    Console.WriteLine("Doenças do pet:");
            //    foreach (string disease in animal.DiseasesList) Console.WriteLine(disease);
            //}
            //else
            //    Console.WriteLine("O pet não possui nenhuma doença");


            //if (animal.AllergiesBool)
            //{
            //    Console.WriteLine("Alergias do pet:");
            //    foreach (string allergie in animal.AllergiesList)
            //        Console.WriteLine(allergie);
            //}
            //else
            //    Console.WriteLine("O pet não possui nenhuma alergia");


            //if (animal.PhysicalDisabilityBool)
            //{
            //    Console.WriteLine("Deficiências físicas do pet:");
            //    foreach (string deficiencia in animal.PhysicalDisabilityList)
            //        Console.WriteLine(deficiencia);
            //}
            //else
            //    Console.WriteLine("O pet não possui nenhuma deficiência física");

            //Console.WriteLine("CARTEIRA DE VACINAÇÃO DO PET:");
            //foreach (PetVaccine vacina in animal.PetVaccineList)
            //    Console.WriteLine(vacina);
            #endregion

        }
        public static string Diseases(Animal animal)
        {
            if (animal.DiseasesBool)
            {
                return animal.DiseasesList.ToString();
            }
            else
                return "O pet não possui nenhuma doença";
        }

        public static string Allergies(Animal animal)
        {
            if (animal.DiseasesBool)
            {
                return animal.AllergiesList.ToString();
            }
            else
                return "O pet não possui nenhuma alergia";
        }

        public static string PhysicalDisability(Animal animal)
        {
            if (animal.DiseasesBool)
            {
                return animal.PhysicalDisabilityList.ToString();
            }
            else
                return "O pet não possui nenhuma deficiência física";
        }

        public static string PetVaccine(Animal animal)
        {
            return animal.PetVaccineList.ToString();

        }
    }
}

