using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public class Circle:Shape
    {
        public Circle(Color color, Size size, Point center) : base(color, size, center){}
        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            int sizeInt = (int)size;
            g.FillEllipse(b, center.X - sizeInt/2, center.Y - sizeInt/2, sizeInt, sizeInt);
            b.Dispose();
        }
    }
}
