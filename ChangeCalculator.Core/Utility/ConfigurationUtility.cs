using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Utility {

    public sealed class ConfigurationUtility : IConfigurationUtility {

        public string FileLogPath {
            get { return ConfigurationManager.AppSettings["FileLogPath"]; }
        }

        public string FileLogName {
            get { return ConfigurationManager.AppSettings["FileLogName"]; }
        }

        public string LogFullPath { get { return Path.Combine(this.FileLogPath, this.FileLogName); } }

        public string DatabaseConnection {
            get { return ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString; }
        }

        public string LogTo {
            get { return ConfigurationManager.AppSettings["LogTo"]; }
        }
    }
}
