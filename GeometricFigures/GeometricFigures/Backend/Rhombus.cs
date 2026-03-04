namespace GeometricFigures.Backend
{
    public class Rhombus : GeometricFigure
    {
        public double Side
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

        public Rhombus(string name, double a, double d1, double d2) : base(name)
        {
            Side = a;
            D1 = d1;
            D2 = d2;
        }

        public override double Area => (D1 * D2) / 2;

        public override double Perimeter => 4 * Side;
    }
}

