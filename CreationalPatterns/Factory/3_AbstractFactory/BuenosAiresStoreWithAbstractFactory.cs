namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public class BuenosAiresStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public BuenosAiresStoreWithAbstractFactory() :
            this(new BuenosAiresPizzaFactory())
        { }
        public BuenosAiresStoreWithAbstractFactory(IPizzaFactory pizzaFactory)
            : base(pizzaFactory) { }
    }
}
