using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    public class Task3
    {
        class Shape
        {
            protected double Area;

            public Shape()
            {
                Area = 0;
            }

            public virtual double CalculateArea()
            {
                return Area;
            }
        }

        class Rectangle : Shape
        {
            private double _length;
            private double _width;

            public double Length
            {
                get { return _length; }
                set { _length = value; }
            }

            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }

            public double CalculateArea(double length, double width)
            {
                _length = length;
                _width = width;
                Area = _length * _width;
                return Area;
            }
        }

        class Circle : Shape
        {
            private double _radius;

            public double Radius
            {
                get { return _radius; }
                set { _radius = value; }
            }

            public override double CalculateArea()
            {
                Area = Math.PI * _radius * _radius;
                return Area;
            }

            public double CalculateArea(double radius)
            {
                _radius = radius;
                return CalculateArea();
            }
        }
        public void task3()
        {

            Rectangle rectangle1 = new Rectangle();
            double rectangleArea1 = rectangle1.CalculateArea(4, 5);

            Rectangle rectangle2 = new Rectangle();
            double rectangleArea2 = rectangle2.CalculateArea(6, 7);

            Circle circle1 = new Circle();
            double circleArea1 = circle1.CalculateArea(3);

            Circle circle2 = new Circle();
            circle2.Radius = 4;
            double circleArea2 = circle2.CalculateArea();

            Console.WriteLine($"Rectangle 1 Area: {rectangleArea1}");
            Console.WriteLine($"Rectangle 2 Area: {rectangleArea2}");
            Console.WriteLine($"Circle 1 Area: {circleArea1}");
            Console.WriteLine($"Circle 2 Area: {circleArea2}");
        }
    }
}
