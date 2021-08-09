using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleSquare.Core
{
    public class Triangle : Figure
    {

        private double first;
        private double second;
        private double third;
        public Triangle(double first, double second, double third)
        {
            if (first < 0 || second < 0 || third < 0)
            {
                throw new ArgumentException("Ни одна из сторон не может быть меньше нуля.");
            }

            else if (first + second <= third)
            {
                throw new ArgumentException("Сумма двух катетов не может быть меньше гипотенузы");
            }

            else if (first + third <= second)
            {
                throw new ArgumentException("Сумма двух катетов не может быть меньше гипотенузы");
            }

            else if (third + second <= first)
            {
                throw new ArgumentException("Сумма двух катетов не может быть меньше гипотенузы");
            }

            this.first = first;
            this.second = second;
            this.third = third;
        }

        

        public override double CalculateSquare()
        {
            var semiPerimeter = (first + second + third) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - first) * (semiPerimeter - second) * (semiPerimeter - third));
        }
    }
}
