using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;
using System;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class ShoeShop
    {
        public (Abstract.AbstractShoe, Abstract.AbstractLaces) CreateShoe(Abstract.AbstractShoeFactory shoeFactory, (LaceTypes laceType, string description) prefferedLaces)
        {
            var shoe = shoeFactory.CreateShoe(9);
            var laces = shoeFactory.CreateLaces(prefferedLaces.laceType, prefferedLaces.description);

            laces.AttachTo(shoe);

            return (shoe, laces);
        }

        public void SellShoes(AbstractShoeFactory factory, int customerSize)
        {
            var(shoe, laces) = CreateShoe(factory, (LaceTypes.Velcro, "Blakc strap with brand logo on end"));

            if(shoe.TryOn(customerSize))
            {
                Console.WriteLine($"{shoe.Description} of size {customerSize} fits, lace style {laces.GetType().Name} {laces.Description}");
            }
            else
            {
                Console.WriteLine($"{shoe.Description} of size {customerSize} does not fit");
            }
        }
    }
}
