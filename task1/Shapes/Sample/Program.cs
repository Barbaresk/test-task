using Shapes;
using System;
using System.Reflection.Metadata;

namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> s = new List<IShape>();
            s.Add(new Circle(2));
            s.Add(new Triangle(3, 4, 5));
            s.Add(new Square(4));
            Print(s);
        }

        static void Print(IEnumerable<IShape> shapes)
        {
            foreach(var s in shapes)
            {
                Console.WriteLine(s.Area);
            }
        }
    }
}