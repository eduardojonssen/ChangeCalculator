using ChangeCalculator.Core.Repository.Entities;
using ChangeCalculator.Core.Utility;
using Dlp.Connectors;
using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Repository {

    public sealed class ServiceLogRepository {

        public ServiceLogRepository() { }

        public int Save(ServiceLogEntity entity) {

            string query = @"INSERT INTO ServiceLog (MethodName, LogData, LogCategoryTypeId)
                             VALUES (@MethodName, @LogData, @LogCategoryTypeId)";

            IConfigurationUtility configurationUtility = IocFactory.Resolve<IConfigurationUtility>();

            using (DatabaseConnector databaseConnector = new DatabaseConnector(configurationUtility.DatabaseConnection)) {

                return databaseConnector.ExecuteNonQuery(query, entity);
            }
        }
    }
}
