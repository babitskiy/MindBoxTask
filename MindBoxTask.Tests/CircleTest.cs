using MindBoxTask.Figures;
using MindBoxTask.Interfaces;

namespace MindBoxTask.Tests
{
    /// <summary>
    /// ����� ��� �����
    /// </summary>
    internal class CircleTest
    {
        /// <summary>
        /// ����������: ������ ����� ������ ���� ������ ����
        /// </summary>
        [Test]
        public void CicrleTest_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0).CalculateArea());
            Assert.Throws<ArgumentException>(() => new Circle(-2).CalculateArea());
        }

        /// <summary>
        /// �����: ���������� ���������� ������� �����
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