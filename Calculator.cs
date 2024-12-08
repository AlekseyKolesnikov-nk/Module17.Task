namespace Module17.Task;

public class Calculator
{
    public IAccount _account;
    public Calculator(IAccount account)
    {
        _account = account;
    }

    public void Calculate()
    {
        _account.CalculateInterest();
        Console.WriteLine($"Проект: {_account.Type}, баланс: {_account.Balance}. Процентная ставка: {_account.Interest}");
    }
}
