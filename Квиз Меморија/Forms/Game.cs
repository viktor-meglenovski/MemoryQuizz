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
using Квиз_Меморија.GameStructure;

namespace Квиз_Меморија
{
    public partial class Game : Form
    {
        public static readonly Image x = Image.FromFile(@"Pictures\Cross.png");
        public static readonly Image v = Image.FromFile(@"Pictures\Tick.png");
        public static readonly Image q = Image.FromFile(@"Pictures\Question_Mark.png");

        public static readonly SoundPlayer correct = new SoundPlayer(@"Audio\correct.wav");
        public static readonly SoundPlayer incorrect = new SoundPlayer(@"Audio\incorrect.wav");
        public static readonly SoundPlayer gameover = new SoundPlayer(@"Audio\gameover.wav");
        public static readonly SoundPlayer tick = new SoundPlayer(@"Audio\tick.wav");

        public Scene scene { get; set; }
        public Scene sceneInMemory { get; set; }
        public Menu menu { get; set; }
        public List<Question> questions { get; set; }
        public int DifficultyLevel { get; set; }
        public int PointsPerAnswer { get; set; }
        public Game(Menu menu, int DifficultyLevel)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.menu = menu;
            InitializeComponent();
            this.btnReturn.Visible = false;
            this.DifficultyLevel = DifficultyLevel;
            this.PointsPerAnswer = DifficultyLevel == 0 ? 50 : DifficultyLevel == 1 ? 100 : 150;
            DoubleBuffered = true;
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            scene.drawAllShapes(e.Graphics);
        }
        public void startGame()
        {
            this.panelQuestions.Visible = false;
            this.panelScore.Visible = false;
            this.scene = new Scene(this,DifficultyLevel);
            this.sceneInMemory = null;
            this.questions = new List<Question>();
            lblCountSeconds.Visible = true;
            lblCountSeconds.Text = "5";
            timerCountToStart.Enabled = true;
        }
        private void timerCountToStart_Tick(object sender, EventArgs e)
        {
            tick.Play();
            lblCountSeconds.Text = (Convert.ToInt32(lblCountSeconds.Text) - 1).ToString();
            if(lblCountSeconds.Text=="0")
            {
                scene.generate();
                Invalidate();
                sceneInMemory = scene;
                lblCountSeconds.Text = "15";
                timerCountToStart.Enabled = false;
                timerCountToDisappear.Enabled = true;
            }
        }

