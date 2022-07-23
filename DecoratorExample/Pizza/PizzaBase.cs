using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Pizza
{
    internal abstract class PizzaBase : IPizza
    {
        public string name;
        public decimal price;

        public PizzaBase() { }

        public virtual string GetName() => name;

        public virtual decimal GetPrice() => price;

        public string GetPizzaInfo() => $"Pizza \"{GetName()}\" for {GetPrice()} $";
    }
}
