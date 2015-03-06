using ChangeCalculator.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public class BillProcessor : AbstractProcessor{
        public override IEnumerable<int> GetAvailableUnits() {
            return new List<int>() {200, 500, 1000, 2000, 5000, 10000};
        }

        public override string GetName() {
            return "Bill";
        }

        public override List<UnitData> Calculate(long changeAmount) {
            List<UnitData> unitCollection = new List<UnitData>();

            if (changeAmount <= 0) { return unitCollection; }

            IEnumerable<int> orderedUnits = this.GetAvailableUnits().OrderByDescending(p => p);

            foreach (int unit in orderedUnits) {

                long unitCount = changeAmount / unit;
                long remainingChangeAmount = changeAmount % unit;

                if (unitCount != 0) { unitCollection.Add(new UnitData(unit, unitCount)); }

                changeAmount = remainingChangeAmount;

                if (remainingChangeAmount == 0) { break; }
            }

            return unitCollection;
        }
    }
}
