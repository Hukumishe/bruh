using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class LightCar : Trans
    {
        public override void ShowInfo()
        {
            
            Console.WriteLine("Марка машины: " + Brand);
            Console.WriteLine("Скорость: " + Speed + " км/час");
            Console.WriteLine("Гос. номер: " + Number);
            Console.WriteLine("Тянет: " + Thrust + " кг.");
        }
    }
}
