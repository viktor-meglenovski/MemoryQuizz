using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{


    public class RandomShapeGenerator
    {
        public static Color[] Colors = { Color.Red, Color.Blue, Color.Green };
        public enum Shapes { Square, Circle, Triangle }
        public int maxX { get; set; }
        public int maxY { get; set; }
        public Random random { get; set; }
        public RandomShapeGenerator(int maxX, int maxY)
        {
            this.maxX = maxX;
            this.maxY = maxY;
            this.random = new Random();
        }
        public List<Shape> generateShapes()
        {
            List<Shape> RandomShapes = new List<Shape>();
            int counter = random.Next(5, 20);
            for(int i=0;i<counter;i++)
            {
                Color color = Colors.ElementAt(random.Next(0, 3));
                int x = random.Next(50, maxX);
                int y = random.Next(50, maxY);
                Point center = new Point(x, y);
                bool notIntersecting = true;
                foreach(Shape s in RandomShapes)
                    if(s.isNear(center))
                    {
                        i--;
                        notIntersecting = false;
                        break;
                    }
                if(notIntersecting)
                {
                    Shapes shape = (Shapes)random.Next(0, 3);
                    int sizeRandom = random.Next(0, 3);
                    Size size = sizeRandom == 0 ? Size.Small : sizeRandom == 1 ? Size.Medium : Size.Large;
                    if (shape == Shapes.Square)
                        RandomShapes.Add(new Square(color, size, center));
                    if (shape == Shapes.Circle)
                        RandomShapes.Add(new Circle(color, size, center));
                    if (shape == Shapes.Triangle)
                        RandomShapes.Add(new Triangle(color, size, center));
                }
            }
            return RandomShapes;
        }

    }
}
