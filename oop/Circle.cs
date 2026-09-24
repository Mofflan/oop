using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace oop
{
    internal class Circle
    {
        //skapar property Radius
        public int Radius { get; set; }
        private double area;
        private double omkrets;

        public Circle(int radie)
        {
            Radius = radie;
        }

        public double GetArea()
        {
            return area = Radius * Radius * Math.PI;

        }
        public double GetOmkrets()
        {
            return omkrets = Radius * 2 * Math.PI;
        }

    }
}
