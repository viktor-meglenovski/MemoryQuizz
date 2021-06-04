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
    public partial class Instructions : Form
    {
        public Menu menu { get; set; }
        public Instructions(Menu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.menu = menu;
            DoubleBuffered = true;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            this.Visible = false;
            menu.Visible = true;
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            menu.buttonclick.Play();
        }
    }
}
