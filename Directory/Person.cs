using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Person : PhoneDirectory
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Фамилия: " + Name);
            Console.WriteLine("Адрес проживания: " + Adress);
            Console.WriteLine("Телефонный номер: " + PhoneNumber);
        }
    }
}
