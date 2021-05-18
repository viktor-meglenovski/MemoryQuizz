using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public enum Size { Small = 20, Medium = 40, Large = 60 }
    public abstract class Shape
    {
        public Color color { get; set; }
        public Size size { get; set; }
        public Point center { get; set; }
        public Rectangle area { get; set; }
        public Shape(Color color, Size size,Point center)
        {
            this.color = color;
            this.size = size;
            this.center = center;
            int sizeInt = (int)size;
            this.area = new Rectangle(center.X - sizeInt*2, center.Y - sizeInt*2, 4 * sizeInt, 4 * sizeInt);
        }
        public abstract void draw(Graphics g);
        //funkcija so koja se proveruva dali dadenata tocka e vo neposredna blizina na formata (za da se odbegne poklopuvanje)
        public bool isNear(Point p)
        {
            return area.Contains(p);
        }
        public void drawRectangle(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, area);
        }
    }

}
