using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaTest_12_expected_452()
        {
            double r = 12;
            double expected = 452.39;
            Circle circle = new Circle(r);

            // Act
            double area = circle.GetСircleArea();

            // assert
            Assert.AreEqual(expected, area, "Площадь расчитывается неправильно");
        }

        [TestMethod]
        public void AreaTest_minus_expected_numberPI()
        {
            double r = -1;
            double expected = 0;
            Circle circle = new Circle(r);

            // Act
            double area = circle.GetСircleArea();

            // assert
            Assert.AreEqual(expected, area, "Площадь расчитывается неправильно");
        }

        [TestMethod]
        public void CircleTest_minus_expected_numberPI()
        {
            double r = -1;
            double expected = 0;
            Circle circle = new Circle(r);

            // Act
            double area = circle.GetСircle();

            // assert
            Assert.AreEqual(expected, area, "Диаметр окружности расчитан неверно");
        }


        [TestMethod]
        public void CircleTest_12_expected_75()
        {
            double r = 12;
            double expected = 75.4;
            Circle circle = new Circle(r);

            // Act
            double area = circle.GetСircle();

            // assert
            Assert.AreEqual(expected, area, "Диаметр окружности расчитан неверно");
        }
    }
}
