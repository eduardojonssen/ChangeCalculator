using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContracts {

    public sealed class Report {

        public Report() { }

        public string Message { get; set; }

        public string Field { get; set; }

        public ReportType ReportType { get; set; }
    }
}
