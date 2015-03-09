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

        public override string GetName() {
            return "Coin";
        }
    }
}
