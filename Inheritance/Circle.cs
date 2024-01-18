using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Circle :Shape
    {
        //public class Circle : Shape
        
            private double radius;
            public Circle()
            {// Default constructor
            }
            public Circle(int xValue, int yValue, double radiusIn)
            {
                // Another constructor
                X = xValue;// Use the PROPERTIES of the Point class
                Y = yValue;
                SetValues(xValue, yValue);  // USE a base class method to set parameters
                radius = radiusIn;  // Radius
            }
            public void setData(int xValue, int yValue, double radiusIn)
            {
                SetValues(xValue, yValue);
                radius = radiusIn;
            }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0.0) radius = value;
            }
        }
        public class Test
        {
            public static void Main()
            {
                Shape s = new Shape();
                s.X = 100;
                s.Y = 100;
                Console.WriteLine("Point values are " + s.X + " " + s.Y);
                Circle c = new Circle(200, 200, 20.0);
                Console.WriteLine("Circle position is " + c.X + " " + c.Y);
                Console.WriteLine("Circle diameter is " + c.Radius);
                Console.Read();//  Wait for a key
            }
        }

    }

}

