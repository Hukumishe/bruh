using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Creditor : Client
    {
        public int BalanceOwed { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Фамилия: " + SecondName);
            Console.WriteLine("Дата выдачи кредита: " + DateOfCreation);
            Console.WriteLine("Размер кредита: " + DepositSize);
            Console.WriteLine("Процент по кредиту: " + Percent);
            Console.WriteLine("Остаток задолжности: " + BalanceOwed);
        }
    }
}
