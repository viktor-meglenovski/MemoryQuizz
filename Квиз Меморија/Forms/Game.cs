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
        public Scene sceneInMemory { get; set; }
        public Menu menu { get; set; }
        public List<Question> questions { get; set; }
        public Game(Menu menu)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();
            this.panelQuestions.Visible = false;
            this.menu = menu;
            this.scene = new Scene(this);
            this.sceneInMemory = null;
            this.questions = new List<Question>();
            startGame();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            scene.drawAllShapes(e.Graphics);
        }
        private void startGame()
        {
            timerCountToStart.Enabled = true;
        }

        private void timerCountToStart_Tick(object sender, EventArgs e)
        {
            lblCountSeconds.Text = (Convert.ToInt32(lblCountSeconds.Text) - 1).ToString();
            if(lblCountSeconds.Text=="0")
            {
                scene.generate();
                Invalidate();
                sceneInMemory = scene;
                lblCountSeconds.Text = "10";
                timerCountToStart.Enabled = false;
                timerCountToDisappear.Enabled = true;
            }
        }

        private void timerCountToDisappear_Tick(object sender, EventArgs e)
        {
            lblCountSeconds.Text = (Convert.ToInt32(lblCountSeconds.Text) - 1).ToString();
            if (lblCountSeconds.Text == "0")
            {
                scene = new Scene(this);
                Invalidate();
                timerCountToStart.Enabled = false;
                timerCountToDisappear.Enabled = false;
                generateQuestions();
                this.panelQuestions.Visible = true;
                startAnsweringQuestions();
            }
        }
        private void generateQuestions()
        {
            //da se implementira random biranje na 5 prasanja od baza na prasanja
        }
        private void startAnsweringQuestions()
        {
            for(int i=0;i<5;i++)
            {

            }
        }
    }
}
