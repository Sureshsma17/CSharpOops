//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{

//    // 1. Abstract Base Class
//    abstract class Shape
//    {
//        // Abstract method
//        public abstract double CalculateArea();
//    }

//    // 2. Derived Class: Circle
//    class Circle : Shape
//    {
//        private double radius;

//        public Circle(double radius)
//        {
//            this.radius = radius;
//        }

//        public override double CalculateArea()
//        {
//            return Math.PI * radius * radius;
//        }
//    }

//    // 3. Derived Class: Rectangle
//    class Rectangle : Shape
//    {
//        private double length;
//        private double width;

//        public Rectangle(double length, double width)
//        {
//            this.length = length;
//            this.width = width;
//        }

//        public override double CalculateArea()
//        {
//            return length * width;
//        }
//    }
//    internal class AbstractShape
//    {
//        static void Main(string[] args)
//        {
//            Circle c = new Circle(3);
//            Rectangle r = new Rectangle(5, 4);

//            Console.WriteLine("Area of Circle: " + c.CalculateArea());
//            Console.WriteLine("Area of Rectangle: " + r.CalculateArea());
//        }
//    }
//}
