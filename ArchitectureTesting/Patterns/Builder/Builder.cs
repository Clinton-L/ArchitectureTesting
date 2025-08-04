using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Builder
{
    public abstract class Builder
    {
        public abstract Builder BuildWalls(int[] dimensions);
        public abstract Builder BuildRoof();
        public abstract Builder BuildGarage();
        public abstract Builder BuildPool();
        public abstract Builder BuildFence();
        public abstract Builder BuildDoor();
        public abstract Builder BuildWindow();
        public abstract House GetResult();
        public abstract Builder BuildComplete();
    }
}
