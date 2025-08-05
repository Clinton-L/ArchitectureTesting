namespace ArchitectureTesting.Patterns.Abstract_Factory.Abstract
{
    public abstract class AbstractShoe
    {
        public abstract bool TryOn(int size);
        public abstract int Size { get; set;  }
        public abstract AbstractLaces Laces { get; }
        public abstract LaceTypes RequiredLaces { get; }
        public string Description;
    }
}
