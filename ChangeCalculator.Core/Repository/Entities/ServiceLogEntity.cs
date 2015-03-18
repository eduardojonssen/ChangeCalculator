using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Repository.Entities {
    public sealed class ServiceLogEntity {

        public ServiceLogEntity() { }

        public int ServiceLogId { get; set; }

        public Nullable<DateTime> CreateDate { get; set; }

        public string MethodName { get; set; }

        public short LogCategoryTypeId { get; set; }

        public string LogData { get; set; }
    }
}
