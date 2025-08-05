using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class LaceProduct(string description) : AbstractLaces
    {
        public override LaceTypes LaceType => LaceTypes.Standard;

        public override string Description => description;

        public override void AttachTo(AbstractShoe shoe)
        {
            Console.WriteLine($"Attaching {GetType().Name} to {shoe.GetType().Name}");
        }
    }
}
