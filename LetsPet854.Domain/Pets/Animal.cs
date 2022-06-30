﻿using LetsPet854.Domain.Common.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class Animal
    {
        public static List<Animal> AnimalsList = new List<Animal>();

        public Animal(string name, Species species, string breed, string color,
            BreedSize breedSize, decimal weight, DateTime birthDate, Gender gender,
            bool castratedBool, bool diseasesBool, bool aggressiveBool,
            bool allergiesBool, bool physicalDisabilityBool,
            List<string> allergiesList, List<string> diseasesList,
            List<string> physicalDisabilityList)
        {
            Name = name;
            Species = species;
            Breed = breed;
            Color = color;
            BreedSize = breedSize;
            Weight = weight;
            BirthDate = birthDate;
            Gender = gender;
            CastratedBool = castratedBool;
            DiseasesBool = diseasesBool;
            AggressiveBool = aggressiveBool;
            AllergiesBool = allergiesBool;
            PhysicalDisabilityBool = physicalDisabilityBool;
            AllergiesList = allergiesList;
            DiseasesList = diseasesList;
            PhysicalDisabilityList = physicalDisabilityList;
        }

        public Guardian Guardian { get; set; }
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
        public List<string> PhysicalDisabilityList { get; set; }
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

        public void BirthRegistration(int year, int month, int day = 1)
        {
            BirthDate = new DateTime(year, month, day);
        }

        public bool TwoMonthsBool()
        {
            if (Age < 1 && BirthDate.Month - DateTime.Now.Month < 2)
                return true;
            else
                return false;
        }
    }
}
