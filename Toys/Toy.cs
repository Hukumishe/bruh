using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Toy : Product
    {
        public Toy()
        {
            Type = "игрушка";
        }

        public string Material { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название игрушки: " + Name);
            Console.WriteLine("Произведено: " + Manufacturer);
            Console.WriteLine("Рассчитываемый возраст: до " + Age);
            Console.WriteLine("Цена: " + Cost + " тг");
            Console.WriteLine("Сделано из: " + Material);
            Console.WriteLine();
        }
    }
}
