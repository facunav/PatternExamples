using CreationalPatterns.Factory;
using CreationalPatterns.Factory._1_SimpleFactory;
using CreationalPatterns.Factory._2_FactoryMethod;
using CreationalPatterns.Factory._3_AbstractFactory;
using CreationalPatterns.Prototype;
using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;

namespace CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //FACTORY PATTERN EXAMPLE
            #region FactoryPattern
            //Pizza example

            Console.WriteLine("\nFACTORY PATTERN EXAMPLE");
            Console.ReadKey();

            Console.WriteLine("\nSimple Factory Method");
            Console.ReadKey();

            Console.WriteLine("\nSelect Pizza type:");
            Console.WriteLine("\n0 - Muzzarella");
            Console.WriteLine("\n1 - Napolitana");
            Console.WriteLine("\n2 - Especial");
            int type = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            IPizza pizza = null;

            switch (type)
            {
                case (int)PizzaType.Muzzarella:
                    pizza = SimplePizzaFactory.CreatePizza(PizzaType.Muzzarella, new List<string>() { "Mozzarella", "Oregano" });
                    break;
                case (int)PizzaType.Napolitana:
                    pizza = SimplePizzaFactory.CreatePizza(PizzaType.Napolitana, new List<string>() { "Mozzarella", "Tomate", "Albahaca" });
                    break;
                case (int)PizzaType.Especial:
                    pizza = SimplePizzaFactory.CreatePizza(PizzaType.Especial, new List<string>() { "Mozzarella", "Jamon", "Morron" });
                    break;
            }            

            Console.WriteLine($"You asked for {pizza.Type} pizza!!!");

            Console.WriteLine("\nFactory Method");
            Console.ReadKey();

            Console.WriteLine("\nSelect Pizza type:");
            Console.WriteLine("\n0 - Mozzarella");
            Console.WriteLine("\n1 - Napolitana");
            Console.WriteLine("\n2 - Especial");
            int type2 = int.Parse(Console.ReadKey().KeyChar.ToString());

            var ingredients = new List<string>();

            switch (type2)
            {
                case (int)PizzaType.Muzzarella:
                    ingredients = new List<string>() { "Mozzarella", "Oregano" };
                    break;
                case (int)PizzaType.Napolitana:
                    ingredients = new List<string>() { "Mozzarella", "Tomate", "Albahaca" };
                    break;
                case (int)PizzaType.Especial:
                    ingredients = new List<string>() { "Mozzarella", "Jamon", "Morron" };
                    break;
            }

            Console.WriteLine("\nSelect Pizza store:");
            Console.WriteLine("\n0 - Mar del Plata Store");
            Console.WriteLine("\n1 - Buenos Aires Store");
            Console.WriteLine("\n2 - Mendoza Store");
            int store = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            IPizza pizza2 = null;
            string description = "";

            switch (store)
            {
                case (int)PizzaStoreCity.MarDelPlata:
                    pizza2 = new MarDelPlataPizzaStore().OrderPizza(ingredients);
                    description = "Mar Del Plata";
                    break;
                case (int)PizzaStoreCity.BuenosAires:
                    pizza2 = new BuenosAiresPizzaStore().OrderPizza(ingredients);
                    description = "Buenos Aires";
                    break;
                case (int)PizzaStoreCity.Mendoza:
                    pizza2 = new MendozaPizzaStore().OrderPizza(ingredients);
                    description = "Mendoza";
                    break;
            }

            var ingredientsSelected = "";
            foreach (var item in pizza2.Toppings)
            {
                ingredientsSelected = $"{ingredientsSelected} {item}";
            }

            Console.WriteLine($"You asked for a pizza with {ingredientsSelected} from {description}!!!");

            Console.WriteLine("\nAbstract Factory Method");
            Console.ReadKey();

            Console.WriteLine("\nSelect Pizza type:");
            Console.WriteLine("\n0 - Mozzarella");
            Console.WriteLine("\n1 - Napolitana");
            Console.WriteLine("\n2 - Especial");
            int type3 = int.Parse(Console.ReadKey().KeyChar.ToString());

            ingredients = new List<string>();

            switch (type3)
            {
                case (int)PizzaType.Muzzarella:
                    ingredients = new List<string>() { "Mozzarella", "Oregano" };
                    break;
                case (int)PizzaType.Napolitana:
                    ingredients = new List<string>() { "Mozzarella", "Tomate", "Albahaca" };
                    break;
                case (int)PizzaType.Especial:
                    ingredients = new List<string>() { "Mozzarella", "Jamon", "Morron" };
                    break;
            }

            Console.WriteLine("\nSelect Pizza store:");
            Console.WriteLine("\n0 - Mar del Plata Store");
            Console.WriteLine("\n1 - Buenos Aires Store");
            Console.WriteLine("\n2 - Mendoza Store");
            int store3 = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            IPizza pizza3 = null;
            description = "";

            switch (store3)
            {
                case (int)PizzaStoreCity.MarDelPlata:
                    pizza3 = new MarDelPlataStoreWithAbstractFactory(new MarDelPlataPizzaFactory()).OrderPizza(ingredients);
                    description = "Mar Del Plata";
                    break;
                case (int)PizzaStoreCity.BuenosAires:
                    pizza3 = new BuenosAiresStoreWithAbstractFactory(new BuenosAiresPizzaFactory()).OrderPizza(ingredients);
                    description = "Buenos Aires";
                    break;
                case (int)PizzaStoreCity.Mendoza:
                    pizza3 = new MendozaStoreWithAbstractFactory(new MendozaPizzaFactory()).OrderPizza(ingredients);
                    description = "Mendoza";
                    break;
            }

            ingredientsSelected = "";
            foreach (var item in pizza3.Toppings)
            {
                ingredientsSelected = $"{ingredientsSelected} {item}";
            }

            Console.WriteLine($"You asked for a pizza with {ingredientsSelected} from {description}!!!");
            #endregion FactoryPattern

            //PROTOTYPE PATTERN EXAMPLE
            #region PrototypePattern
            //Employee example

            Console.WriteLine("\nPROTOTYPE PATTERN EXAMPLE");
            Console.ReadKey();

            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Pranaya";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            Console.Read();

            #endregion PrototypePattern

            //SINGLETON PATTERN EXAMPLE
            #region SingletonPattern
            //Singleton example

            Console.WriteLine("\nSINGLETON PATTERN EXAMPLE");
            Console.ReadKey();

            MySingletonService serviceInstance1 = MySingletonService.GetInstance();
            Console.WriteLine($"Service intance 1: {serviceInstance1.GetCreationCount()}");

            MySingletonService serviceInstance2 = MySingletonService.GetInstance();
            Console.WriteLine($"Service intance 2: {serviceInstance2.GetCreationCount()}");

            Console.ReadLine();

            #endregion SingletonPattern
        }
    }
}
