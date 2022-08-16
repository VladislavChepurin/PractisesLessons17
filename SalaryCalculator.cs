using PractisesLessons17.Interface;

namespace PractisesLessons17;

public class SalaryCalculator : ICalculate
{
    public void CalculateInterest(IAccount account)
    {
        // расчет процентной ставк зарплатного аккаунта по правилам банка
        account.Interest = account.Balance * 0.5;
    }
}