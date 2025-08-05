namespace ArchitectureTesting.Patterns.Abstract_Factory
{
    public enum LaceTypes
    {
        Standard,
        Velcro,
        Zip,
        QuickFit = Standard | Zip,
        All = QuickFit | Velcro,
    }
}
