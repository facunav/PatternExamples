using System.Collections.Generic;

namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public class MendozaPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new MendozaPizza(ingredients);
        }
    }
}
