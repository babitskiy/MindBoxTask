using MindBoxTask.Interfaces;

namespace MindBoxTask.Figures
{
    public class Triangle : IFigure
    {
        double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            //проверяем что все стороны треугольника больше нуля
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть больше 0");
            }
            //сумма двух сторон треугольника должна быть больше третьей стороны
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше третьей стороны");
            }
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        //метод вычисления площади треугольника
        public double CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }

        //метод вычисления периметра треугольника
        private double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        //метод проверки является ли треугольник прямоугольным
        public bool IsRightTriangle()
        {
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
                Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
                Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
