using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Abstract
{
    public abstract class AbstractShoe
    {
        public abstract bool TryOn(int size);
        public abstract int Size { get; }
        //public abstract AbstractLaces Laces { get; }
        public string Description;
    }
}
