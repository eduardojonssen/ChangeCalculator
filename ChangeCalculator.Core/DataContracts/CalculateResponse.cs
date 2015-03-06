using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContracts {

    public sealed class CalculateResponse {

        public CalculateResponse() {

            this.UnitCollection = new Dictionary<string, List<UnitData>>();
            this.ReportCollection = new List<Report>();
        }

        public Nullable<long> Change { get; set; }

        public Dictionary<string, List<UnitData>> UnitCollection { get; set; }

        public List<Report> ReportCollection { get; set; }
    }
}
