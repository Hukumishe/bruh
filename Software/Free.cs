using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    class Free : Software
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Название ПО: " + Name);
            Console.WriteLine("Производитель: " + Manufacturer);
        }


    }
}
