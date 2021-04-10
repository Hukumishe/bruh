using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Free> freeCopies = new List<Free>();
            List<Commercial> commercialCopies = new List<Commercial>();
            List<Shareware> sharewareCopies = new List<Shareware>();

            for (int i = 0; i < random.Next(1, 100); i++)
            {
                Free freeCopy = new Free();
                Commercial commercialCopy = new Commercial();
                Shareware sharewareCopy = new Shareware();


                freeCopy.Name = string.Format("Name_{0}", random.Next(1, 30));
                freeCopy.Manufacturer = string.Format("Manufacturer_{0}", random.Next(1, 30));

                commercialCopy.Name = string.Format("Name_{0}", random.Next(1, 30));
                commercialCopy.Manufacturer = string.Format("Manufacturer{0}", random.Next(1, 50));
                commercialCopy.InstallationDate = DateTime.Now.AddDays(-random.Next(10000));
                commercialCopy.UsagePeriod = DateTime.Now.AddDays(random.Next(10000));
                commercialCopy.Cost = random.Next(1, 10000);

                sharewareCopy.Name = string.Format("Name_{0}", random.Next(1, 30));
                sharewareCopy.Manufacturer = string.Format("Manufacturer{0}", random.Next(1, 50));
                sharewareCopy.InstallationDate = DateTime.Now.AddDays(-random.Next(10000));
                sharewareCopy.UsagePeriod = DateTime.Now.AddDays(random.Next(10000));


                freeCopies.Add(freeCopy);
                commercialCopies.Add(commercialCopy);
                sharewareCopies.Add(sharewareCopy);
            }


            Console.WriteLine(" -- Результат поиска -- ");
            bool isFind = false;

            Console.WriteLine("Бесплатное ПО");
            foreach (Free freeCopy in freeCopies)
            {
                freeCopy.ShowInfo();
                isFind = true;
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("Условно-бесплатное ПО");
            foreach (Shareware sharewareCopy in sharewareCopies)
            {
                if (sharewareCopy.CheckDate() == true)
                {
                    sharewareCopy.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Платное ПО");
            foreach (Commercial commercialCopy in commercialCopies)
            {
                if (commercialCopy.CheckDate() == true)
                {
                    commercialCopy.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            if (!isFind)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подобного ПО у нас нет!");
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
