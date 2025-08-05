namespace ArchitectureTesting.Patterns.Stratergy
{
    public interface IDeliveryMethod
    {
        double GetCost(CementOrder cementOrder, int hours);
        RateMethods GetRate();
    }
}
