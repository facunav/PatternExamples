using System.Collections.Generic;

namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public class BuenosAiresPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new BuenosAiresPizza(ingredients);
        }
    }
}
