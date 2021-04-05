using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    abstract class Persona
    {
        public string SecondName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Faculty { get; set; }

        public abstract void ShowInfo();
    }
}
