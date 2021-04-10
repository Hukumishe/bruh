using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    abstract class Software
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime UsagePeriod { get; set; }

        abstract public void ShowInfo();
        public bool CheckDate()
        {
            if (UsagePeriod.Year >= DateTime.Now.Year)
            {
                Console.WriteLine("Срок использования программы еще не истек!");
                return true;
            }
            else
            {
                Console.WriteLine("Срок использования программы уже истек!");
                return false;
            }
        }
    }
}
