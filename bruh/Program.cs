using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class Program
    {

        static void Task1()
        {
            List<article> b = new List<article>();
            Random rnd = new Random();
            

            List<book> books = new List<book>();
            for (int i = 0; i < rnd.Next(); i++)
            {
                book book = new book();
                book.Adress = string.Format("Adress_{0}", rnd.Next(1, 30));
                book.SecondName = string.Format("SecondName_{0}", rnd.Next(1, 9999));
                book.FirstName = string.Format("FirstName_{0}", rnd.Next(1, 30));
                book.PublishingHouse = string.Format("PublishingHouse_{0}", rnd.Next(1, 30));
                book.DateOfPublish = DateTime.Now.AddMonths(rnd.Next(1, 12));

                books.Add(book);
            }

            /*int k = 0;
            foreach (book book in books)
            {
                book.ShowInfo();
                Console.WriteLine("----------------");
                k++;
                if (k >= 10) break;
                
            }*/

            while (true) {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Введите имя автора:");
                string SearchWriter = Console.ReadLine();
                Console.WriteLine(" -- Результат поиска -- ");
                bool isFind = false;

                foreach (book book in books)
                {
                    if (book.SecondName == SearchWriter)
                    {
                        isFind = true;
                        book.ShowInfo();
                        
                    }
                }
                if (!isFind)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такого автора нет!");
                }
                Console.ReadLine();
            }

        }
        static void Main(string[] args)
        {
            Task1();

        }
    }
}
