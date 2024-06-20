using GeometryLib.BaseClasses;

namespace GeometryLib.Models
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero.");

            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
