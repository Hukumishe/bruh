using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class Esource : edition
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Link { get; set; }
        public string Annotation { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine("Имя автора: " + Name);
            Console.WriteLine("Фамилия автора: " + SecondName);
            Console.WriteLine("Ссылка: " + Link);
            Console.WriteLine("Аннотация: " + Annotation);
        }
    }
}
