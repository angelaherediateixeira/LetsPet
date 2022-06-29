using LetsPet854.Domain.Common.Enuns;
using LetsPet854.Domain.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Business.Pets
{
    public class RegisterAnimal
    {
        public static string GetAnimalName()
        {
            string animalName;
            HeaderPet();
            do
            {
                Console.WriteLine("Insira o nome do animal:");
                animalName = Console.ReadLine();
                if (!string.IsNullOrEmpty(animalName))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return animalName;
        }

        public static Species GetSpecies()
        {
            bool valido = true;
            int inputNumerico;
            Species animalSpecies;
            HeaderPet();
            do
            {
                Console.WriteLine("Qual a especie do seu pet? (Digite 1 para cachorro ou 2 para gato)");
                if (!valido)
                {
                    Console.WriteLine("Erro na leitura, digite uma das especies acima: ");
                }
                var input = Console.ReadLine();
                valido = int.TryParse(input, out inputNumerico) && (inputNumerico == 1 || inputNumerico == 2);
            } while (!valido);
            animalSpecies = (Species)inputNumerico;
            return animalSpecies;
        }
        public static string GetBreed()
        {
            string animalBreed;
            HeaderPet();
            do
            {
                Console.WriteLine("Insira a raça do Animal:");
                animalBreed = Console.ReadLine();
                if (!string.IsNullOrEmpty(animalBreed))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return animalBreed;
        }

        public static string GetColor()
        {
            string animalColor;
            HeaderPet();
            do
            {
                Console.WriteLine("Insira a cor do animal:");
                animalColor = Console.ReadLine();
                if (!string.IsNullOrEmpty(animalColor))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return animalColor;
        }

        public static BreedSize GetBreedSize()
        {
            bool valido = true;
            int inputNumerico;
            BreedSize animalSize;
            HeaderPet();
            do
            {
                Console.WriteLine("Qual o porte do seu pet? (Digite 1 para pequeno ou 2 para grande)");
                if (!valido)
                {
                    Console.WriteLine("Erro na leitura, digite uma dos portes acima: ");
                }
                var input = Console.ReadLine();
                valido = int.TryParse(input, out inputNumerico) && (inputNumerico == 1 || inputNumerico == 2);
            } while (!valido);
            animalSize = (BreedSize)inputNumerico;
            return animalSize;
        }

        public static decimal GetWeight()
        {
            decimal animalWeight;
            HeaderPet();
            do
            {
                Console.WriteLine("Qual o peso do animal");
                if (decimal.TryParse(Console.ReadLine(), out animalWeight))
                {
                    if (animalWeight > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return animalWeight;
        }
        public static DateTime GetBirthDate()
        {
            DateTime animalBirthDate;
            HeaderPet();
            do
            {
                Console.WriteLine("Qual a data de nascimento do animal? (DD/MM/YYYY)");
                if (DateTime.TryParse(Console.ReadLine(), out animalBirthDate))
                {
                    break;
                }
                Console.WriteLine("Valor inválido.");
            } while (true);
            return animalBirthDate;
        }


        public static Gender GetGender()
        {
            bool valido = true;
            int inputNumerico;
            Gender animalGender;
            HeaderPet();
            do
            {
                Console.WriteLine("Qual o genêro do seu pet? (Digite 1 para fêmea ou 2 para macho)");
                if (!valido)
                {
                    Console.WriteLine("Erro na leitura, digite uma dos genêros acima: ");
                }
                var input = Console.ReadLine();
                valido = int.TryParse(input, out inputNumerico) && (inputNumerico == 1 || inputNumerico == 2);
            } while (!valido);
            animalGender = (Gender)inputNumerico;
            return animalGender;
        }

        public static bool GetAggressiveBool()
        {
            string answer;
            bool agressiveAnimal = false;
            HeaderPet();
            do
            {
                Console.WriteLine("O animal é agressivo? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    agressiveAnimal = true;
                }
                else if (answer == "N")
                {
                    agressiveAnimal = false;
                }
                else
                {
                    Console.WriteLine("Erro na leitura, digite uma dos parâmetros acima: ");
                }
            } while (answer != "S" && answer != "N" || string.IsNullOrWhiteSpace(answer));
            return agressiveAnimal;

        }

        public static bool GetCastratedBool()
        {
            string answer;
            bool castratedAnimal = true;
            HeaderPet();
            do
            {
                Console.WriteLine("O animal é castrado? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    castratedAnimal = true;
                }
                else if (answer == "N")
                {
                    castratedAnimal = false;
                }
                else
                {
                    Console.WriteLine("Erro na leitura, digite uma dos parâmetros acima: ");
                }
            } while (answer != "S" && answer != "N" || string.IsNullOrWhiteSpace(answer));
            return castratedAnimal;
        }

        public static bool GetAllergiesBool()
        {
            string answer;
            bool allergiesAnimalBool = true;
            HeaderPet();
            do
            {
                Console.WriteLine("O animal possui alguma alergia? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    allergiesAnimalBool = true;
                }
                else if (answer == "N")
                {
                    allergiesAnimalBool = false;
                }
                else
                {
                    Console.WriteLine("Erro na leitura, digite uma dos parâmetros acima: ");
                }
            } while (answer != "S" && answer != "N" || string.IsNullOrWhiteSpace(answer));
            return allergiesAnimalBool;
        }

        public static List<string> GetAllergiesList()
        {
            var allergies = new List<string>();
            string answer = "S";
            while (answer == "S")
            {
                Console.WriteLine("Cite a alergia:");
                allergies.Add(Console.ReadLine());
                Console.WriteLine("Deseja inserir mais? Digite S para sim ou N para não");
                answer = Console.ReadLine().ToUpper();
            }
            return allergies;
        }

        public static bool GetDiseasesBool()
        {
            string answer;
            bool diseasesAnimalBool = true;
            do
            {
                Console.WriteLine("O animal possui alguma doença? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    diseasesAnimalBool = true;
                }
                else if (answer == "N")
                {
                    diseasesAnimalBool = false;
                }
                else
                {
                    Console.WriteLine("Erro na leitura, digite uma dos parâmetros acima: ");
                }
            } while (answer != "S" && answer != "N" || string.IsNullOrWhiteSpace(answer));
            return diseasesAnimalBool;
        }

        public static List<string> GetDiseasesList()
        {
            var diseases = new List<string>();
            string answer = "S";
            while (answer == "S")
            {
                Console.WriteLine("Cite a doença:");
                diseases.Add(Console.ReadLine());
                Console.WriteLine("Deseja inserir mais? Digite S para sim ou N para não");
                answer = Console.ReadLine().ToUpper();
            }
            return diseases;
        }

        public static bool GetPhysicalDisabilityBool()
        {
            string answer;
            bool physicalDisabilityBool = true;
            do
            {
                Console.WriteLine("O animal possui alguma deficiência física? Digite S para sim ou N para não.");
                answer = Console.ReadLine().ToUpper();
                if (answer == "S")
                {
                    physicalDisabilityBool = true;
                }
                else if (answer == "N")
                {
                    physicalDisabilityBool = false;
                }
                else
                {
                    Console.WriteLine("Erro na leitura, digite uma dos parâmetros acima: ");
                }
            } while (answer != "S" && answer != "N" || string.IsNullOrWhiteSpace(answer));
            return physicalDisabilityBool;
        }
        public static List<string> GetPhysicalDisabilityList()
        {
            var physicalDisability = new List<string>();
            string answer = "S";
            while (answer == "S")
            {
                Console.WriteLine("Cite a deficiência física:");
                physicalDisability.Add(Console.ReadLine());
                Console.WriteLine("Deseja inserir mais? Digite S para sim ou N para não");
                answer = Console.ReadLine().ToUpper();
            }
            return physicalDisability;
        }

        //public static void AnimalRegister()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Cadastrando Pets");
        //    Console.WriteLine("Digite o CPF do Tutor:");
        //    var response = Console.ReadLine();
        //    var guardianSearchResult = SearchGuardian.SearchGuardianByCPF(response);
        //    if (guardianSearchResult == null)
        //    {
        //        Console.ReadKey(); //alterar para caso não encontre o CPF
        //    }
        //    var name = GetAnimalName();
        //    var species = GetSpecies();
        //    var breed = GetBreed();
        //    var color = GetColor();
        //    var breedSize = GetBreedSize();
        //    var weight = GetWeight();
        //    var birthDate = GetBirthDate();
        //    var gender = GetGender();
        //    var castratedBool = GetCastratedBool();
        //    var aggressiveBool = GetAggressiveBool();
        //    var diseaseBool = GetDiseasesBool();
        //    List<string> diseasesList = new List<string>();
        //    if (diseaseBool)
        //    {
        //        diseasesList = GetDiseasesList();
        //    }
        //    var allergiesBool = GetAllergiesBool();
        //    List<string> allergiesList = new List<string>();
        //    if (allergiesBool)
        //    {
        //        allergiesList = GetAllergiesList();
        //    }
        //    var physicalDisabilityBool = GetPhysicalDisabilityBool();
        //    List<string> physicalDisabilityList = new List<string>();
        //    if (physicalDisabilityBool)
        //    {
        //        physicalDisabilityList = GetPhysicalDisabilityList();
        //    }

        //    Console.WriteLine("Pet Cadastrado com Sucesso!!");

        //    Animal pet = new(name, species, breed, color, breedSize, weight, birthDate, gender, castratedBool, diseaseBool, aggressiveBool, allergiesBool, physicalDisabilityBool, allergiesList, diseasesList, physicalDisabilityList);

        //    guardianSearchResult.PetList.Add(pet);

        //}


        //Sugestão: tutor ser uma entrada para o registro
        // e não inserir a busca de tutor no registro

        public static void AnimalRegister(Guardian tutor)
        {
            var name = GetAnimalName();
            var species = GetSpecies();
            var breed = GetBreed();
            var color = GetColor();
            var breedSize = GetBreedSize();
            var weight = GetWeight();
            var birthDate = GetBirthDate();
            var gender = GetGender();
            var castratedBool = GetCastratedBool();
            var aggressiveBool = GetAggressiveBool();
            var diseaseBool = GetDiseasesBool();
            List<string> diseasesList = new List<string>();
            if (diseaseBool)
            {
                diseasesList = GetDiseasesList();
            }
            var allergiesBool = GetAllergiesBool();
            List<string> allergiesList = new List<string>();
            if (allergiesBool)
            {
                allergiesList = GetAllergiesList();
            }
            var physicalDisabilityBool = GetPhysicalDisabilityBool();
            List<string> physicalDisabilityList = new List<string>();
            if (physicalDisabilityBool)
            {
                physicalDisabilityList = GetPhysicalDisabilityList();
            }

            Console.WriteLine("Pet Cadastrado com Sucesso!!");

            Animal pet = new(name, species, breed, color, breedSize, weight, birthDate, gender,
                castratedBool, diseaseBool, aggressiveBool, allergiesBool, physicalDisabilityBool,
                allergiesList, diseasesList, physicalDisabilityList);

            tutor.PetList.Add(pet);
            pet.Guardian = tutor;
            Animal.AnimalsList.Add(pet);
        }

        private static void HeaderPet()
        {
            Console.Clear();
            Console.WriteLine("------- CADASTRO DE ANIMAL -------");
        }

    }
}
