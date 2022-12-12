using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle
    {
        // радиус
        public double R { get; set; }

        public Circle() { R = 1; }
        public Circle(double r)
        {
            R = r;
        }

        // площадь круга
        public double GetСircleArea()
        {
            return Math.Round(Math.PI * Math.Pow(R, 2), 2);
        }

        // площадь окружности
        public double GetСircle()
        {
            return Math.Round(Math.PI * R * 2, 2);
        }

    }
}
