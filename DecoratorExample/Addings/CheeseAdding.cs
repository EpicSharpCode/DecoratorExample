using DecoratorExample.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Addings
{
    internal class CheeseAdding : AddingDecoratorBase
    {
        public CheeseAdding(PizzaBase _pizza) : base(_pizza)
        {
            name = "Cheese";
            price = 4;
        }
    }
}
