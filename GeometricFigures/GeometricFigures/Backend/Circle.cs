namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        public double Radius
        { 
            get; 
            set; 
        }

        public Circle(string name, double r) : base(name)
        {
            Radius = r;
        }

        public override double Area => Math.PI * Radius * Radius;

        public override double Perimeter => 2 * Math.PI * Radius;
    }
}
