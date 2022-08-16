namespace PractisesLessons17.Interface;

public interface IAccount
{
    // баланс учетной записи
    double Balance { get; set; }

    // процентная ставка
    double Interest { get; set; }
}
