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
        public Shape(Color color, Size size,Point center)
        {
            this.color = color;
            this.size = size;
            this.center = center;
        }
        public abstract void draw(Graphics g);
    }

}
