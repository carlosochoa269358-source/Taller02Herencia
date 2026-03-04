namespace GeometricFigures.Backend
{
    public class Parallelogram : GeometricFigure
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
        public double H 
        { 
            get; 
            set; 
        }

        public Parallelogram(string name, double a, double b, double h) : base(name)
        {
            A = a;
            B = b;
            H = h;
        }

        public override double Area => B * H;

        public override double Perimeter => 2 * (A + B);
    }
}