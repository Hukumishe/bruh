using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Teacher : Persona
    {
        public string Position { get; set; }
        public DateTime Experience { get; set; }

        public Teacher()
        {
            Random random = new Random();
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Фамилия: " + SecondName);
            Console.WriteLine("Дата рождения: " + BirthDay);
            Console.WriteLine("Факультет: " + Faculty);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Стаж: " + (DateTime.Now.Year - Experience.Year) + " (в годах)");
        }
    }
}
