using ChangeCalculator.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {

    public class CoinProcessor : AbstractProcessor {

        public override IEnumerable<int> GetAvailableUnits() {
            return new List<int>() { 100, 50, 25, 10, 5, 1 };
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

        public override string GetName() {
            return "Coin";
        }
    }
}
