using System.Collections.Generic;

namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(IList<string> ingredients);
    }
}
