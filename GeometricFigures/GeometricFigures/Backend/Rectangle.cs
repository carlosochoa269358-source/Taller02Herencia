namespace GeometricFigures.Backend
{
    public class Rectangle : GeometricFigure
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

        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
        }

        public override double Area => A * B;

        public override double Perimeter => 2 * (A + B);
    }
}
