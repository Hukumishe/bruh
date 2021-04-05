using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    abstract class Trans
    {
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }
        public int Thrust { get; set; }


        
        public abstract void ShowInfo();

    }
}
