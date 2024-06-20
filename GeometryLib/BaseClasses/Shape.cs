using GeometryLib.Interfaces;

namespace GeometryLib.BaseClasses
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
    }
}
