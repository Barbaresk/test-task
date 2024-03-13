using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Square : IShape
    {
        public double Side { get; }
        public Square(double side) 
        {
            if(side <= 0)
            {
                throw new ArgumentException("Side should be positive");
            }
            Side = side;
        }
        public double Area => Side * Side;
    }
}
