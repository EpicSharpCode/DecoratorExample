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
            IPizza tooMuchCheese = new CheeseAdding(new CheeseAdding(new FourCheese()));
            Console.WriteLine(tooMuchCheese.GetPizzaInfo());
            IPizza tooSpicyPizza = new JalapenoAdding(new JalapenoAdding(new Diablo()));
            Console.WriteLine(tooSpicyPizza.GetPizzaInfo());
            IPizza pepperoniMargarita = new PepperoniAdding(new Margarita());
            Console.WriteLine(pepperoniMargarita.GetPizzaInfo());

            Console.ReadKey();
        }
    }
}
