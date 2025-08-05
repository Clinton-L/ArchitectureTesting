namespace ArchitectureTesting.Patterns.Abstract_Factory.Abstract
{
    public abstract class AbstractLaces
    {
        public abstract void AttachTo(AbstractShoe shoe);
        public abstract LaceTypes LaceType { get; }
        public abstract string Description { get; }
    }
}
