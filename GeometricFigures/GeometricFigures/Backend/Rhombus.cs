using System;

namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        public double D1 { get; set; }
        public double D2 { get; set; }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = ValidateD1(d1);
            D2 = ValidateD2(d2);
        }

        public double ValidateD1(double d1)
        {
            if (d1 <= 0) throw new ArgumentOutOfRangeException(nameof(d1), "D1 debe ser > 0.");
            return d1;
        }

        public double ValidateD2(double d2)
        {
            if (d2 <= 0) throw new ArgumentOutOfRangeException(nameof(d2), "D2 debe ser > 0.");
            return d2;
        }

        public override double GetArea() => (D1 * D2) / 2.0;
        public override double GetPerimeter() => 4 * Side;
    }
}