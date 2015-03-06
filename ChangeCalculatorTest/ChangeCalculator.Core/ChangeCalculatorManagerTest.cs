using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeCalculator.Core;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ChangeCalculatorTest.ChangeCalculator.Core {

    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ChangeCalculatorManagerTest {

        [TestMethod]
        public void CalculateCoins_ChangeFor210_Test() {

            ChangeCalculatorManager manager = new ChangeCalculatorManager();

            PrivateObject privateObject = new PrivateObject(manager);

            object objectResult = privateObject.Invoke("CalculateCoins", Convert.ToInt64(210));

            Dictionary<int, long> result = (Dictionary<int, long>)objectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);

            Assert.IsTrue(result.ContainsKey(100) == true);
            Assert.IsTrue(result.ContainsKey(10) == true);

            Assert.IsTrue(result[100] == 2);
            Assert.IsTrue(result[10] == 1);
        }

        [TestMethod]
        public void CalculateCoins_ChangeFor0_Test() {

            ChangeCalculatorManager manager = new ChangeCalculatorManager();

            PrivateObject privateObject = new PrivateObject(manager);

            object objectResult = privateObject.Invoke("CalculateCoins", Convert.ToInt64(0));

            Dictionary<int, long> result = (Dictionary<int, long>)objectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void CalculateCoins_ChangeForNegative1_Test() {

            ChangeCalculatorManager manager = new ChangeCalculatorManager();

            PrivateObject privateObject = new PrivateObject(manager);

            object objectResult = privateObject.Invoke("CalculateCoins", Convert.ToInt64(-1));

            Dictionary<int, long> result = (Dictionary<int, long>)objectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}
