using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Abstract
{
    public abstract class AbstractShoeFactory
    {
        public abstract AbstractShoe CreateShoe(int size);
        public abstract AbstractLaces CreateLaces();
    }
}
