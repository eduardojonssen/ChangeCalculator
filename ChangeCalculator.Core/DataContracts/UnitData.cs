using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContracts {
    public class UnitData {

        public UnitData() { }

        public UnitData(long valueInCents, long count) {

            this.ValueInCents = valueInCents;
            this.Count = count;
        }

        public long ValueInCents { get; set; }

        public long Count { get; set; }
    }
}
