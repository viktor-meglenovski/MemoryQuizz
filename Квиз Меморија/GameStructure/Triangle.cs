using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public class Triangle:Shape
    {
        public Triangle(Color color, Size size, Point center) : base(color, size, center){}
        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            int sizeInt = (int)size;

            Point[] points = new Point[3];
            points[0] = center;
            points[1] = new Point(center.X - sizeInt / 2, center.Y + sizeInt);
            points[2] = new Point(center.X + sizeInt / 2, center.Y + sizeInt);

            g.FillPolygon(b, points);
            b.Dispose();
        }
    }
}
