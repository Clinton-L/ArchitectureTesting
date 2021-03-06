using ArchitectureTesting.Patterns.Abstract_Factory.Concrete;
using ArchitectureTesting.Patterns.Builder;
using ArchitectureTesting.Patterns.Mediator;
using PatternPlay.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
