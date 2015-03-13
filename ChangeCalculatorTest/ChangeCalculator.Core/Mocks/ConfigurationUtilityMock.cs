using ChangeCalculator.Core.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorTest.ChangeCalculator.Core.Mocks {

    public sealed class ConfigurationUtilityMock : IConfigurationUtility {

        public string DatabaseConnection {
            get { return @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ChangeCalculator;Data Source=Treinamento\SQLEXPRESS"; }
        }

        //public string FileLogName {
        //    get { return "LogTest.log"; }
        //}

        //public string FileLogPath {
        //    get { return @"C:\Logs\Test"; }
        //}

        public string LogFullPath {
            get { return Path.Combine(this.FileLogPath, this.FileLogName); }
        }

        public string FileLogName { get; set; }

        public string FileLogPath { get; set; }

    }
}
