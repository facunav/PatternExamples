using System.Collections.Generic;

namespace CreationalPatterns.Factory._1_SimpleFactory
{
    public static class SimplePizzaFactory
    {
        public static IPizza CreatePizza(PizzaType type, IList<string> ingredients)
        {
            switch (type)
            {
                case PizzaType.Muzzarella:
                    return new MarDelPlataPizza(ingredients);
                case PizzaType.Napolitana:
                    return new MendozaPizza(ingredients);
                case PizzaType.Especial:
                    return new BuenosAiresPizza(ingredients);
                default:
                    return null;
            }
        }
    }
}
