using LetsPet854.Domain.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Business.Pets
{
    public static class SearchGuardian
    {
        public static Guardian SearchGuardianByCPF(string CPF)
        {
            var FilteredGuardian = (
                from guardian in Guardian.GuardiansList
                where guardian.Cpf.Equals(CPF)
                select guardian
                );
            if (FilteredGuardian.Count() == 0)
            {
                Console.WriteLine($"Nenhum tutor com o CPF {CPF} foi encontrado no sistema.");
                return null;
            }
            return FilteredGuardian.First();
        }

        public static List<Guardian> SearchGuardianByName(string Name)
        {
            var FilteredGuardian = (
                from guardian in Guardian.GuardiansList
                where guardian.Name.Contains(Name)
                select guardian
                ).ToList();

            if (FilteredGuardian.Count() == 0)
            {
                Console.WriteLine($"Nenhum tutor com o nome {Name} foi encontrado no sistema.");
                return null;
            }

            return FilteredGuardian;
        }
    }
}
