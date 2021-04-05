using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Motocycle : Trans
    {
        private bool IsStoller_;

        public bool IsStoller
        {
            get
            {
                return IsStoller_;
            }

            set
            {
                if (!value)
                    base.Thrust = 0;
                IsStoller_ = value;
            }
        }
        public override void ShowInfo()
        {
            
            Console.WriteLine("Марка мотоцикла: " + Brand);
            Console.WriteLine("Скорость: " + Speed + " км/час");
            Console.WriteLine("Гос. номер: " + Number);
            Console.WriteLine("Тянет: " + Thrust + " кг.");
            Console.WriteLine("Наличие коляски: " + IsStoller);
        }
    }
}

