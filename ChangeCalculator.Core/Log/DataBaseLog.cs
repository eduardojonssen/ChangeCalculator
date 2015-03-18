using ChangeCalculator.Core.Repository;
using ChangeCalculator.Core.Repository.Entities;
using ChangeCalculator.Core.Utility;
using Dlp.Connectors;
using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {

    public class DataBaseLog : AbstractLog {

        public DataBaseLog() {

        }

        public override void Write(LogType logType, string methodName, object objectToSerialize) {

            // Serializa
            string serializedRequest = Serializer.JsonSerialize(objectToSerialize);

            // Monta a linha de texto a ser escrita no log.
            string logData = string.Format("[{0}]: {1} | {2} | {3}{4}",
                DateTime.UtcNow, logType, methodName, serializedRequest, Environment.NewLine);

            ServiceLogRepository repository = new ServiceLogRepository();

            ServiceLogEntity entity = new ServiceLogEntity();

            entity.LogCategoryTypeId = (short)logType;
            entity.LogData = logData;
            entity.MethodName = methodName;

            repository.Save(entity);
        }
    }
}
