using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class VelcroLaceProduct(string description) : AbstractLaces
    {
        public bool Strapped { get; set; }

        public override LaceTypes LaceType => LaceTypes.Velcro;

        public override string Description => description;

        public override void AttachTo(AbstractShoe shoe)
        {
            if (shoe.RequiredLaces is LaceTypes.Velcro)
                Console.WriteLine($"Attaching {GetType().Name} to {shoe.GetType().Name}");
            else
                throw new Exception($"The Velcro lace product is not compatible with your shoe {shoe.Description}");
        }
    }
}
