namespace Shapes
{
    /// <summary>
    /// Фигура в общем случае
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double Area { get; }
    }
}
