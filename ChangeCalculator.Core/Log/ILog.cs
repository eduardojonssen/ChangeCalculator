using ChangeCalculator.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {

    public interface ILog {

        [LogI]
        void Write(LogType logType, string methodName, object objectToSerialize);
    }
}
