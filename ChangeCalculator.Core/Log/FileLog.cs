using ChangeCalculator.Core.Utility;
using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {

    public class FileLog : AbstractLog {

        public FileLog(){

        }

        public override void Write(LogType logType, string methodName, object objectToSerialize) {

            if (Directory.Exists(this.ConfigurationUtility.FileLogPath) == false) {
                Directory.CreateDirectory(this.ConfigurationUtility.FileLogPath);
            }
            if (File.Exists(this.ConfigurationUtility.LogFullPath) == false) {
                File.Create(this.ConfigurationUtility.LogFullPath).Close();
            }

            // Serializa o objeto recebido.
            string serializedRequest = Serializer.JsonSerialize(objectToSerialize);

            // Monta a linha de texto a ser escrita no log.
            string logData = string.Format("[{0}]: {1} | {2} | {3}{4}",
                DateTime.UtcNow, logType, methodName, serializedRequest, Environment.NewLine);

            // Salva a linha no arquivo de log.
            File.AppendAllText(this.ConfigurationUtility.LogFullPath, logData);
        }
    }
}
