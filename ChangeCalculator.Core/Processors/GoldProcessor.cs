using ChangeCalculator.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public class GoldProcessor : AbstractProcessor{
        public override IEnumerable<int> GetAvailableUnits() {
            return new List<int>() {50000, 100000};
        }

        public override string GetName() {
            return "Gold";
        }
    }
}
