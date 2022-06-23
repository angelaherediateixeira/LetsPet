using LetsPet854.Domain.Common.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Pets
{
    public class RegisterAnimal
    {
        public string GetAnimalName()
        {
            string animalName;
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

        public Species GetSpecies()
        {
            bool valido = true;
            int inputNumerico;
            Species animalSpecies;
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
        public string GetBreed()
        {
            string animalBreed;
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

        public string GetColor()
        {
            string animalColor;
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

        public BreedSize GetSize()
        {
            bool valido = true;
            int inputNumerico;
            BreedSize animalSize;
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

        public decimal GetWeight()
        {
            decimal animalWeight;
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

        public Gender GetGender()
        {
            bool valido = true;
            int inputNumerico;
            Gender animalGender;
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

        public bool GetAggressiveBool()
        {
            string answer;
            bool agressiveAnimal = false;
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

        public bool GetCastratedBool()
        {
            string answer;
            bool castratedAnimal = true;
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

        public bool GetAllergiesBool()
        {
            string answer;
            bool allergiesAnimalBool = true;
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

        public List<string> GetAllergiesList()
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

        public bool GetDiseasesBool()
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

        public List<string> GetDiseasesList()
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

        public bool GetPhysicalDisabilityBool()
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
        public List<string> GetPhysicalDisabilityList()
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



    }
}
