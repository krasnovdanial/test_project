using AreasOfFigures.Figures;

namespace AreasOfFigures
{
    /// <summary>
    /// Определение круга.
    /// </summary>
    class Circle : Figure
    {
        private const double Pi = Math.PI;
        private double Radius { get; set; }

        /// <summary>
        /// Считает радиус и проверяет на корректность стороны.
        /// </summary>
        /// <param name="name">Название фигуры.</param>
        /// <param name="radius">Радиус.</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(string name, double radius)
                    : base(name)
        {
            if (radius < 0)
			{
                throw new ArgumentException("Радиус круга не может быть меньше нуля", nameof(radius));
			}

            Radius = radius;
        }
        /// <summary>
        /// Свойство получния площади.
        /// </summary>
		public override double AreaProp
		{
			get
			{
                return Pi * Math.Pow(Radius, 2d);
            }
        }
        /// <summary>
        /// Считает площадь круга.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Pi * Math.Pow(Radius, 2d);
        }
        /// <summary>
        /// Печатает площадь круга в консоль.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Radius: {0};", Radius);
        }
    }
}