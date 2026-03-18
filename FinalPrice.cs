using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscount
{
    internal class FinalPrice
    {
        static void Main(string[] args)
        {
            Product p = new Product(1, "Mobile", 65000, 10);
            Product p1 = new Product(2, "TV", 70000, 8);
            p.Display();
            p1.Display();
        }
    }
}
