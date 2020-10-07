using System.Collections.Generic;

namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public class MarDelPlataPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new MarDelPlataPizza(ingredients);
        }
    }
}
