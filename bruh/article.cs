using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class article : edition
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string JournalName { get; set; }
        public int ArticleNumber { get; set; }
        public DateTime DateOfPublish { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Имя автора: " + FirstName);
            Console.WriteLine("Фамилия автора: " + SecondName);
            Console.WriteLine("Название журнала: " + JournalName);
            Console.WriteLine("Номер издания: " + ArticleNumber);
            Console.WriteLine("Дата публикации: " + DateOfPublish);
        }
    }
}
