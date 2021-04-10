using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Client
    {
        public string SecondName { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int DepositSize { get; set; }
        public int Percent { get; set; }

        abstract public void ShowInfo();
    }
}
