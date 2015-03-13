using ChangeCalculator.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlp.Framework.Container;

namespace ChangeCalculator.Core.Log {

    public abstract class AbstractLog : ILog {

        public IConfigurationUtility ConfigurationUtility { get; set; }

        public AbstractLog() {
            this.ConfigurationUtility = IocFactory.Resolve<IConfigurationUtility>();
        }

        public abstract void Write(LogType logType, string methodName, object objectToSerialize);
    }
}
