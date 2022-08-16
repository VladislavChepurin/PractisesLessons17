using PractisesLessons17.Interface;

namespace PractisesLessons17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            IAccount аccountSalary = new Account() { Balance = random.Next(160000, 180000), Interest = random.Next(5, 7) };
            var salaryInterest = new SalaryCalculator();
            salaryInterest.CalculateInterest(аccountSalary);

            IAccount аccountUsually = new Account() { Balance = random.Next(450000, 620000), Interest = random.Next(2, 4) };
            var usuallyInterest = new SalaryCalculator();
            usuallyInterest.CalculateInterest(аccountUsually);
        }
    }
}