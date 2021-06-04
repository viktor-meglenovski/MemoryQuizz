using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Квиз_Меморија.GameStructure;
using System.Media;

namespace Квиз_Меморија
{
    public partial class ScoreBoard : Form
    {
        public static readonly string ScoreFile = @"C:\Users\Viktor Meglenovski\Desktop\Квиз Меморија\Квиз Меморија\ScoreFiles\scores";
        public Menu menu { get; set; }
        public ScoreBoardStructure ScoreBoardStructure { get; set; }
        public bool saveFlag { get; set; }
        public ScoreBoard(Menu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.menu = menu;
            this.saveFlag = false;
            this.ScoreBoardStructure = new ScoreBoardStructure();
            if(!File.Exists(ScoreFile))
            {
                File.Create(ScoreFile);
            }
            else
            {
                FileStream fs = new FileStream(ScoreFile, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                ScoreBoardStructure = formatter.Deserialize(fs) as ScoreBoardStructure;
            }
            DoubleBuffered = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            menu.Visible = true;
            this.Visible = false;
        }
        public void addEntry(int points, string name)
        {
            ScoreBoardStructure.add(points, name);
            saveFlag = true;
            showScores();
        }
        public void showScores()
        {
            tbScores.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                if (ScoreBoardStructure.Scores.Count >= i)
                {
                    ScoreEntry se = ScoreBoardStructure.Scores[i - 1];
                    tbScores.Text += String.Format("#{0,-15}{1,-20}\t{2,-10}\r\n", i, se.Name, se.Points);
                }
                else
                {
                    tbScores.Text += String.Format("#{0}\r\n",i);
                }
            }
        }
        public void saveScores()
        {
            if(saveFlag)
            {
                FileStream fs = new FileStream(ScoreFile, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, ScoreBoardStructure);
            }
        }
        private void ScoreBoard_Paint(object sender, PaintEventArgs e)
        {
            showScores();
        }

        private void ScoreBoard_MouseClick(object sender, MouseEventArgs e)
        {
            menu.buttonclick.Play();
        }
    }
}
