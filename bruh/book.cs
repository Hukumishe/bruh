using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class book : edition
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfPublish { get; set; }
        public string PublishingHouse { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Имя автора: " + FirstName);
            Console.WriteLine("Фамилия автора: " + SecondName);
            Console.WriteLine("Дата публикации: " + DateOfPublish);
            Console.WriteLine("Издательство: " + PublishingHouse);
            Console.WriteLine("-----------------------------------");
        }
    }
}
