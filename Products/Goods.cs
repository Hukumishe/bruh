using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    abstract class Goods
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime ShelfLife { get; set; }

        public abstract void ShowInfo();
    }
}
