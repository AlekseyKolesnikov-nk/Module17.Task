namespace Module17.Task;

public class OrdinaryAccount : IAccount
{
    public string Type { get; set; }
    
    public double Balance { get; set; }
    
    public double Interest { get; set; }

    public OrdinaryAccount(double balance)
    {
        Type = "Обычный";
        Balance = balance;
    }
    
    // Метод для расчета процентной ставки
    public void CalculateInterest()
    {
        // расчет процентной ставки обычного аккаунта
        if (this.Balance < 1000)
            // при остатке на счете менее 1000 ставка 0,2
            this.Interest = this.Balance * 0.2;
        else
            // при остатке на счете 1000 и более ставка 0,4
            this.Interest = this.Balance * 0.4;
    }
}
