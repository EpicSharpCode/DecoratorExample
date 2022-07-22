using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Pizza
{
    internal class Margarita : PizzaBase
    {
        public Margarita()
        {
            name = "Base Margarita";
            price = 10;
        }
    }
}
