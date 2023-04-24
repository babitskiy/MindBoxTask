using MindBoxTask.Interfaces;

namespace MindBoxTask.Figures
{
    public class Circle : IFigure
    {
        //радиус круга
        double radius;

        //конструктор класса
        public Circle(double radius)
        {
            if (radius <= 0.0)
            {
                throw new ArgumentException("Радиус круга должен быть большое нуля");
            }
            this.radius = radius;
        }

        //метод нахождения площади круга
        public double CalculateArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}