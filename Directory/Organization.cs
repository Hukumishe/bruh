using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Organization : PhoneDirectory
    {
        public string Fax { get; set; }
        public string ContactPerson { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Адрес: " + Adress);
            Console.WriteLine("Телефонный номер: " + PhoneNumber);
            Console.WriteLine("Факс: " + Fax);
            Console.WriteLine("Контактное лицо: " + ContactPerson);
        }
    }
}
