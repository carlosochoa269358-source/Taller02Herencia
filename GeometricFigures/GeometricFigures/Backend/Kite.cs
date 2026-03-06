using System;

namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        public double B { get; set; }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = ValidateB(b);
        }

        public double ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), "B debe ser > 0.");
            return b;
        }

        public override double GetArea() => (D1 * D2) / 2.0; // misma que rombo (diagonales)
        public override double GetPerimeter() => 2 * (Side + B);
    }
}