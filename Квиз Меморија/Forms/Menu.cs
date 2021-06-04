using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Квиз_Меморија.Forms;

namespace Квиз_Меморија
{
    public partial class Menu : Form
    {
        public SoundPlayer buttonclick = new SoundPlayer(@"Audio\buttonclick.wav");
        public Game game { get; set; }
        public ScoreBoard scoreBoard { get; set; }
        public Instructions instructions { get; set; }
        public ChooseDifficulty chooseDifficulty { get; set; }
        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            scoreBoard = new ScoreBoard(this);
            instructions = new Instructions(this);
            chooseDifficulty = new ChooseDifficulty(this);
            DoubleBuffered = true;
        }
        public void createGame(int n)
        {
            game = new Game(this, n);
            game.Visible = true;
            game.startGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            buttonclick.Play();
            scoreBoard.saveScores();
            this.Close();
        }

        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            buttonclick.Play();
            this.Visible = false;
            scoreBoard.Visible = true ;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            buttonclick.Play();
            this.Visible = false;
            chooseDifficulty.Visible = true;
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            buttonclick.Play();
            this.Visible = false;
            instructions.Visible = true;
        }

        private void Menu_MouseClick(object sender, MouseEventArgs e)
        {
            buttonclick.Play();
        }
    }
}
