using MindBoxTask.Figures;
using MindBoxTask.Interfaces;

namespace MindBoxTask.Tests
{
    /// <summary>
    /// Тесты для круга
    /// </summary>
    internal class CircleTest
    {
        /// <summary>
        /// Исключение: радиус круга должен быть больше нуля
        /// </summary>
        [Test]
        public void CicrleTest_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0).CalculateArea());
            Assert.Throws<ArgumentException>(() => new Circle(-2).CalculateArea());
        }

        /// <summary>
        /// Успех: возвращена корректная площадь круга
        /// </summary>
        [Test]
        public void CicrleTest_Success()
        {
            var radius = 4.0;

            IFigure circle = new Circle(radius);

            var result = Math.Round(circle.CalculateArea(), 2);

            Assert.AreEqual(result, 50.27);
        }
    }
}