using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Pizza
{
    internal class Diablo : PizzaBase
    {
        public Diablo()
        {
            name = "Base Diablo";
            price = 15;
        }
    }
}
