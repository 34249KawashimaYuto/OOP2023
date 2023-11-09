using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class PoundUnit : DistanceUnit {
        private static List<PoundUnit> units = new List<PoundUnit>{
            new PoundUnit{Name = "st",Coefficient = 1,},    //ストーン
            new PoundUnit{Name = "lb",Coefficient = 14,},   //ポンド
            new PoundUnit{Name = "oz",Coefficient = 14 * 16,}, //オンス
        };
        public static ICollection<PoundUnit> Units { get { return units; } }

        public double FromGramUnit(GramUnit unit, double value) {
            return (value * this.Coefficient) / 6350.29317 * unit.Coefficient;
        }
    }
}
