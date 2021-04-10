using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Depositor : Client
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Фамилия: " + SecondName);
            Console.WriteLine("Дата открытия вклада: " + DateOfCreation);
            Console.WriteLine("Размер вклада: " + DepositSize);
            Console.WriteLine("Процент по вкладу: " + Percent);
        }
    }
}
