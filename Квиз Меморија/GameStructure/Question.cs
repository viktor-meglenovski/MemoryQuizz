using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public class Question
    {
        public string text { get; set; }
        public int answer { get; set; }
        public int userAnswer { get; set; }
        public bool isCorrect { get; set; }

        public Question(string text)
        {
            this.text = text;
            this.answer = 0;
            this.isCorrect = false;
            this.userAnswer = -1;
        }
        public void answerQuestion(int i)
        {
            userAnswer = i;
        }
        public void checkQuestion()
        {
            isCorrect= userAnswer == answer;
        }
        public string resultText()
        {
            return isCorrect ? "Correct!" : "Wrong answer!\r\nThe correct answer is " + answer;
        }
    }
}
