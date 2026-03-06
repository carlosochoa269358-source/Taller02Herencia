namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set
            {
                _r = value;
                ValidateR();
            }
        }
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }
        private void ValidateR()
        {
            if (_r <= 0)

              throw new ArgumentException("Radius must be greater than 0.");
            }
        }
    }
