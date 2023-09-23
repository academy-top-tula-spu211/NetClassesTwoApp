using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesTwoApp
{
    abstract class Shape
    {
        public virtual string Name { get; set; }
        public Shape(string name = "Shape")
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimetr();
    }

    class Rectangle : Shape
    {
        public override string Name 
        {
            get { return "Rec" + base.Name; }
            set { base.Name = value; } 
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
            : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override sealed double Area() { return Width * Height; }
        public override double Perimetr() { return 2 * (Width + Height); }
    }
    class Circle : Shape
    {
        const double PI = 3.1415;
        public double Radius { get; set; }

        public Circle(double radius)
            : base("Circle")
        {
            Radius = radius;
        }

        public override double Area() { return Radius * Radius * PI; }
        public override double Perimetr() { return 2 * Radius * PI; }
    };

    class Square : Shape
    {
        public double Side { set; get; }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimetr()
        {
            return 4 * Side;
        }
    }
}
