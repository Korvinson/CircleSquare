using System;

namespace CircleSquare.Core
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше нуля.");
            }
            this.radius = radius;

        }

        public override double CalculateSquare()
        {
            return Math.PI * (this.radius * this.radius);
        }
    }
}
