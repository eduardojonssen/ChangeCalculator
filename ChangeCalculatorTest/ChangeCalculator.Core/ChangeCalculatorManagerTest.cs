using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeCalculator.Core;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ChangeCalculator.Core.Log;
using ChangeCalculator.Core.DataContracts;
using ChangeCalculator.Core.Utility;
using ChangeCalculatorTest.ChangeCalculator.Core.Mocks;
using Dlp.Framework.Container;

namespace ChangeCalculatorTest.ChangeCalculator.Core {

    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ChangeCalculatorManagerTest {
        
        [TestMethod]
        public void ChangeCalculatorManager_LogToFile_Test() {

            ConfigurationUtilityMock utility = new ConfigurationUtilityMock();

            utility.FileLogName = "LogTest.log";
            utility.FileLogPath = @"C:\Logs\Test";

            IocFactory.Register(
                    Component.For<IConfigurationUtility>().Instance(utility),
                    Component.For<ILog>().ImplementedBy<FileLog>()
                );

            ChangeCalculatorManager manager = new ChangeCalculatorManager();

            CalculateRequest request = new CalculateRequest();

            request.PaidAmount = 350;
            request.ProductAmount = 150;

            manager.Calculate(request);
        }
    }
}
