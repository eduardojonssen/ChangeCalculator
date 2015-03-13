using ChangeCalculator.Core.Utility;
using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public class EventViewerLog : AbstractLog {

        public EventViewerLog() {

        }

        public override void Write(LogType logType, string methodName, object objectToSerialize) {

            string cs = "ChangeCalculator";
            
            if (EventLog.SourceExists(cs) == false)
                EventLog.CreateEventSource(cs, "Application");

            // Serializa
            string serializedRequest = Serializer.JsonSerialize(objectToSerialize);

            // Monta a linha de texto a ser escrita no log.
            string logData = string.Format("[{0}]: {1} | {2} | {3}{4}",
                DateTime.UtcNow, logType, methodName, serializedRequest, Environment.NewLine);

            EventLog.WriteEntry(cs, logData, EventLogEntryType.Information);
        }
    }
}
