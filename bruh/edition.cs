using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    abstract class edition
    {
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfCreation { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Текущий адресс: " + Adress);
            Console.WriteLine("Текущий телефонный номер: " + PhoneNumber);
            Console.WriteLine("Дата основания издательства: " + DateOfCreation );
        }
    }
}
