using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Product> products = new List<Product>();
            List<Set> sets = new List<Set>();
            List<Consignment> consignments = new List<Consignment>();

            for (int i = 0; i < random.Next(1, 100); i++)
            {
                Product product = new Product();
                Set set = new Set();
                Consignment consignment = new Consignment();
                List<string> listForSet = new List<string>();

                for (int j = 0; j < random.Next(1, 20); j++)
                {
                    string element = string.Format("Object_{0}", random.Next(1,50));
                    listForSet.Add(element);
                }

                product.Name = string.Format("Name_{0}", random.Next(1, 30));
                product.Cost = random.Next(1, 50);
                product.ShelfLife = DateTime.Now.AddDays(random.Next(10000));
                product.DateOfCreation = DateTime.Now.AddDays(random.Next(1000) - 10000);

                set.Name = string.Format("Name_{0}", random.Next(1, 30));
                set.Cost = random.Next(1, 50);
                set.ShelfLife = DateTime.Now.AddDays(random.Next(10000));
                set.DateOfCreation = DateTime.Now.AddDays(random.Next(1000) - 10000);
                set.ListOfProducts = listForSet;

                consignment.Name = string.Format("Name_{0}", random.Next(1, 30));
                consignment.Cost = random.Next(1, 50);
                consignment.Quantity = random.Next(1, 1000);
                consignment.ShelfLife = DateTime.Now.AddDays(random.Next(10000));
                consignment.DateOfCreation = DateTime.Now.AddDays(random.Next(1000) - 10000);


                products.Add(product);
                sets.Add(set);
                consignments.Add(consignment);
            }


            Console.WriteLine("Введите срок годности: ");
            int ShelfLife = int.Parse(Console.ReadLine());
            Console.WriteLine(" -- Результат поиска -- ");
            bool isFind = false;

            Console.WriteLine("Продукты");
            foreach (Product product in products)
            {
                if (product.ShelfLife.Year == ShelfLife)
                {
                    product.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }

            }


            Console.WriteLine("Партии");
            foreach (Consignment consignment in consignments)
            {
                if (consignment.ShelfLife.Year == ShelfLife)
                {
                    consignment.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine("Комплекты");
            foreach (Set set in sets)
            {
                if (set.ShelfLife.Year == ShelfLife)
                {
                    set.ShowInfo();
                    isFind = true;
                    Console.WriteLine();
                }

            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            if (!isFind)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подобных товаров у нас нет!");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
        }
    }
}
