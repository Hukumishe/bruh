using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Organization : Client
    {
        public int AccountNumber { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название: " + SecondName);
            Console.WriteLine("Дата открытия счета: " + DateOfCreation);
            Console.WriteLine("Номер счета: " + AccountNumber);
            Console.WriteLine("Сумма на счету: " + DepositSize);
        }
    }
}
