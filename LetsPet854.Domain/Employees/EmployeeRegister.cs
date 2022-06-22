using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Employees
{
    public class EmployeeRegister
    {
        List<Employee> batata = new List<Employee>();

        public void CreateEmployee()
        {
            // criar um dicionario com chaves de cpf e lista com o resto 

            Console.WriteLine("Cadastrando Funcionario: ");

            string cpf;
            string name;
            DateTime birthDate;
            string bankCode;
            string agency;
            string accountNumber;
            string pixType;
            string pix;
            decimal salary;
            string animalSizes; // 1, 2 ou 3 
            string serviceTypes; // 1, 2 ou 3
            string animaSpecies; // 1, 2, ou 3
            string specialNeeds; // 1 true 2 false
            string agressiveAnimal; // 1 true 2 false

            DateTime[] defaultSchedule = new DateTime[4];
            defaultSchedule[0] = Convert.ToDateTime("09:00:00");  // posicao 1 e 2, vai ser escolhido
            defaultSchedule[3] = Convert.ToDateTime("18:00:00");


            string aux;

            do
            {

                Console.WriteLine("Digite o CPF do funcionario:");
                aux = Console.ReadLine();
                Validation.IsCpfValid(aux);
                Console.ReadKey();

            } while (!Validation.IsCpfValid(aux));

            cpf = aux;
            Console.Clear();

            do
            {
                Console.WriteLine("Digite o nome do funcionario:");
                aux = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(aux))
                    Console.WriteLine("Nome digitado esta em branco");

            } while (!String.IsNullOrWhiteSpace(aux));

            name = aux;
            Console.Clear();


            do
            {
                Console.WriteLine("Digite a data de nascimento do funcionario:");
                aux = Console.ReadLine();
                Validation.IsBirthDateValid(aux);

            } while (!Validation.IsBirthDateValid(aux));

            birthDate = Convert.ToDateTime(aux);
            Console.Clear();


            do
            {
                Console.WriteLine("Digite o codigo do banco");
                aux = Console.ReadLine();
                Validation.IsBankCodeValid(aux);
            }while(!Validation.IsBankCodeValid(aux));
            
            bankCode = aux;
            Console.Clear();


            
        }
    }
}
