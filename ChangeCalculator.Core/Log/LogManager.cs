using ChangeCalculator.Core.Interceptors;
using ChangeCalculator.Core.Utility;
using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public class LogManager {

        public LogManager() {
            IocFactory.Register(
                Component.FromThisAssembly(@"ChangeCalculator.Core.Log")
                );
        }

        public void Write(LogType logType, string methodName, object objectToSerialize) {

            Task.Run(() => {

                try {
                    string logCategory = IocFactory.Resolve<IConfigurationUtility>().PrimaryLog;
                    ILog logger = IocFactory.ResolveByName<ILog>(logCategory);

                    logger.Write(logType, methodName, objectToSerialize);
                }
                catch (SqlException ex) {

                    string logCategory = IocFactory.Resolve<IConfigurationUtility>().SecondaryLog;
                    ILog logger = IocFactory.ResolveByName<ILog>(logCategory);

                    logger.Write(logType, methodName, objectToSerialize);
                    logger.Write(LogType.Exception, "Write", ex.ToString());
                }
            });
        }
    }
}
