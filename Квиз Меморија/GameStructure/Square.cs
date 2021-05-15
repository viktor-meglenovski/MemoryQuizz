using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public class Square: Shape
    {
        public Square(Color color, Size size,Point center) : base(color,size,center){}
        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            int sizeInt = (int)size;
            Console.WriteLine(sizeInt);
            g.FillRectangle(b, center.X - sizeInt / 2, center.Y - sizeInt / 2, sizeInt, sizeInt);
            b.Dispose();
        }
    }
}
