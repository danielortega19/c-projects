using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracClasses
{
    public class Sphere : Shape
    {
        public double Radious { get; set; }

        public Sphere(double radius) 
        {
            Name = "Sphere";
            Radious = radius;
        }
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radious, 3)) * 4/3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The Sphere has a radius of {0}", Radious);
        }

    }
}
