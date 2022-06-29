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
        public static string answer;

        public static void DefaultMenu()
        {
            Console.Clear();
            Console.WriteLine("Opções de serviço:");
            Console.WriteLine("1 - Cadastro de Serviços e Descontos\n2 - Buscar serviço\n3 - Relatório de serviços prestados\n4 - Relatório de produtos por serviço prestado");
            option = Validations.Options(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine($"1 - Cadastro de Serviços\n2 - Cadastro de Descontos");
                    option = Validations.Options(1, 2);
                    if (option == 1)
                        Registration.AddService();
                    else
                        Registration.AddDiscount();
                    break;
                case 2:
                    Search.Options();
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            EndProgram();
        }

        public static void EndProgram()
        {
            Console.WriteLine("Deseja realizar outra operação de serviço (S/N)?");
            if (Validations.YesOrNo())
            {
                DefaultMenu();
            }
            else
            {
                Console.WriteLine("Menu de serviços encerrado.");
            }
        }
    }
}
