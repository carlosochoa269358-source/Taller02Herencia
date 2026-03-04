namespace GeometricFigures.Backend
{
    public class Trapeze : GeometricFigure
    {
        public double A 
        { 
            get; 
            set; 
        }
        public double B 
        { 
            get; 
            set; 
        }
        public double C 
        { 
            get; 
            set; 
        }
        public double D 
        { 
            get; 
            set; 
        }
        public double H 
        { 
            get; 
            set; 
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
        }

        public override double Area => (C * D) / 2;

        public override double Perimeter => A + B + C + D;
    }
}
