using Geometry.Exceptions;

namespace Geometry.GeometryFoundation
{
    public class Line
    {
        private double _longitude;

        public double Longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                if (value <= 0) 
                    throw new GeometryException("Не удалось задать значение линии, значение длинны должно быть больше нуля");

                double maxRadius = Math.Sqrt(Double.MaxValue);

                if (value >= maxRadius) 
                    throw new GeometryException($"Не удалось задать значение линии, значение не может превышать ${maxRadius}.");

                _longitude = value;
            }
        }

        public Line(double longitude)
        {
            Longitude = longitude;
        }

        public Line()
        {
            Longitude = 0;
        }

        // Перегрузки оператора

        public static Line operator +(Line line1, Line line2)
        {
            return new Line(line1.Longitude + line2.Longitude);
        }

        public static double operator -(Line line, double val)
        {
            return line.Longitude - val;
        }

        public static double operator -(double val, Line line)
        {
            return val - line.Longitude;
        }

        // Перегрузки преобразования типов

        public static implicit operator double(Line line)
        {
            return line.Longitude;
        }

        public static implicit operator Line(double val)
        {
            return new Line(val);
        }

    }
}
