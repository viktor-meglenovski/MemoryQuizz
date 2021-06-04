
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timerCountToStart = new System.Windows.Forms.Timer(this.components);
            this.lblCountSeconds = new System.Windows.Forms.Label();
            this.timerCountToDisappear = new System.Windows.Forms.Timer(this.components);
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.nudUserAnswer = new System.Windows.Forms.NumericUpDown();
            this.lblAnswerResult = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.panelScore = new System.Windows.Forms.Panel();
            this.btnSeeImage = new System.Windows.Forms.Button();
            this.btnAddToScoreBoard = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.timerPlayTime = new System.Windows.Forms.Timer(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserAnswer)).BeginInit();
            this.panelScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCountToStart
            // 
            this.timerCountToStart.Interval = 1000;
            this.timerCountToStart.Tick += new System.EventHandler(this.timerCountToStart_Tick);
            // 
            // lblCountSeconds
            // 
            this.lblCountSeconds.Font = new System.Drawing.Font("MV Boli", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSeconds.Location = new System.Drawing.Point(1127, -5);
            this.lblCountSeconds.Name = "lblCountSeconds";
            this.lblCountSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountSeconds.Size = new System.Drawing.Size(175, 95);
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
            this.panelQuestions.Controls.Add(this.lblQuestion);
            this.panelQuestions.Controls.Add(this.btnCheckAnswer);
            this.panelQuestions.Controls.Add(this.btnNextQuestion);
            this.panelQuestions.Controls.Add(this.nudUserAnswer);
            this.panelQuestions.Controls.Add(this.lblAnswerResult);
            this.panelQuestions.Controls.Add(this.lblScoreValue);
            this.panelQuestions.Controls.Add(this.lblScore);
            this.panelQuestions.Controls.Add(this.lblAnswer);
            this.panelQuestions.Controls.Add(this.lblQuestionNumber);
            this.panelQuestions.Location = new System.Drawing.Point(12, 12);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(1118, 705);
            this.panelQuestions.TabIndex = 3;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(37, 156);
            this.lblQuestion.Multiline = true;
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.ReadOnly = true;
            this.lblQuestion.Size = new System.Drawing.Size(1052, 124);
            this.lblQuestion.TabIndex = 15;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckAnswer.BackgroundImage")));
            this.btnCheckAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckAnswer.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.Location = new System.Drawing.Point(708, 418);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(396, 133);
            this.btnCheckAnswer.TabIndex = 14;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextQuestion.BackgroundImage")));
            this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextQuestion.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(708, 557);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(396, 133);
            this.btnNextQuestion.TabIndex = 11;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // nudUserAnswer
            // 
            this.nudUserAnswer.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUserAnswer.Location = new System.Drawing.Point(223, 343);
            this.nudUserAnswer.Name = "nudUserAnswer";
            this.nudUserAnswer.Size = new System.Drawing.Size(120, 72);
            this.nudUserAnswer.TabIndex = 10;
            // 
            // lblAnswerResult
            // 
            this.lblAnswerResult.AutoSize = true;
            this.lblAnswerResult.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerResult.Location = new System.Drawing.Point(27, 445);
            this.lblAnswerResult.Name = "lblAnswerResult";
            this.lblAnswerResult.Size = new System.Drawing.Size(325, 55);
            this.lblAnswerResult.TabIndex = 6;
            this.lblAnswerResult.Text = "Question Text";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(493, 633);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(55, 55);
            this.lblScoreValue.TabIndex = 5;
            this.lblScoreValue.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(350, 633);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(152, 55);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(27, 343);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(190, 55);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("MV Boli", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(348, 13);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(345, 77);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Question #";
            // 
            // panelScore
            // 
            this.panelScore.Controls.Add(this.btnSeeImage);
            this.panelScore.Controls.Add(this.btnAddToScoreBoard);
            this.panelScore.Controls.Add(this.tbName);
            this.panelScore.Controls.Add(this.label6);
            this.panelScore.Controls.Add(this.pictureBox5);
            this.panelScore.Controls.Add(this.label4);
            this.panelScore.Controls.Add(this.pictureBox4);
            this.panelScore.Controls.Add(this.label5);
            this.panelScore.Controls.Add(this.pictureBox3);
            this.panelScore.Controls.Add(this.label3);
            this.panelScore.Controls.Add(this.pictureBox2);
            this.panelScore.Controls.Add(this.label2);
            this.panelScore.Controls.Add(this.pictureBox1);
            this.panelScore.Controls.Add(this.label1);
            this.panelScore.Controls.Add(this.label8);
            this.panelScore.Controls.Add(this.label7);
            this.panelScore.Controls.Add(this.lblFinalScore);
            this.panelScore.Location = new System.Drawing.Point(12, 12);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(1118, 702);
            this.panelScore.TabIndex = 9;
            // 
            // btnSeeImage
            // 
            this.btnSeeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeeImage.BackgroundImage")));
            this.btnSeeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeeImage.CausesValidation = false;
            this.btnSeeImage.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeImage.Location = new System.Drawing.Point(580, 423);
            this.btnSeeImage.Name = "btnSeeImage";
            this.btnSeeImage.Size = new System.Drawing.Size(519, 133);
            this.btnSeeImage.TabIndex = 16;
            this.btnSeeImage.Text = "See the image again";
            this.btnSeeImage.UseVisualStyleBackColor = true;
            this.btnSeeImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddToScoreBoard
            // 
            this.btnAddToScoreBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToScoreBoard.BackgroundImage")));
            this.btnAddToScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToScoreBoard.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToScoreBoard.Location = new System.Drawing.Point(580, 562);
            this.btnAddToScoreBoard.Name = "btnAddToScoreBoard";
            this.btnAddToScoreBoard.Size = new System.Drawing.Size(519, 133);
            this.btnAddToScoreBoard.TabIndex = 14;
            this.btnAddToScoreBoard.Text = "Add to Score Board";
            this.btnAddToScoreBoard.UseVisualStyleBackColor = true;
            this.btnAddToScoreBoard.Click += new System.EventHandler(this.btnAddToScoreBoard_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(78, 600);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(377, 74);
            this.tbName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(979, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 55);
            this.label6.TabIndex = 10;
            this.label6.Text = "#5";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(939, 255);
            this.pictureBox5.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "#4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(754, 255);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "#3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(567, 255);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "#2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(379, 255);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "#1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 255);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score Statistics";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(401, 55);
            this.label8.TabIndex = 12;
            this.label8.Text = "Enter your name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 55);
            this.label7.TabIndex = 11;
            this.label7.Text = "Final Score:";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("MV Boli", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(344, 445);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(210, 55);
            this.lblFinalScore.TabIndex = 15;
            this.lblFinalScore.Text = "0 Points";
            // 
            // timerPlayTime
            // 
            this.timerPlayTime.Interval = 1000;
            this.timerPlayTime.Tick += new System.EventHandler(this.timerPlayTime_Tick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.CausesValidation = false;
            this.btnReturn.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1136, 629);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(139, 71);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(230)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1287, 729);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblCountSeconds);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.panelQuestions);
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserAnswer)).EndInit();
            this.panelScore.ResumeLayout(false);
            this.panelScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCountToStart;
        private System.Windows.Forms.Label lblCountSeconds;
        private System.Windows.Forms.Timer timerCountToDisappear;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblAnswerResult;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Timer timerPlayTime;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAddToScoreBoard;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSeeImage;
        private System.Windows.Forms.NumericUpDown nudUserAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.TextBox lblQuestion;
    }
}