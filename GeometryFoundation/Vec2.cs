namespace Geometry.Vectors
{
    internal class Vec2
    {
        public double X;
        public double Y;

        public Vec2()
        {
            X = 0; 
            Y = 0;
        }

        public Vec2(double x, double y)
        {
            X = x;
            Y = y;
        } 

        public double Magnitude
        {
            get => Math.Pow(X, 2) + Math.Pow(Y, 2); 
        }
    }
}
