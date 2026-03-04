namespace GeometricFigures.Backend
{
    public class Kite : GeometricFigure
    {
        public double A {
            get; 
            set; 
        }
        public double B 
        { 
            get; 
            set; 
        }
        public double D1 
        { 
            get; 
            set; 
        }
        public double D2 
        { 
            get;
            set; 
        }

        public Kite(string name, double a, double b, double d1, double d2) : base(name)
        {
            A = a;
            B = b;
            D1 = d1;
            D2 = d2;
        }

        public override double Area => (D1 * D2) / 2;

        public override double Perimeter => 2 * (A + B);
    }
}