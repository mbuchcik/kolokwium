using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class SquareTest
    {
        public void Test1()
        {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(2, 2),
                new Point(3, 2),
                new Point(3, 3),
                new Point(2, 3)
            };

            Square square = new Square(2,2);

            foreach (Point pos in square.vertices)
            {
                if (!expectedPoints.Contains(pos))
                {
                    Assert.Fail();
                }
            }
        }

        public void Test2()
        {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(4, 4),
                new Point(5, 4),
                new Point(5, 5),
                new Point(4, 5)
            };

            Square square = new Square(new Point(4, 4), 3, 3);

            foreach (Point pos in square.vertices)
            {
                if (!expectedVerticles.Contains(pos))
                {
                    Assert.Fail();
                }
            }
    }        
 