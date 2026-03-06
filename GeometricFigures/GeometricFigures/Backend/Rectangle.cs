namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        private double _b;
        public double B 
        { 
            get => _b;
            set
            {
                _b = value;
                ValidateB();
            }
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public override double GetArea()
            {
            return A * _b;
        }

        public override double GetPerimeter()
            {
            return 2 * (A + _b);
        }
        private void ValidateB()
        {
            if (_b <= 0)
                throw new ArgumentException("Side length must be greater than 0.");
        }
    }
}