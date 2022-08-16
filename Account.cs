using PractisesLessons17.Interface;

namespace PractisesLessons17;

public class Account : IAccount
{
    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }

}
