using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radium of {0}, area of {1} and circumference {2}", c1.GetRadius(), c1.GetArea(),c1.GetCircumference());
            Circle c2 = new Circle(2.0);
            Console.WriteLine("The circle has radium of {0}, area of {1} and circumference {2}", c2.GetRadius(), c2.GetArea(), c2.GetCircumference());
            Circle c3 = new Circle();
            Console.WriteLine(c3.ToString());
        }
    }
}
