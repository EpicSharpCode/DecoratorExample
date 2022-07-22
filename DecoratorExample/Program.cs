using DecoratorExample.Addings;
using DecoratorExample.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza margarita = new Margarita();
            Console.WriteLine(margarita.GetPizzaInfo());
            IPizza jalapeno = new JalapenoAdding(new Margarita());
            Console.WriteLine(jalapeno.GetPizzaInfo());
            IPizza cheese = new CheeseAdding(new JalapenoAdding(new Margarita()));
            Console.WriteLine(cheese.GetPizzaInfo());

            Console.ReadKey();
        }
    }
}
