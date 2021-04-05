using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Truck : Trans
    {
        private bool IsTrailer_;

        public bool IsTrailer
        {
            get
            {
                return IsTrailer_;
            }

            set
            {
                if (value)
                    base.Thrust *= 2;
                IsTrailer_ = value;
            }
        }

        public override void ShowInfo()
        {
            
            Console.WriteLine("Марка грузовика: " + Brand);
            Console.WriteLine("Скорость: " + Speed + " км/час");
            Console.WriteLine("Гос. номер: " + Number);
            Console.WriteLine("Тянет: " + Thrust + " кг.");
            Console.WriteLine("Наличие прицепа: " + IsTrailer);
        }
    }
}
