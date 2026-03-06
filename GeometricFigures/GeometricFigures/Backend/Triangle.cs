namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C 
        { 
            get => _c;
            set
                {
                _c = value;
                ValidateC();
            }

        }
        public double H 
        { 
            get => _h;
            set
                {
                _h = value;
                ValidateH();
            }
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea()
            {
            return (B * _h) / 2;
        }

        public override double GetPerimeter()
            {
            return A + B + _c;
        }
        private void ValidateC()
        {
            if (_c <= 0)
                throw new ArgumentException("Side C must be greater than 0.");
        }
        private void ValidateH()
        {
            if (_h <= 0)
                throw new ArgumentException("Height must be greater than 0.");
        }
    }
}