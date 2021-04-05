using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Student : Persona
    {
        public int Course { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Фамилия: " + SecondName);
            Console.WriteLine("Дата рождения: " + BirthDay);
            Console.WriteLine("Факультет: " + Faculty);
            Console.WriteLine("Курс: " + Course);
        }
    }
}
