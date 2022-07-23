using DecoratorExample.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Addings
{
    internal class PepperoniAdding : AddingDecoratorBase
    {
        public PepperoniAdding(PizzaBase _pizza) : base(_pizza)
        {
            name = "Pepperoni";
            price = 5;
        }
    }
}
