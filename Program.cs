using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8T1
{
    class Program
    {
        public class circle
        {
            protected double radius;
            protected string color;

            public circle()
            {

            }
            public circle(double radius)
            {
                this.radius = radius;
            }
            public circle(double radius, string color)
            {
                this.radius = radius;
                this.color = color;
            }
            public void setradius(double radius)
            {
                this.radius = radius;
            }
            public void setcolor(string color)
            {
                this.color = color;
            }
            public double getradius()
            {
                return radius;
            }
            public string getcolor()
            {
                return color;
            }
            public double getarea()
            {
                return  Math.PI *Math.Pow(radius,2);
            }
            public string tostring()
            {
                return "Radius: " + radius + "\t\t" + "Color: " + color;
            }
        }

        public class cylinder : circle
        {
            private double height;
            public cylinder()
            {

            }
            public cylinder(double radius) : base(radius)
            {
                
            }
            public cylinder(double radius, double height): base(radius)
            {
                this.height = height;
            }
            public cylinder(double radius, string color,double height) : base(radius,color)
            {
                this.height = height;
            }
            public double getheight()
            {
                return height;
            }
            public void setheight(double height)
            {
                this.height = height;
            }
            public double getvolume()
            {
                return Math.PI * Math.Pow(radius, 2)*height;
            }
        }
        static void Main(string[] args)
        {
            cylinder c = new cylinder();
            Console.Write("Enter the Radius: ");
            double radius = double.Parse(Console.ReadLine());
            c.setradius(radius);
            Console.Write("Enter the height: ");
            double height = double.Parse(Console.ReadLine());
            c.setheight(height);
           double result=  c.getvolume();
            Console.WriteLine("Volume: " + result);

            Console.Write("Enter the Radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = double.Parse(Console.ReadLine());
            cylinder c1 = new cylinder(radius,height);
            result = c1.getvolume();
            Console.WriteLine("Volume: " + result);

            Console.Write("Enter the Radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = double.Parse(Console.ReadLine());
            cylinder c2 = new cylinder(radius, height);
            result = c2.getvolume();
            Console.WriteLine("Volume: " + result);

            Console.ReadKey();

        }
    }
}
