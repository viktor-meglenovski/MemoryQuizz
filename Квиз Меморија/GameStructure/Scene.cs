using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; }
        public Game game { get; set; }
        public int DifficultyLevel { get; set; }
        public Scene(Game game,int difficultyLevel)
        {
            this.Shapes = new List<Shape>();
            this.game = game;
            this.DifficultyLevel = difficultyLevel; //0-easy 1-normal 2-hard
        }
        public Scene(Scene s)
        {
            this.Shapes = new List<Shape>();
            foreach (Shape shape in s.Shapes)
                this.Shapes.Add(shape);
            this.game = s.game;
        }
        public void generate()
        {
            RandomShapeGenerator rsg = null;
            if(DifficultyLevel==0)
                rsg=new RandomShapeGenerator(game.Size.Width-120, game.Size.Height-150,5,11);
            else if(DifficultyLevel==1)
                rsg = new RandomShapeGenerator(game.Size.Width - 120, game.Size.Height - 150,10,21);
            else
                rsg = new RandomShapeGenerator(game.Size.Width - 120, game.Size.Height - 150,15,30);
            Shapes = rsg.generateShapes();
        }
        public void drawAllShapes(Graphics g)
        {
            foreach(Shape s in Shapes)
            {
                s.draw(g);
            }
        }

    }
}
