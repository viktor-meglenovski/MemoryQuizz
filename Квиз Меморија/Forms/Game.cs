using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Квиз_Меморија.GameStructure;

namespace Квиз_Меморија
{
    public partial class Game : Form
    {
        public Scene scene { get; set; }
        public Menu menu { get; set; }
        public Game(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.scene = new Scene(this);
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            scene.drawAllShapes(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scene.generate();
            Invalidate();
            label1.Text = scene.Shapes.Count.ToString();
        }
    }
}
