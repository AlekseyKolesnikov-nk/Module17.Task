namespace Module17.Task;

    public interface IAccount
    {
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }
    public void CalculateInterest();
}

