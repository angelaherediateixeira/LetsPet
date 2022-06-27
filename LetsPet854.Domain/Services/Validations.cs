using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Services
{
    public class Validations
    {
        //public static bool Resposta(string resposta)
        //{
        //    if (resposta != "S" && resposta != "N")
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public static bool YesOrNo()
        {
            if (Answer() == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Answer()
        {
            string answer = Console.ReadLine().ToUpper();
            while (answer != "S" && answer != "N")
            {
                Console.WriteLine("Digite S ou N:");
                answer = Console.ReadLine().ToUpper();
            }
            return answer;
        }

        public static int Options(int first, int last)
        {
            int answer;
            while (!int.TryParse(Console.ReadLine(), out answer) || (answer < first || answer > last))
            {
                Console.WriteLine("Digite uma opção válida:");
            }
            return answer;
        }

        public static string ExistentName()
        {
            bool valid;
            string name;
            do
            {
                name = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Este campo é obrigatório. Digite um nome para o serviço:");
                    name = Console.ReadLine();                  
                }
                valid = true;
                foreach (var service in Registration.ServicesList)
                {
                    if (name == service.Name)
                    {
                        Console.WriteLine("Já existe um serviço com esse nome. Digite outro:");
                        valid = false;
                        break;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            } while (!valid);
            return name;
        }

        public static double ValidDouble()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero) || numero < 1)
            {
                Console.WriteLine("Digite um número válido:");
            }
            return numero;
        }
    }
}
