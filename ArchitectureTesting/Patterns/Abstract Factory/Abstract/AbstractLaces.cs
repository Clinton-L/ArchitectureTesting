using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Abstract
{
    public abstract class AbstractLaces
    {
        public abstract void AttachTo(AbstractShoe shoe);
        public abstract void Tie();
    }
}
