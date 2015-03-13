using System;

namespace ChangeCalculator.Core.Utility {

    public interface IConfigurationUtility {
        string DatabaseConnection { get; }
        string FileLogName { get; }
        string FileLogPath { get; }
        string LogFullPath { get; }
        string LogTo { get; }
    }
}
