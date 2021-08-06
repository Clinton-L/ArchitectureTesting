using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class ShoeShop
    {
        public (Abstract.AbstractShoe, Abstract.AbstractLaces) CreateShoe(Abstract.AbstractShoeFactory shoeFactory)
        {
            var shoe = shoeFactory.CreateShoe(9);
            var laces = shoeFactory.CreateLaces();

            laces.AttachTo(shoe);
            laces.Tie();

            return (shoe, laces);
        }

        public void SellShoes(Abstract.AbstractShoeFactory factory, int customerSize)
        {
            var(shoe, laces) = CreateShoe(factory);

            if(shoe.TryOn(customerSize))
            {
                Console.WriteLine($"{shoe.Description} of size {customerSize} fits, lace style {laces.GetType().Name}");
            }
            else
            {
                Console.WriteLine($"{shoe.Description} of size {customerSize} does not fit");
            }
        }
    }
}
