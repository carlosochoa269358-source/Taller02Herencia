namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;
        
        
        public double D1 
        {
            get => _d1;
            set
            {     _d1 = value;
                ValidateD1();
            }
        }
        public double D2 
        { 
            get => _d2;
            set
                {
                _d2 = value;
                ValidateD2();
            }
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea()
        {
            return (_d1 * _d2) / 2;
        }

        public override double GetPerimeter()
        { 
           return 4 * A;
        }

        private void ValidateD1()
        {
            if (_d1 <= 0)
                throw new ArgumentException(" D1 must be greater than 0.");
        }

        private void ValidateD2()
        {
            if (_d2 <= 0)
                throw new ArgumentException(" D2 must be greater than 0.");
        }

    }
}