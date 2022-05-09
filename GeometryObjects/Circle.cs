using Geometry.GeometryFoundation;
using Geometry.GeometryTypes;

namespace Geometry.GeometryObjects
{
    public class Circle : IFillable
    {
        private Line r;
        public Circle(double radius)
        {
            r = radius;
        }
        
        public double GetSquare()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
    }
}
