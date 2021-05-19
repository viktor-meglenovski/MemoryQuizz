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
    public partial class ScoreBoard : Form
    {
        public Menu menu { get; set; }
        public ScoreBoard(Menu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.menu = menu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            this.Close();
        }
    }
}
