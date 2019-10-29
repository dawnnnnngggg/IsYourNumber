using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Rectangle
    {
        private float length;
        private float width;
        public Rectangle()
        {
            length = 1.0f;
            width = 1.0f;
        }
        public Rectangle(float l,float w)
        {
            length = l;
            width = w;
        }
        public float GetLength()
        {
            return length;
        }
        public void SetLength(float newLength)
        {
            this.length = newLength;
        }
        public float GetWidth()
        {
            return width;
        }
        public void SetWidth(float newWidth)
        {
            this.width = newWidth;
        }
        public float GetArea()
        {
            return length * width;
        }
        public float Perimeter()
        {
            return (length + width) / 2;
        }
        public override string ToString()
        {
            return String.Format("Rectangle[length={0}, width={1}]", length,width);
            //return base.ToString();
        }
    }
}
