using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Book> books = new List<Book>();
            List<Toy> toys = new List<Toy>();
            List<SportInventory> inventory = new List<SportInventory>();

            for (int i = 0; i < random.Next(1, 100); i++)
            {
                Book book = new Book();
                Toy toy = new Toy();
                SportInventory item = new SportInventory();

                book.Name = string.Format("Book_{0}", random.Next(1, 30));
                book.Cost = random.Next(1, 10000);
                book.Author = string.Format("Author_{0}", random.Next(1, 30));
                book.Manufacturer = string.Format("Publisher_{0}", random.Next(1, 30));
                book.Age = DateTime.Now.AddDays(random.Next(10000));

                toy.Name = string.Format("Toy_{0}", random.Next(1, 30));
                toy.Cost = random.Next(1, 10000);
                toy.Manufacturer = string.Format("Manufacturer_{0}", random.Next(1, 30));
                toy.Material = string.Format("Material_{0}", random.Next(1, 30));
                toy.Age = DateTime.Now.AddDays(random.Next(10000));

                item.Name = string.Format("SportItem_{0}", random.Next(1, 30));
                item.Cost = random.Next(1, 10000);
                item.Manufacturer = string.Format("Manufacturer_{0}", random.Next(1, 30));
                item.Age = DateTime.Now.AddDays(random.Next(10000));


                books.Add(book);
                toys.Add(toy);
                inventory.Add(item);
            }


            Console.WriteLine("Какой тип товара вы ищите?");
            Console.WriteLine("1. Игрушки");
            Console.WriteLine("2. Книги");
            Console.WriteLine("3. Спорт. инвентарь");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine(" -- Результат поиска -- ");

            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Игрушки:");
                        foreach (Toy toy in toys)
                        {
                            toy.ShowInfo();
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Книги:");
                    foreach (Book book in books)
                    {
                        book.ShowInfo();
                    }
                    break;
                case 3:
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Спорт. инвентарь:");
                    foreach (SportInventory item in inventory)
                    {
                        item.ShowInfo();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Такого у нас нет");
                    }
                    break;
            }
        }
    }
}