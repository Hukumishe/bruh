using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    class Shareware : Software
    {
        public DateTime InstallationDate { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название ПО: " + Name);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Дата установки: " + InstallationDate);
            Console.WriteLine("Пробный период: до " + UsagePeriod);
        }
    }
}
