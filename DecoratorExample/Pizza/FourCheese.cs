using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Pizza
{
    internal class FourCheese : PizzaBase
    {
        public FourCheese()
        {
            name = "Base Four Cheese";
            price = 20;
        }
    }
}
