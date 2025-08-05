using System.Collections.Generic;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Abstract
{
    public abstract class AbstractShoeFactory
    {
        public abstract AbstractShoe CreateShoe(int size);
        public abstract AbstractLaces CreateLaces(LaceTypes laceType, string description);
    }
}
