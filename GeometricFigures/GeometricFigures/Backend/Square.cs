namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        public double Side 
        { 
            get; 
            set; 
        }

        public Square(string name, double a) : base(name)
        {
            Side = a;
        }

        public override double Area => Side * Side;

        public override double Perimeter => 4 * Side;
    }
}