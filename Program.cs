namespace Module17.Task;

class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator1 = new Calculator(new SalaryAccount(600));
        calculator1.Calculate();
        Console.WriteLine();

        Calculator calculator2 = new Calculator(new SalaryAccount(1200));
        calculator2.Calculate();
        Console.WriteLine();

        Calculator calculator3 = new Calculator(new OrdinaryAccount(600));
        calculator3.Calculate();
        Console.WriteLine();

        Calculator calculator4 = new Calculator(new OrdinaryAccount(1200));
        calculator4.Calculate();
        Console.WriteLine();
    }
}

