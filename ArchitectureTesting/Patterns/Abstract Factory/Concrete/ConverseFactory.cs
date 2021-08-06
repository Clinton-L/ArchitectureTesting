using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class ConverseFactory : AbstractShoeFactory
    {
        public override AbstractLaces CreateLaces()
        {
            return new VelcroLaceProduct();
        }

        public override AbstractShoe CreateShoe(int size)
        {
            return new CasualShoeProduct(size) { Description = "All Star High Tops"};
        }
    }
}
