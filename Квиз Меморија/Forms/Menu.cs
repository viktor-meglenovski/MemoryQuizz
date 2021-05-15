using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квиз_Меморија
{
    public partial class Menu : Form
    {
        public Game game { get; set; }
        public ScoreBoard scoreBoard { get; set; }
        public Menu()
        {
            InitializeComponent();
            game = new Game(this);
            scoreBoard = new ScoreBoard(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            scoreBoard.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            game.ShowDialog();
        }
    }
}