        private void timerCountToDisappear_Tick(object sender, EventArgs e)
        {
            tick.Play();
            lblCountSeconds.Text = (Convert.ToInt32(lblCountSeconds.Text) - 1).ToString();
            if (lblCountSeconds.Text == "0")
            {
                Invalidate();
                sceneInMemory = scene;
                scene = new Scene(this,DifficultyLevel);
                Invalidate();
                timerCountToStart.Enabled = false;
                timerCountToDisappear.Enabled = false;
                generateQuestionsAndAnswers();
                panelQuestions.Visible = true;
                currentQuestionNumber = 0;
                lblCountSeconds.Text = "30";
                timerPlayTime.Enabled = true;
                startAnsweringQuestions(currentQuestionNumber);
            }
        }
        private void generateQuestionsAndAnswers()
        {
            RandomQuestionsGenerator.generateQuestions();
            String[] questionsText = RandomQuestionsGenerator.generateQuestionsForGame(DifficultyLevel);
            foreach(String q in questionsText)
                questions.Add(new Question(q));

            Console.WriteLine(DifficultyLevel == 0 ? "easy" : DifficultyLevel == 1 ? "normal" : "hard");
            //presmetuvanje odgovori za easy questions;
            if(DifficultyLevel==0)
            {
                foreach (Shape s in sceneInMemory.Shapes)
                {
                    foreach (Question q in questions)
                    {
                        if (q.text.Contains(s.getColorAsString().ToUpper()))
                            q.answer++;
                        if (q.text.Contains(s.GetType().Name.ToUpper()))
                            q.answer++;
                        if (q.text.Contains(s.size.ToString().ToUpper()))
                            q.answer++;
                        if (q.text.Contains("TOTAL"))
                            q.answer++;
                    }
                }
            }
            else if(DifficultyLevel==1)
            {
                foreach (Shape s in sceneInMemory.Shapes)
                {
                    foreach (Question q in questions)
                    {
                        if (q.text.Contains(s.getColorAsString().ToUpper()) && q.text.Contains(s.GetType().Name.ToUpper()))
                            q.answer++;
                        if (q.text.Contains(s.getColorAsString().ToUpper()) && q.text.Contains(s.size.ToString().ToUpper()))
                            q.answer++;
                        if (q.text.Contains(s.GetType().Name.ToUpper()) && q.text.Contains(s.size.ToString().ToUpper()))
                            q.answer++;
                    }
                }
            }
            else
            {
                foreach (Shape s in sceneInMemory.Shapes)
                {
                    foreach (Question q in questions)
                    {
                        if (q.text.Contains(s.getColorAsString().ToUpper()) && q.text.Contains(s.GetType().Name.ToUpper()) && q.text.Contains(s.size.ToString().ToUpper()))
                            q.answer++;
                    }
                }
            }
            /* za proverka dali odgovorite tocno se presmetuvaat
            foreach (Question q in questions)
                Console.WriteLine(q.text + "-"+q.answer);
            */
        }
        public bool questionsManager { get; set; }
        public int currentQuestionNumber { get; set; }
        private void startAnsweringQuestions(int i)
        {
            nudUserAnswer.Value = 0;
            btnNextQuestion.Enabled = false;
            btnCheckAnswer.Enabled = true;
            lblQuestionNumber.Text = "Question #" + (i + 1);
            lblQuestion.Text = questions[i].text;
            lblAnswerResult.Text = "";
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            currentQuestionNumber++;
            if (currentQuestionNumber < 5)
                startAnsweringQuestions(currentQuestionNumber);
            else gameOver();
        }
        private void gameOver()
        {
            gameover.Play();
            panelScore.Visible = true;
            lblCountSeconds.Visible = false;
            timerCountToDisappear.Stop();
            timerCountToStart.Stop();
            timerPlayTime.Stop();
            updatePictures();
            int timeBonus = Int32.Parse(lblCountSeconds.Text) * Int32.Parse(lblScoreValue.Text) / 10;
            lblFinalScore.Text = (Int32.Parse(lblScoreValue.Text) + timeBonus).ToString() ;
        }
        private void updatePictures()
        {
            pictureBox1.Image = questions[0].userAnswer == -1 ? q : questions[0].isCorrect ? v : x;
            pictureBox2.Image = questions[1].userAnswer == -1 ? q : questions[1].isCorrect ? v : x;
            pictureBox3.Image = questions[2].userAnswer == -1 ? q : questions[2].isCorrect ? v : x;
            pictureBox4.Image = questions[3].userAnswer == -1 ? q : questions[3].isCorrect ? v : x;
            pictureBox5.Image = questions[4].userAnswer == -1 ? q : questions[4].isCorrect ? v : x;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            Question q = questions[currentQuestionNumber];
            btnCheckAnswer.Enabled = false;
            q.userAnswer = (int)nudUserAnswer.Value;
            q.checkQuestion();
            lblAnswerResult.Text = q.resultText();
            lblAnswerResult.ForeColor = q.isCorrect ? Color.Green : Color.Red;
            if (q.isCorrect)
            {
                lblScoreValue.Text = (Convert.ToInt32(lblScoreValue.Text) + PointsPerAnswer).ToString();
                correct.Play();
            }
            else
                incorrect.Play();
            btnNextQuestion.Enabled = true;
        }

        private void timerPlayTime_Tick(object sender, EventArgs e)
        {
            tick.Play();
            lblCountSeconds.Text = (Convert.ToInt32(lblCountSeconds.Text) - 1).ToString();
            if (lblCountSeconds.Text == "0")
            {
                timerPlayTime.Enabled = false;
                gameOver();
            }
        }

        private void btnAddToScoreBoard_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            if (tbName.Text != "")
                menu.scoreBoard.addEntry(Int32.Parse(lblFinalScore.Text), tbName.Text);
            else
                menu.scoreBoard.addEntry(Int32.Parse(lblFinalScore.Text), "NO_NAME");
            this.Visible = false;
            menu.scoreBoard.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            panelQuestions.Visible = false;
            panelScore.Visible = false;
            scene = sceneInMemory;
            btnReturn.Visible = true;
            Invalidate();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            menu.buttonclick.Play();
            scene = new Scene(this,DifficultyLevel);
            Invalidate();
            panelQuestions.Visible = true;
            panelScore.Visible = true;
            btnReturn.Visible = false;
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            menu.buttonclick.Play();
        }
    }
}
