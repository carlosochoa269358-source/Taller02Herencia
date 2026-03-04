using System.Globalization;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "{0,-15} => Area.....: {1,15:N5}     Perimiter: {2,15:N5}",
                Name,
                Area,
                Perimeter);
        }
    }
}
