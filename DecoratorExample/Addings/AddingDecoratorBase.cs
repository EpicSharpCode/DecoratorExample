using DecoratorExample.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Addings
{
    internal abstract class AddingDecoratorBase : PizzaBase
    {
        PizzaBase pizza;

        public AddingDecoratorBase(PizzaBase _pizza)
        {
            pizza = _pizza;
        }

        public override string GetName()
        {
            return $"{pizza.GetName()} + {base.GetName()}";
        }

        public override decimal GetPrice()
        {
            return pizza.GetPrice() + base.GetPrice();
        }
    }
}
