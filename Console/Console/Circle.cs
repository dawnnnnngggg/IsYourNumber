using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public double GetRadius()
        {
            return radius;
        }
        public double GetaArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
