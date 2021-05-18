
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
            this.lblScore = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblAnswerResult = new System.Windows.Forms.Label();
            this.panelQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.panelQuestions.Controls.Add(this.lblAnswerResult);
            this.panelQuestions.Controls.Add(this.lblScoreValue);
            this.panelQuestions.Controls.Add(this.lblScore);
            this.panelQuestions.Controls.Add(this.numericUpDown1);
            this.panelQuestions.Controls.Add(this.lblAnswer);
            this.panelQuestions.Controls.Add(this.lblQuestion);
            this.panelQuestions.Controls.Add(this.lblQuestionNumber);
            this.panelQuestions.Location = new System.Drawing.Point(12, 12);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(1064, 705);
            this.panelQuestions.TabIndex = 3;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(218, 341);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 53);
            this.numericUpDown1.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCountToStart;
        private System.Windows.Forms.Label lblCountSeconds;
        private System.Windows.Forms.Timer timerCountToDisappear;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblAnswerResult;
        private System.Windows.Forms.Label lblScoreValue;
    }
}