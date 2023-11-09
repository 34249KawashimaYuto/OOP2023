using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class GramUnit : DistanceUnit {
        private static List<GramUnit> units = new List<GramUnit>{
            new GramUnit{Name = "g",Coefficient = 1,},
            new GramUnit{Name = "kg",Coefficient = 1000,},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        public double FromPoundUnit(PoundUnit unit, double value) {
            return (value / this.Coefficient) * 6350.29317 / unit.Coefficient;
        }

    }
}
