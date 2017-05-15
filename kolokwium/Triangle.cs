using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Triangle
    {
        public List<Point> vertices = new List<Point>();


        public Triangle(int a, int b)
        {

            vertices = new List<Point>
            {
                new Point(0, 0),
                new Point(a, 0),
                new Point(a, (0.5 * b))
            };
        }

        public Triangle(Point pnt, int a, int b)
        {

            vertices = new List<Point>
            {
                pnt,
                new Point(pnt.x + a, pnt.y),
                new Point(pnt.x + a, pnt.y + (0.5 * b))
            };
        }
    }
}
