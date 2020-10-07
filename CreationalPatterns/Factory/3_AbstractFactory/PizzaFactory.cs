using System.Collections.Generic;

namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> ingredients);
    }
}
