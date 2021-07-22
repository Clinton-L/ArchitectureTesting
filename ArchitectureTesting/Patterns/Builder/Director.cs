namespace ArchitectureTesting.Patterns.Builder
{
    public class Director
    {
        public static Builder ConstructSimpleHouse(Builder builder) =>
            builder.BuildComplete()
                .BuildWalls(new int[] { 4, 6 })
                .BuildRoof()
                .BuildWindow()
                .BuildWindow()
                .BuildDoor();
        
        public static Builder ConstructSimpleHouseWithGarage(Builder builder) => 
            builder.BuildComplete()
                .BuildWalls(new int[] { 4, 6 })
                .BuildRoof()
                .BuildWindow()
                .BuildWindow()
                .BuildDoor()
                .BuildGarage();

        public static Builder SignOffConstruction(Builder builder) => builder.BuildComplete();
    }
}