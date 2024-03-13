using System;

namespace Shapes
{
    /// <summary>
    /// Фигура - круг
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Создание круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius should be positive");
            Radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Area => Math.PI * Radius * Radius;
    }
}
