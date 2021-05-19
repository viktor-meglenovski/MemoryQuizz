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
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            scene.drawAllShapes(e.Graphics);
            Pen p = new Pen(Color.Red);
            Console.WriteLine(this.Width + " " + this.Height);
            e.Graphics.DrawRectangle(p,50,50,this.Width-120,this.Height-150);
            p.Dispose();
        }
        private void startGame()
        {
            timerCountToStart.Enabled = true;
        }
        public void startGame()
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
                lblCountSeconds.Text = "3";
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
                generateQuestionsAndAnswers();
                this.panelQuestions.Visible = true;
                currentQuestionNumber = 0;
                lblCountSeconds.Text = "10";
                timerPlayTime.Enabled = true;
                startAnsweringQuestions(currentQuestionNumber);
            }
        }
        private void generateQuestionsAndAnswers()
        {
            RandomQuestionsGenerator.generateQuestions();
            String[] questionsText = RandomQuestionsGenerator.generateEasyQuestions();
            foreach(String q in questionsText)
                questions.Add(new Question(q));
            foreach(Shape s in sceneInMemory.Shapes)
            {
                foreach(Question q in questions)
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
            foreach (Question q in questions)
                Console.WriteLine(q.text + "-"+q.answer);
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
            currentQuestionNumber++;
            if (currentQuestionNumber < 5)
                startAnsweringQuestions(currentQuestionNumber);
            else gameOver();
        }
        private void gameOver()
        {
            Console.WriteLine("gamover");
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            Question q = questions[currentQuestionNumber];
            btnCheckAnswer.Enabled = false;
            q.userAnswer = (int)nudUserAnswer.Value;
            q.checkQuestion();
            lblAnswerResult.Text = q.resultText();
            if (q.isCorrect)
                lblScoreValue.Text = (Convert.ToInt32(lblScoreValue.Text) + 100).ToString();
            btnNextQuestion.Enabled = true;
        }

        private void timerPlayTime_Tick(object sender, EventArgs e)
        {
            lblCountSeconds.Text = (Convert.ToInt32(lblCountSeconds.Text) - 1).ToString();
            if (lblCountSeconds.Text == "0")
            {
                timerPlayTime.Enabled = false;
                gameOver();
            }
        }
    }
}
