using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class NikeFactory : AbstractShoeFactory
    {
        public override AbstractLaces CreateLaces()
        {
            return new LaceProduct();
        }

        public override AbstractShoe CreateShoe(int size)
        {
            return new SportShoeProduct(size) { Description = "Nike Air Jordan Toon Squad"};
        }
    }
}
