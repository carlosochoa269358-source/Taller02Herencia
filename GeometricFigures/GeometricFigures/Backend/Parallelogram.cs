using System;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        public double H { get; set; }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = ValidateH(h);
        }

        public double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentOutOfRangeException(nameof(h), "H debe ser > 0.");
            return h;
        }

        public override double GetArea() => B * H;                 // Clave para igualar salida
        public override double GetPerimeter() => 2 * (Side + B);
    }
}