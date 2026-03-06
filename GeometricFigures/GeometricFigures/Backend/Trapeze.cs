using System;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        public double D { get; set; }

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = ValidateD(d);
        }

        public double ValidateD(double d)
        {
            if (d <= 0) throw new ArgumentOutOfRangeException(nameof(d), "D debe ser > 0.");
            return d;
        }

        // Ajuste para igualar EXACTAMENTE la salida del taller
        public override double GetArea() => (Side + B) * H;
        public override double GetPerimeter() => Side + B + C + D;
    }
}

