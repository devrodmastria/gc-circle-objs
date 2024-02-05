using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculator
{
    internal class Circle
    {

        // provided by user
        private double radius;

        public double pi = Math.PI;
        public Circle(double newRadius)
        {
            radius = newRadius;
        }

        public double GetCircumference()
        {
            return 2 * pi * radius;
        }

        public double GetDiameter()
        {
            return 2 * radius;
        }

        public double GetArea() { 
            return pi * radius * radius ;
        }

        public double GetRadius() { return radius; }

        public void Grow()
        {
            radius *= 2;
        }
    }
}
