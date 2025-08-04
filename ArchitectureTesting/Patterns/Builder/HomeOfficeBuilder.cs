using System;
using System.Linq;

namespace ArchitectureTesting.Patterns.Builder
{
    public class HomeOfficeBuilder(House House) : Builder
    {
        public override Builder BuildFence()
        {
            House.Parts.Add("Fence");
            return this;
        }

        public override Builder BuildGarage()
        {
            House.Parts.Add("Garage with a small office inside");
            return this;
        }

        public override Builder BuildPool()
        {
            House.Parts.Add("Pool");
            return this;
        }

        public override Builder BuildRoof()
        {
            House.Parts.Add("Roof");
            return this;
        }

        public override Builder BuildWalls(int[] dimensions)
        {
            foreach (var dimension in dimensions)
            {
                House.Parts.Add($"Wall at {dimension}m");
            }
            return this;
        }

        public override House GetResult()
        {
            if (House.Parts.Count() > 0)
                return House;
            else
                throw new Exception("No parts built");
        }

        public override Builder BuildComplete()
        {
            House = new House();
            return this;
        }

        public override Builder BuildDoor()
        {
            House.Parts.Add("Door");
            return this;
        }

        public override Builder BuildWindow()
        {
            House.Parts.Add("Window");
            return this;
        }
    }
}
