using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTesting.Patterns.Builder
{
    public class House
    {
        public List<string> Parts { get; set; } = new List<string>();

        public override string ToString()
        {
            string partsList = "";

            foreach (var part in Parts)
            {
                partsList = string.Concat(partsList, Environment.NewLine, part);
            }

            return partsList;
        }
    }
}
