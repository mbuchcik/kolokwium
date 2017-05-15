using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Trapezium
    {
        public List<Point> vertices = new List<Point>();

        public Trapezium(int a, int b, int c)
        {

            vertices = new List<Point> {
                new Point(0, 0),
                new Point(a, 0),
                new Point(a, b),
                new Point(0, c)
            };
        }

        public Trapezium(Point pnt, int a, int b, int c)
        {

            vertices = new List<Point> {
                pnt,
                new Point(pnt.x + a, pnt.y),
                new Point(pnt.x + a, pnt.y + b),
                new Point(pnt.x, pnt.y + c)
            };
        }

    }
}
