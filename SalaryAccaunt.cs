using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Task
{
    public class SalaryAccount : IAccount
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
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
}
