using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class LaceProduct : AbstractLaces
    {
        public bool Tied { get; set; }

        public override void AttachTo(AbstractShoe shoe)
        {
            Console.WriteLine($"Attaching {GetType().Name} to {shoe.GetType().Name}");
        }

        public override void Tie() => Tied = true;
    }
}
