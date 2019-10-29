using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radium of {0} and area of {1}",c1.GetRadius(),c1.GetArea());
            Circle c2 = new Circle(2.0);
            Console.WriteLine("The circle has radium of {0} and area of {1}", c2.GetRadius(), c2.GetArea());
            Circle c3 = new Circle(3.0, "Orange");
            Console.WriteLine("The circle has radium of {0} and color of {1}", c3.GetRadius(), c3.GetColor());
            Console.WriteLine(c3.ToString());
        }
    }
}
