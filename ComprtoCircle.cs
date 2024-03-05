using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(3.6);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadKey();
        }
    }
   // pt so sánh
    public class ComperableCircle : Circle, IComparable<ComperableCircle>
    {
        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComperableCircle o)
        {
            if (Radius > o.Radius) return 1;
            else if (Radius < o.Radius) return -1;
            else return 1;
        }
    }

    
    //lop Shape
    public class Shape
    {
        private string color = "green";
        private bool filled = true;
        // ham khoi tao
        public Shape() { }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        // get, set shape
        public string Color { get { return this.color; } set { this.color = value; } }
        public bool Filled { get { return this.filled; } set { this.filled = value; } }
        // ghi de to string

        public override string ToString()
        {
            return $"A Shape with color of {color} and {(filled ? "filled" : "not filled")}";
        }
    }
    // lop Circle
    public class Circle : Shape
    {
        double radius = 1.0;
        // ham khoi tao
        public Circle()
        {

        }
        public Circle(double radius) : base()
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        // get and set
        public double Radius { get { return radius; } set { radius = value; } }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius={radius}, which is a subclass of {base.ToString()}";
        }
    }
    // lop Rectangle
    public class Rectangle : Shape
    {
        double height;
        double width;
        // ham khoi tao
        public Rectangle(double height, double width) : base()
        {
            this.height = height;
            this.width = width;
        }
        public Rectangle(double height, double width, string color, bool filled) : base(color, filled)
        {
            this.height = height;
            this.width = width;
        }
        // get and set
        public double Height { get { return height; } set { height = value; } }
        public double Width { get { return width; } set { width = value; } }
        // s and chuvi
        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
        // to string
        public override string ToString()
        {
            return $"A Rectangle with width={width} and length={height}, which is a subclass of {base.ToString()}";
        }


    }
    // lop Square
    public class Squaren : Shape
    {
        double side = 1.0;
        // ham khoi tao
        public Squaren(double side) : base()
        {
            this.side = side;
        }
        public Squaren(double side, string color, bool filled) : base(color, filled)
        {
            this.side = side;
        }
        // get and set
        public double Side { get { return side; } set { side = value; } }
        // s and chuvi
        public double GetArea()

        {

            return side * side;

        }

        public double GetPerimeter()

        {

            return 4 * side;

        }
        // to string

        public override string ToString()
        {
            return $"A Square with side={side}, which is a subclass of {base.ToString()}";
        }

    }


}
