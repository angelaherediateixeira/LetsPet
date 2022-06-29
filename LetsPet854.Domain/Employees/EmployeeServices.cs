using LetsPet854.Domain.Common.Enuns;

namespace LetsPet854.Domain.Employees
{
    public class EmployeeServices
    {
        public List<Species> Species { get; set; }
        public List<ServiceType> Types { get; set; }
        public List<BreedSize> Sizes { get; set; }
        public bool MeetsSpecialNeeds { get; set; }
        public bool MeetsAggressiveAnimal { get; set; }
        public EmployeeServices(List<BreedSize> sizes, List<ServiceType> types, List<Species> species, bool meetsSpecialNeeds, bool meetsAggressiveAnimal)
        {
            Types = types;
            Species = species;
            Sizes = sizes;
            MeetsSpecialNeeds = meetsSpecialNeeds;
            MeetsAggressiveAnimal = meetsAggressiveAnimal;
        }
    }
}