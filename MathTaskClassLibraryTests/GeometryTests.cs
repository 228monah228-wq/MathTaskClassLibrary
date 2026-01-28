using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        // Тест площади прямоугольника
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // Исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            // Получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        // Тест объёма цилиндра
        [TestMethod]
        public void CylinderVolume_3and5_141_37returned()
        {
            // Исходные данные
            double radius = 3;
            double height = 5;
            double expected = Math.PI * Math.Pow(radius, 2) * height;

            // Получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CylinderVolume(radius, height);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual, 0.01); // Точность до 0.01
        }

        // Тест площади многоугольника
        [TestMethod]
        public void PolygonArea_3and4_12returned()
        {
            // Исходные данные
            int[] sides = new int[] { 3, 4 };
            double expected = 12;

            // Получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.PolygonArea(sides);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
