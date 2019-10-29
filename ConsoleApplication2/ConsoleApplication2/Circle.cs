using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetRadius(double newRadius)
        {
            this.radius = newRadius;
        }
        public void SetColor(string newColor)
        {
            this.color = newColor;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0},color={1}]", radius, color);
        }
    }
}
