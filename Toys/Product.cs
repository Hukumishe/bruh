using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    abstract class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime Age { get; set; }
        public int Cost { get; set; }

        public abstract void ShowInfo();
    }
}
