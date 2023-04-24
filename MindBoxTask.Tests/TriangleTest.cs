using MindBoxTask.Figures;

namespace MindBoxTask.Tests
{
    /// <summary>
    /// Тесты для треугольника
    /// </summary>
    internal class TriangleTest
    {
        /// <summary>
        /// Исключение: Стороны треугольника должны быть больше нуля
        /// </summary>
        [Test]
        public void TriangleTest_SideLessThanZero_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 3, -1).CalculateArea());
        }

        /// <summary>
        /// Исключение: Сумма двух сторон должна быть больше третей стороны
        /// </summary>
        [Test]
        public void TriangleTest_WrongTrinagle_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 2, 2).CalculateArea());
        }

        /// <summary>
        /// Успех: Возвращена корректная площадь треугольника
        /// </summary>
        [Test]
        public void TriangleTest_Success()
        {
            var trinagle = new Triangle(4, 5, 6);
            var triangleArea = Math.Round(trinagle.CalculateArea(), 2);
            Assert.IsTrue(triangleArea == 9.92);
        }

        /// <summary>
        /// Треугольник прямоугольный
        /// </summary>
        [Test]
        public void IsRightTriangle_True()
        {
            var trinagle = new Triangle(3.0, 4.0, 5.0);

            var result = trinagle.IsRightTriangle();

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Треугольник не прямоугольный
        /// </summary>
        [Test]
        public void IsRightTriangle_False()
        {
            var trinagle = new Triangle(2.0, 3.0, 4.0);

            var result = trinagle.IsRightTriangle();

            Assert.IsFalse(result);
        }
    }
}
