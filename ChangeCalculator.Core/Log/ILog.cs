using ChangeCalculator.Core.Interceptors;
using ChangeCalculator.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {

    public interface ILog {

        IConfigurationUtility ConfigurationUtility { get; set; }

        [LogI]
        void Write(LogType logType, string methodName, object objectToSerialize);
    }
}
