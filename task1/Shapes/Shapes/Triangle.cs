using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    /// <summary>
    /// Фигура - треугольника
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Список сторон
        /// </summary>
        public IEnumerable<double> Sides { get; }

        /// <summary>
        /// Создание треугольника по длинам сторон
        /// </summary>
        /// <param name="side1">Сторона треугольника</param>
        /// <param name="side2">Сторона треугольника</param>
        /// <param name="side3">Сторона треугольника</param>
        public Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Sides should be positive");
            }
            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                throw new ArgumentException("Wrong sides length");
            }
            Sides = new List<double> { side1, side2, side3 };
        }

        /// <summary>
        /// Площадь треугольника 
        /// </summary>
        public double Area => Math.Sqrt(p * (p - s0) * (p - s1) * (p - s2));

        /// <summary>
        /// Треугольник является прямым
        /// </summary>
        public bool IsRight =>
            Double.Equals(s0 * s0, s1 * s1 + s2 * s2) ||
            Double.Equals(s1 * s1, s2 * s2 + s0 * s0) ||
            Double.Equals(s2 * s2, s0 * s0 + s1 * s1);

        //всякое разное для краткой записи
        private double p => 0.5 * Sides.Sum();
        private double s0 => Sides.ElementAt(0);
        private double s1 => Sides.ElementAt(1);
        private double s2 => Sides.ElementAt(2);
    }
}
