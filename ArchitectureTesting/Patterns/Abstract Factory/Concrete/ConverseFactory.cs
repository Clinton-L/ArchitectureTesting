using ArchitectureTesting.Patterns.Abstract_Factory.Abstract;

namespace ArchitectureTesting.Patterns.Abstract_Factory.Concrete
{
    public class ConverseFactory : AbstractShoeFactory
    {
        public override AbstractLaces CreateLaces(LaceTypes laceType, string description) => laceType switch
        {
            LaceTypes.Velcro => new VelcroLaceProduct(description),
            _ => new LaceProduct(description),
        };

        public override AbstractShoe CreateShoe(int size)
        {
            return new CasualShoeProduct(size) { Description = "All Star High Tops"};
        }
    }
}
