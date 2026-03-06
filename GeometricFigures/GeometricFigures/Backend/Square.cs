namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;
        public double A 
        { 
            get => _a;
            set
            {
                _a = value;
                ValidateA();
            }
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public override double GetArea()
        {
            return _a * _a;
        }
        public override double GetPerimeter()
        {
            return 4 * _a;
        }
        private void ValidateA()
        {
            if (_a <= 0)
                throw new ArgumentException("Side length must be greater than 0.");
        }

    }
}