namespace ArchitectureTesting.Patterns.Stratergy
{
    public record CementOrder(CementTypes CementType, FinishTypes FinishType, int TravelDistance)
    {
        public const int MAX_DISTANCE_BEFORE_FEES = 20;
        public const int MINIMUM_CALL_OUT_FEE = 100;

        public int DistanceFee = TravelDistance > MAX_DISTANCE_BEFORE_FEES ? 10 * (TravelDistance - MAX_DISTANCE_BEFORE_FEES) : 0;
        public int CallOutFee = TravelDistance <= MAX_DISTANCE_BEFORE_FEES ? 100 : 0;
    }
}
