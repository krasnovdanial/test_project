using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfFigures.Figures
{

    /// <summary>
    /// Абстрактный класс Figure - содержит абстрактный метод Area()
    /// и абстрактное свойство Area2
    /// </summary>
    abstract class Figure
    {
        // 1. Скрытое поле класса
        private string name; // Название фигуры

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Название фигуры.</param>
        public Figure(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Свойство доступа к полю класса
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Абстрактное свойство, возвращающее площадь фигуры
        /// </summary>
        public abstract double AreaProp { get; }

        /// <summary>
        /// Абстрактный метод, возвращающий площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateArea();
    }
}
