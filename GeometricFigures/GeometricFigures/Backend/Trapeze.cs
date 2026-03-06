namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d; 
     
        public double D
        {
            get => _d;
            set
        {
                _d = value;
                ValidateD();
            }
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
       
        }

        public override double GetArea()
        {
            return ((A + B) * H) / 2;
        }

        public override double GetPerimeter() 
        { 
            return A + B + C + _d;
        }
        private void ValidateD()
        {
            if (_d <= 0)
                throw new ArgumentException("Side D must be greater than 0.");
        }
    }
}