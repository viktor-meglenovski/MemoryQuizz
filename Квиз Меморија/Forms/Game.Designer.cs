
namespace Квиз_Меморија
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerCountToStart = new System.Windows.Forms.Timer(this.components);
            this.lblCountSeconds = new System.Windows.Forms.Label();
            this.timerCountToDisappear = new System.Windows.Forms.Timer(this.components);
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.lblAnswerResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.nudUserAnswer = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.timerPlayTime = new System.Windows.Forms.Timer(this.components);
            this.panelQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCountToStart
            // 
            this.timerCountToStart.Interval = 1000;
            this.timerCountToStart.Tick += new System.EventHandler(this.timerCountToStart_Tick);
            // 
            // lblCountSeconds
            // 
            this.lblCountSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSeconds.Location = new System.Drawing.Point(1136, -5);
            this.lblCountSeconds.Name = "lblCountSeconds";
            this.lblCountSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountSeconds.Size = new System.Drawing.Size(166, 95);
            this.lblCountSeconds.TabIndex = 2;
            this.lblCountSeconds.Text = "5";
            this.lblCountSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerCountToDisappear
            // 
            this.timerCountToDisappear.Interval = 1000;
            this.timerCountToDisappear.Tick += new System.EventHandler(this.timerCountToDisappear_Tick);
            // 
            // panelQuestions
            // 
            this.panelQuestions.Controls.Add(this.btnCheckAnswer);
            this.panelQuestions.Controls.Add(this.btnNextQuestion);
            this.panelQuestions.Controls.Add(this.lblAnswerResult);
            this.panelQuestions.Controls.Add(this.lblScoreValue);
            this.panelQuestions.Controls.Add(this.lblScore);
            this.panelQuestions.Controls.Add(this.nudUserAnswer);
            this.panelQuestions.Controls.Add(this.lblAnswer);
            this.panelQuestions.Controls.Add(this.lblQuestion);
            this.panelQuestions.Controls.Add(this.lblQuestionNumber);
            this.panelQuestions.Location = new System.Drawing.Point(12, 12);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(1064, 705);
            this.panelQuestions.TabIndex = 3;
            // 
            // lblAnswerResult
            // 
            this.lblAnswerResult.AutoSize = true;
            this.lblAnswerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerResult.Location = new System.Drawing.Point(27, 445);
            this.lblAnswerResult.Name = "lblAnswerResult";
            this.lblAnswerResult.Size = new System.Drawing.Size(269, 46);
            this.lblAnswerResult.TabIndex = 6;
            this.lblAnswerResult.Text = "Question Text";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(350, 633);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(137, 46);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // nudUserAnswer
            // 
            this.nudUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUserAnswer.Location = new System.Drawing.Point(218, 341);
            this.nudUserAnswer.Name = "nudUserAnswer";
            this.nudUserAnswer.Size = new System.Drawing.Size(120, 53);
            this.nudUserAnswer.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(27, 343);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(164, 46);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(27, 122);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(269, 46);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question Text";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(348, 13);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(267, 58);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Question #";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(754, 600);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(291, 79);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.Location = new System.Drawing.Point(754, 506);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(291, 79);
            this.btnCheckAnswer.TabIndex = 8;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(493, 633);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(42, 46);
            this.lblScoreValue.TabIndex = 5;
            this.lblScoreValue.Text = "0";
            // 
            // timerPlayTime
            // 
            this.timerPlayTime.Interval = 1000;
            this.timerPlayTime.Tick += new System.EventHandler(this.timerPlayTime_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 729);
            this.Controls.Add(this.panelQuestions);
            this.Controls.Add(this.lblCountSeconds);
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCountToStart;
        private System.Windows.Forms.Label lblCountSeconds;
        private System.Windows.Forms.Timer timerCountToDisappear;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown nudUserAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblAnswerResult;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Timer timerPlayTime;
    }
}