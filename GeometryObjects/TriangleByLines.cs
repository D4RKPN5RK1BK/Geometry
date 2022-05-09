using Geometry.Exceptions;
using Geometry.GeometryFoundation;
using Geometry.GeometryTypes;

namespace Geometry.GeometryObjects
{
    public class TriangleByLines : IFillable, ITriangle
    {
        private Line ab;
        private Line bc;
        private Line ca;

        public TriangleByLines(double ab, double bc, double ca)
        {
            this.ab = new Line(ab);
            this.bc = new Line(bc);
            this.ca = new Line(ca);

            if (ab >= bc + ca || bc >= ca + ab || ca >= ab + bc)
                throw new GeometryException("Треугольник не может быть инициализирован, так как одна из его сторон больше либо равна сумме двух других");

        }

        public double GetSquare()
        {
            double p = (ab + bc + ca).Longitude / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }

        public bool IsStright()
        {
            double cathetus1 = Math.Min(Math.Max(ab, bc), ca);
            double cathetus2 = Math.Min(Math.Min(ab, bc), ca);

            return GetSquare() == (cathetus1 * cathetus2) / 2;
        }
    }   
}
