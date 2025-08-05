using ArchitectureTesting.Patterns.Abstract_Factory.Concrete;
using ArchitectureTesting.Patterns.Builder;
using ArchitectureTesting.Patterns.Decorator;
using ArchitectureTesting.Patterns.Mediator;
using ArchitectureTesting.Patterns.Singleton;
using ArchitectureTesting.Patterns.Stratergy;
using PatternPlay.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ArchitectureTesting
{
    public class Program
    {
        private WindscreenMoistureSensor _windscreenMoistureSensor;
        private WindscreenWiperMechanism _windscreenWiperMechanism;

        public WindscreenMoistureSensor MoistureSensor { set { _windscreenMoistureSensor = value; } }
        public WindscreenWiperMechanism WiperMechanism { set { _windscreenWiperMechanism = value; } }

        static void Main(string[] args)
        {

            //AbstractFactory();
            //BuilderPattern();
            //MediatorPattern();
            //StratergyPattern();
            //SingletonPattern();
        }

        private static void BuilderPattern()
        {
            var houseBuilder = new HouseBuilder(new House());
            Director.ConstructSimpleHouse(houseBuilder);

            Console.WriteLine(houseBuilder.GetResult().ToString());
            Director.SignOffConstruction(houseBuilder);

            Console.WriteLine("Building next house...");

            var homeOfficeBuilder = new HomeOfficeBuilder(new House());
            Director.ConstructSimpleHouseWithGarage(homeOfficeBuilder);
            Console.WriteLine(homeOfficeBuilder.GetResult().ToString());
            Director.SignOffConstruction(homeOfficeBuilder);
        }

        private static void MediatorPattern()
        {
            var mediator = new ConcreteMediator();

            var moistureSensor = new WindscreenMoistureSensor(mediator);
            var wiperMechanism = new WindscreenWiperMechanism(mediator);
            var l = new List<ComponentRelations>() { new ComponentRelations(moistureSensor, wiperMechanism, (BaseComponent cmp) => cmp.State.Length > 5), new ComponentRelations(wiperMechanism, moistureSensor, (BaseComponent cmp) => ((WindscreenWiperMechanism)cmp).MoistureLevel == 9) };

            mediator.ComponentNotificationRelationship = l.ToLookup(x => x.KeyComponent, x => x);

            moistureSensor.Send();
            wiperMechanism.Send();
        }

        private static void AbstractFactory()
        {
            new ShoeShop().SellShoes(new ConverseFactory(), 9);
            new ShoeShop().SellShoes(new NikeFactory(), 10);
        }

        private static void StratergyPattern()
        {
            new CementOrderCostingService().CalculateInvoices();
        }

        private static void SingletonPattern()
        {
            Thread thread1 = new Thread(() => 
            {
                CheckSingleton(10);
            });

            Thread thread2 = new Thread(() => 
            {
                CheckSingleton(20);
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            void CheckSingleton(int multiplier)
            {
                var s = Singleton.GetSingleton(multiplier);
                Console.WriteLine(s.Multiplier * s.Multiplier);
            }
        }

        private void DecoratorPattern()
        {
            var filePath = "D:/Temp/DecoratorOutput.txt";
            var name = "Clinton";
            Console.WriteLine($"Writing to {filePath} unencrypted, value is {name}");
            new FileWriter().Write(filePath, name);

            Console.WriteLine($"Writing to {filePath} encrypted, value is {name}");
            new FileWriterWithEncryption(filePath, name).Write();
        }
    }
}
