using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    internal class Circle
    {
        int _radius;

        public int radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
            }
        }


        public Circle(int radie)
        {
            radius = radie;
        }

        public double GetArea()
        {
            double area;
            return area = radius * radius * Math.PI;

        }
        public double GetOmkrets()
        {
            double omkrets;
            return omkrets = radius * 2 * Math.PI;
        }

    }
}
