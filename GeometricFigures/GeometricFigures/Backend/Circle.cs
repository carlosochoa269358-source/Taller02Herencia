using System;

namespace GeometricFigures.Backend
{
    // UML: Circle hereda de GeometricFigure
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }

        public Circle(string name, double r) : base(name)
        {
            Radius = ValidateR(r);
        }

        public double ValidateR(double r)
        {
            if (r <= 0) throw new ArgumentOutOfRangeException(nameof(r), "El radio debe ser > 0.");
            return r;
        }

        public override double Area => Math.PI * Radius * Radius;
        public override double Perimeter => 2 * Math.PI * Radius;
    }
}