using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class TriangleTest
    {
        public void Test1()
        {
            List<Point> expectedVerticles = new List<Point>
            {
            new Point(0, 0),
            new Point(9, 2),
            new Point(8, 7)
        };

            Triangle triangle = new Triangle(9, 7);

            foreach (Point pos in triangle.vertices)
            {
                if (!expectedVerticles.Contains(pos))
                {
                    Assert.Fail();
                }
            }
        }

        
    }
}
