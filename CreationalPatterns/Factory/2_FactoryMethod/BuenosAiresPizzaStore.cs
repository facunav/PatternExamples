using System.Collections.Generic;

namespace CreationalPatterns.Factory._2_FactoryMethod
{
    public class BuenosAiresPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            //This is tied to a specific pizza implementation
            return new BuenosAiresPizza(ingredients);
        }
    }
}
