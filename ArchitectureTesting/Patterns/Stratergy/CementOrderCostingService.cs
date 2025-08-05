using System;

namespace ArchitectureTesting.Patterns.Stratergy
{
    public class CementOrderCostingService
    {
        public delegate double CementOrderCosting(CementOrder cementOrder, int hours);


        public void CalculateInvoices()
        {
            var order = new CementOrder(CementTypes.Winter, FinishTypes.Polished, 50);
            CementOrderCosting orderCosting = new DeliverByTruck().GetCost;

            Console.WriteLine("Processing...");
            Console.WriteLine($"Calculated cost: {orderCosting(order, 6).ToString()}");
        }
    }
}
