using DecoratorDesignPattern;
using StructuralPatterns.Adapter;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using StructuralPatterns.Proxy;
using System;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADAPTER PATTERN EXAMPLE
            #region AdapterPattern
            //Adapt a XML to JSON example

            Console.WriteLine("\nADAPTER PATTERN EXAMPLE");
            Console.ReadKey();

            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
            #endregion AdapterPattern

            //FACADE PATTERN EXAMPLE
            #region FacadePattern
            //Restaurant example

            Console.WriteLine("\nFACADE PATTERN EXAMPLE");
            Console.ReadKey();

            var restaurant = new OnlineRestaurant();
            var shippingService = new ShippingService();
            var chickenOrder = new Order() { DishName = "Chicken with rice", DishPrice = 20.0, User = "User1", ShippingAddress = "Random street 123" };
            var sushiOrder = new Order() { DishName = "Sushi", DishPrice = 52.0, User = "User2", ShippingAddress = "More random street 321" };
            restaurant.AddOrderToCart(chickenOrder);
            restaurant.AddOrderToCart(sushiOrder);
            restaurant.CompleteOrders();
            shippingService.AcceptOrder(chickenOrder);
            shippingService.CalculateShippingExpenses();
            shippingService.ShipOrder();
            shippingService.AcceptOrder(sushiOrder);
            shippingService.CalculateShippingExpenses();
            shippingService.ShipOrder();
            Console.ReadLine();

            #endregion FacadePattern

            //DECORATOR PATTERN EXAMPLE
            #region DecoratorPattern
            //Cars example

            Console.WriteLine("\nDECORATOR PATTERN EXAMPLE");
            Console.ReadKey();

            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();

            #endregion DecoratorPattern

            //PROXY PATTERN EXAMPLE
            #region ProxyPattern
            //Employees example

            Console.WriteLine("\nPROXY PATTERN EXAMPLE");
            Console.ReadKey();

            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee2 emp1 = new Employee2("Anurag", "Anurag123", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee2 emp2 = new Employee2("Pranaya", "Pranaya123", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
            Console.Read();
            Console.ReadKey();

            #endregion ProxyPattern
        }
    }
}
