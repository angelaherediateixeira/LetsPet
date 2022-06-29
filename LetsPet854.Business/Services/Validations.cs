using System.Text.RegularExpressions;

namespace LetsPet854.Business
{
    public class Validations
    {

        public static bool YesOrNo()
        {
            if (RegexYes(Answer()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RegexNo(string answer) 
        {
            return new Regex(@"^((n)|(nao)|(não)){1}$").Match(answer).Success;
        }

        public static bool RegexYes(string answer)
        {
            return new Regex(@"^((s)|(sim)){1}$").Match(answer).Success;
        }

        public static string Answer()
        {
            string answer = Console.ReadLine().ToLower();
            while (!RegexYes(answer) && !RegexNo(answer))
            {
                Console.WriteLine("Digite Sim ou Não:");
                answer = Console.ReadLine().ToLower();
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

        public static int ValidInt()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1)
            {
                Console.WriteLine("Digite um número válido:");
            }
            return numero;
        }
    }
}
