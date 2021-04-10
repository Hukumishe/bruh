using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Creditor> creditors = new List<Creditor>();
            List<Depositor> depositors = new List<Depositor>();
            List<Organization> organizations = new List<Organization>();

            for (int i = 0; i < random.Next(1, 100); i++)
            {
                Creditor creditor = new Creditor();
                Depositor depositor = new Depositor();
                Organization organization = new Organization();
                List<string> listForSet = new List<string>();

                for (int j = 0; j < random.Next(1, 20); j++)
                {
                    string element = string.Format("Object_{0}", random.Next(1, 50));
                    listForSet.Add(element);
                }

                creditor.SecondName = string.Format("SecondName_{0}", random.Next(1, 30));
                creditor.DepositSize = random.Next(1, 50000);
                creditor.Percent = random.Next(1, 50);
                creditor.DateOfCreation = DateTime.Now.AddDays(-random.Next(10000));
                creditor.BalanceOwed = random.Next(1, 50000);

                depositor.SecondName = string.Format("SecondName_{0}", random.Next(1, 30));
                depositor.DepositSize = random.Next(1, 50000);
                depositor.Percent = random.Next(1, 50);
                depositor.DateOfCreation = DateTime.Now.AddDays(-random.Next(10000));

                organization.SecondName = string.Format("SecondName_{0}", random.Next(1, 30));
                organization.DepositSize = random.Next(1, 50000);
                organization.Percent = random.Next(1, 50);
                organization.DateOfCreation = DateTime.Now.AddDays(-random.Next(10000));


                creditors.Add(creditor);
                depositors.Add(depositor);
                organizations.Add(organization);
            }


            Console.WriteLine("Введите дату создания счета: ");
            int DateOfCreation = int.Parse(Console.ReadLine());
            Console.WriteLine(" -- Результат поиска -- ");
            bool isFind = false;

            Console.WriteLine();
            Console.WriteLine("Кредиторы");
            foreach (Creditor creditor in creditors)
            {
                if (creditor.DateOfCreation.Year == DateOfCreation)
                {
                    creditor.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine("Вкладчики");
            foreach (Depositor depositor in depositors)
            {
                if (depositor.DateOfCreation.Year == DateOfCreation)
                {
                    depositor.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine("Организации");
            foreach (Organization organization in organizations)
            {
                if (organization.DateOfCreation.Year == DateOfCreation)
                {
                    organization.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }

            }
            
            Console.WriteLine();
            if (!isFind)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine("Подобных счетов у нас нет!");
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
            }
            
            Console.ReadLine();
        }
    }
}
