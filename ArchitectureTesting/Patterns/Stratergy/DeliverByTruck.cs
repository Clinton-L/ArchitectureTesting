using System.Linq;

namespace ArchitectureTesting.Patterns.Stratergy
{
    public class DeliverByTruck : IDeliveryMethod
    {
        private double PerHourCost = 40;
        public double GetCost(CementOrder cementOrder, int hours) => (hours * PerHourCost) + cementOrder.DistanceFee + cementOrder.CallOutFee + ((double)cementOrder.FinishType) + ((double)cementOrder.CementType);

        public RateMethods GetRate() => RateMethods.PerHour;
    }
}
