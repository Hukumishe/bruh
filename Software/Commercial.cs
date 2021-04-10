using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    class Commercial : Software
    {
        public DateTime InstallationDate { get; set; }
        public int Cost { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название ПО: " + Name);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Цена: " + Cost);
            Console.WriteLine("Дата установки: " + InstallationDate);
            Console.WriteLine("Пробный период: до " + UsagePeriod);
        }
    }
}
