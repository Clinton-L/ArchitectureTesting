using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class NikeFactory : AbstractShoeFactory
    {
        public override AbstractLaces CreateLaces(LaceTypes laceType, string description)
        {
            return new LaceProduct(description);
        }

        public override AbstractShoe CreateShoe(int size)
        {
            return new SportShoeProduct(size) { Description = "Nike Air Jordan Toon Squad"};
        }
    }
}
