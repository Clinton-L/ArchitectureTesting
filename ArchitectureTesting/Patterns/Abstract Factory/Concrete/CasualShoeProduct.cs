using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class CasualShoeProduct(int size) : AbstractShoe
    {
        public override int Size { get; set; } = size;

        public override AbstractLaces Laces => new LaceProduct("standard lace");

        public override LaceTypes RequiredLaces => LaceTypes.Standard;

        public override bool TryOn(int size)
        {
            return Size == size;
        }
    }
}
