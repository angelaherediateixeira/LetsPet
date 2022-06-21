namespace LetsPet_Employees
{
    public class Employee : Person
    {
        public BankInfo BankData { get; set; }
        public decimal Salary { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool ActiveEmployee { get; set; }
        public DateTime DismissalDate { get; set; }
    }
}
