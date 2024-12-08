using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Task
{
    public class Calculator
    {
        public IAccount _account;
        public Calculator(IAccount a)
        {
            _account = a;
        }

        public void Calculate()
        {
            _account.CalculateInterest();
            Console.WriteLine($"Проект: {_account.Type}, баланс: {_account.Balance}. Процентная ставка: {_account.Interest}");
        }
    }
}
