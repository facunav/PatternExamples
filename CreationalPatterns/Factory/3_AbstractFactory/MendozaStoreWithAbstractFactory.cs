namespace CreationalPatterns.Factory._3_AbstractFactory
{
    public class MendozaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public MendozaStoreWithAbstractFactory() :
            this(new BuenosAiresPizzaFactory())
        { }
        public MendozaStoreWithAbstractFactory(IPizzaFactory pizzaFactory)
            : base(pizzaFactory) { }
    }    
}
