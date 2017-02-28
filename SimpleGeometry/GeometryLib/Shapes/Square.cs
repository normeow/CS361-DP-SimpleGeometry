using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Square : Shape
    {
        public double Side { get; }
        public Square(double side)
        {
            this.Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override string print()
        {
            string info = String.Format("Square: side = {0}, area = {1}", Side, GetArea());
            return  info;
        }
    }
}
