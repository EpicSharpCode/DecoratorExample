using DecoratorExample.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Addings
{
    internal class JalapenoAdding : AddingDecoratorBase
    {
        public JalapenoAdding(PizzaBase _pizza) : base(_pizza)
        {
            name = "Jalapeno";
            price = 2;
        }
    }
}
