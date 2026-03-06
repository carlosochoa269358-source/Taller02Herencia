using System;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        public double C { get; set; }
        public double H { get; set; }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = ValidateC(a, b, c);
            H = ValidateH(h);
        }

        public double ValidateC(double a, double b, double c)
        {
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), "C debe ser > 0.");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Los lados no forman un triángulo válido.");
            return c;
        }

        public double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentOutOfRangeException(nameof(h), "H debe ser > 0.");
            return h;
        }

        public override double GetArea() => (B * H) / 2.0;
        public override double GetPerimeter() => Side + B + C;
    }
}
