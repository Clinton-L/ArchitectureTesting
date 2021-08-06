using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class CasualShoeProduct : AbstractShoe
    {
        public CasualShoeProduct(int size)
        {
            Size = size;
        }

        public override int Size { get; }

        public override bool TryOn(int size)
        {
            return Size == size;
        }
    }
}
