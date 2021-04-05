using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Set : Goods
    {
        public List<string> ListOfProducts { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Cost);
            Console.WriteLine("Перечень:");
            foreach (string element in ListOfProducts)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}
