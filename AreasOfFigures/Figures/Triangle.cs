using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfFigures.Figures 
{
    /// <summary>
    /// Класс треугольника с 3 сторонами.
    /// </summary>
    class Triangle : Figure, ITriangle
    {
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }

        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;
        /// <summary>
        /// Треугольник с именем и с 3 сторонами. Также считает площадь и проверяет на прямоугольность.
        /// </summary>
        /// <param name="name">Название фигуры.</param>
        /// <param name="edgeA">Сторона А</param>
        /// <param name="edgeB">Сторона В</param>
        /// <param name="edgeC">Сторона С</param>
        public Triangle(string name, double edgeA, double edgeB, double edgeC)
                    : base(name)
        {
            if (edgeA < 0)
                throw new ArgumentException("Cторона не может быть отрицательной.", nameof(edgeA));

            if (edgeB < 0)
                throw new ArgumentException("Cторона не может быть отрицательной.", nameof(edgeB));

            if (edgeC < 0)
                throw new ArgumentException("Cторона не может быть отрицательной.", nameof(edgeC));

            if (((edgeA + edgeB) > edgeC) && ((edgeB + edgeC) > edgeA) && ((edgeA + edgeC) > edgeB))
            {
                EdgeA = edgeA;
                EdgeB = edgeB;
                EdgeC = edgeC;
            }

            else
            {
                EdgeA = EdgeB = EdgeC = 1;
            }

            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        private bool GetIsRightTriangle()
        {
            double maxEdge = EdgeA, b = EdgeB, c = EdgeC;

            return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < 0;
        }

        /// <summary>
        /// Переопределенное свойство площади.
        /// </summary>
        public override double AreaProp
        {
            get
            {
                double perimeter, area;
                perimeter = (EdgeA + EdgeB + EdgeC) / 2d;
                area = Math.Sqrt(perimeter * (perimeter - EdgeA) * (perimeter - EdgeB) * (perimeter - EdgeC));

                return area;
			}
		}

		/// <summary>
		/// Высчитывает площадь.
		/// </summary>
		/// <returns></returns>
		public override double CalculateArea()
		{
			double perimeter, area;
			perimeter = (EdgeA + EdgeB + EdgeC) / 2d;
			area = Math.Sqrt(perimeter * (perimeter - EdgeA) * (perimeter - EdgeB) * (perimeter - EdgeC));

			return area;
		}
        /// <summary>
        /// Печатает площадь в консоль.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Area: {0};", AreaProp);
        }
    }
}
