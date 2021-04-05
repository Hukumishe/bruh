using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Book : Product
    {
        public Book()
        {
            Type = "книга";
        }
        public string Author { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название книги: " + Name);
            Console.WriteLine("Издатель: " + Manufacturer);
            Console.WriteLine("Рассчитываемый возраст: до " + Age);
            Console.WriteLine("Цена: " + Cost + " тг");
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine();
        }
    }
}
