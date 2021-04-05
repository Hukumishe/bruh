using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class SportInventory : Product
    {
        public SportInventory()
        {
            Type = "инвентарь";
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Название снаряда: " + Name);
            Console.WriteLine("Произведено: " + Manufacturer);
            Console.WriteLine("Рассчитываемый возраст: до " + Age);
            Console.WriteLine("Цена: " + Cost + " тг");
            Console.WriteLine();
        }
    }
}
