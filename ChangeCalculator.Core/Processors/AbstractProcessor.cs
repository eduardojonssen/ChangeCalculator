using ChangeCalculator.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {

    public abstract class AbstractProcessor {

        public abstract IEnumerable<int> GetAvailableUnits();

        public abstract string GetName();

        public abstract List<UnitData> Calculate(long changeAmount);
    }
}
