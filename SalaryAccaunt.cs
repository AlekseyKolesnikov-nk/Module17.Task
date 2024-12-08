namespace Module17.Task;

public class SalaryAccount : IAccount
{
    public string Type { get; set; }

    public double Balance { get; set; }

    public double Interest { get; set; }

    public SalaryAccount(double balance)
    {
        Type = "Зарплатный";
        Balance = balance;
    }
    
    // Метод для расчета процентной ставки
    public void CalculateInterest()
    {
        // расчет процентной ставки зарплатного аккаунта
        // при любом остатке на счете ставка 0,5
        this.Interest = this.Balance * 0.5;
    }
}
