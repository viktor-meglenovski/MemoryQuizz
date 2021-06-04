using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квиз_Меморија.Forms
{
    public partial class ChooseDifficulty : Form
    {
        public Menu menu { get; set; }
        public ChooseDifficulty(Menu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.menu = menu;
            DoubleBuffered = true;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            this.Visible = false;
            menu.createGame(0);
        }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            this.Visible = false;
            menu.createGame(1);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            this.Visible = false;
            menu.createGame(2);
        }

        private void ChooseDifficulty_MouseClick(object sender, MouseEventArgs e)
        {
            menu.buttonclick.Play();
        }
    }
}
