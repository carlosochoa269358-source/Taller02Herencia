namespace GeometricFigures.Backend
{
    public class Triangle : GeometricFigure
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
        public double H 
        { 
            get; 
            set;
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            A = a;
            B = b;
            C = c;
            H = h;
        }

        public override double Area => (B * H) / 2;

        public override double Perimeter => A + B + C;
    }
}
