﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }

        public override string print()
        {                        
            var area = this.GetArea();
            return String.Format($"Circle: radius = {this.Radius}, area = {area}");
        }

        public override double GetArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
