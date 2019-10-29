using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Circle
    {
        private double radius;
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double r)
        {
            radius = r;
        }
        public void SetRadius(double radius)
        {
            this.radius=radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetCircumference()
        {
            return 2 * radius * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0}]",radius);
            //return base.ToString();
        }
    }
}
