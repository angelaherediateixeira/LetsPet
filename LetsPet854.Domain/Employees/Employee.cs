namespace LetsPet_Employees
{
    public class Employee : Person
    {
        private BankInfo BankData { get; set; }
        private Dictionary<DateTime, decimal> Salaries { get; set; }
        private EmployeeServices ServicesType { get; set; }
        private bool ActiveEmployee { get; set; }
        private DateTime DismissalDate { get; set; }
        private DateTime[] Schedule { get; set; }

        public Employee(string cpf, string name, DateTime birthDate, BankInfo bankData,
            decimal salary, EmployeeServices servicesType, DateTime[] schedule)
        {
            Cpf = cpf;
            Name = name;
            BirthDate = birthDate;
            RegisterDate = DateTime.Now;
            PersonContact = new Contact();
            BankData = bankData;
            ServicesType = servicesType;
            ActiveEmployee = true;
            Schedule = schedule;
            DismissalDate = DateTime.MinValue;
            DateTime effectiveDate = DateTime.Now;
            Salaries.Add(effectiveDate, salary);
        }
        public void UpdateDismissalDate(DateTime dismissalDate)
        {
            Console.WriteLine("Data de desligamento: ");
            DismissalDate = dismissalDate;
            UpdateStatus();
        }
        public void UpdateStatus()
        {
            if (DismissalDate != DateTime.MinValue)
            {
                ActiveEmployee = false;
            }
        }
        public void UpdateSalary(decimal salary)
        {
            Salaries.Add(DateTime.Now, salary);
        }
        public void UpdateSchedule(DateTime[] schedule)
        {
            Schedule = schedule;
        }

        public decimal GetSalary()
        {
            return Salaries.Values.Last();
        }

    }
}
