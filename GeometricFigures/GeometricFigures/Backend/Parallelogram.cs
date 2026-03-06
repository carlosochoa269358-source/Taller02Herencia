namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H 
        { 
            get => _h;
            set
                {
                _h = value;
                ValidateH();
            }
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea()
        {
            return B * _h;
        }
        public override double GetPerimeter() 
        { 
            return 2 * (A + B);
        }
        private void ValidateH()
        {
            if (_h <= 0)
                throw new ArgumentException("Height must be greater than 0.");
        }
    }
}