﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product : Goods
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Название товара: " + Name);
            Console.WriteLine("Цена: " + Cost);
            Console.WriteLine("Дата производства: " + DateOfCreation);
            Console.WriteLine("Срок годности: " + ShelfLife);
        }
    }
}
