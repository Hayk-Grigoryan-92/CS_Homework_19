using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public  void DisplayShapeInfo()
        {
            Console.WriteLine($"{Color} ");
        }
    }

    class Rectangle : Shape
    {
        private int _width;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if(value > 0)
                {
                    _width = value;
                }
            }
        }

        private int _height;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }

        public Rectangle(string color, int width, int heght) : base(color)
        {
            Width = width;
            Height = heght;
        }

        public void DisplayRectangleInfo()
        {
            Console.Write($"{Color} | {Width} | {Height} \n");
        }
    }
}
