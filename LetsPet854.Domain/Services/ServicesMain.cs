using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LetsPet854.Domain.Services
{
    public class ServicesMain
    {
        public static int option;
        public static bool loop;
        public static string validate;

        public static void DefaultMenu()
        {
            do
            {
                Console.WriteLine("Opções de serviço:");
                Console.WriteLine("1 - Cadastro de Serviços e Preços dos Serviços\n2 - Buscar serviço\n3 - Relatório de serviços prestados\n4 - Relatório de produtos por serviço prestado");
                while (!int.TryParse(Console.ReadLine(), out option) || (option < 1 || option > 4))
                {
                    Console.WriteLine("Digite um valor válido:");
                }
                switch (option)
                {
                    case 1:
                        Registration.AddService();
                        break;
                    case 2:
                        Search.Options();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
                do
                {
                    Console.WriteLine("Deseja realizar outra operação (S/N)?");
                    validate = Console.ReadLine().ToUpper();
                } while (!Validations.Resposta(validate));
                loop = Validations.SimNao(validate);
            } while (loop);
        }
    }
}
