using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Pizza
{
    public interface IPizza
    {
        decimal GetPrice();
        string GetName();
        string GetPizzaInfo();
    }
}
