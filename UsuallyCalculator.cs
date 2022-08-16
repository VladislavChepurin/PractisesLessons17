using PractisesLessons17.Interface;

namespace PractisesLessons17;

public class UsuallyCalculator : ICalculate
{
    public void CalculateInterest(IAccount account)
    {
        // расчет процентной ставки обычного аккаунта по правилам банка
        account.Interest = account.Balance * 0.4;

        if (account.Balance < 1000)
            account.Interest -= account.Balance * 0.2;

        if (account.Balance < 50000)
            account.Interest -= account.Balance * 0.4;
    }
}
