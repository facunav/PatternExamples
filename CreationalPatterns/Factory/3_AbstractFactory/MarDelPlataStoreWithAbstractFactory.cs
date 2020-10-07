namespace CreationalPatterns.Factory._3_AbstractFactory
{
    class MarDelPlataStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public MarDelPlataStoreWithAbstractFactory() :
            this(new MarDelPlataPizzaFactory())
        { }

        public MarDelPlataStoreWithAbstractFactory(
            IPizzaFactory pizzaFactory) :
            base(pizzaFactory)
        { }

    }
}
