using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest_PositivTal()
        {
            // Arrange
            CalculatorAdd calculator = new CalculatorAdd();
            double a = 10;
            double b = 4;
            double expected = 14;


            // Act
            double result = calculator.Add(a, b);


            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void AddTest_NegativTest()
        {
            // Arrange
            CalculatorAdd calculator = new CalculatorAdd();
            double a = -10;
            double b = -4;
            double expected = -14;


            // Act
            double result = calculator.Add(a, b);


            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void AddTest_NulTest()
        {
            // Arrange
            CalculatorAdd calculator = new CalculatorAdd();
            double a = 0;
            double b = 0;
            double expected = 0;


            // Act
            double result = calculator.Add(a, b);


            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}