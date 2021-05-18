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

        public Question(string text, int answer)
        {
            this.text = text;
            this.answer = answer;
            this.isCorrect = false;
            this.userAnswer = -1;
        }
    }
}
