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
    public partial class Game : Form
    {
        public Menu menu { get; set; }
        public Game(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
    }
}
