using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    public static class RandomQuestionsGenerator
    {
        public static List<String> easyQuestions = new List<String>();
        public static List<String> normalQuestions = new List<String>();
        public static List<String> hardQuestions = new List<String>();
        public static void generateQuestions()
        {
            easyQuestions.Add("How many SHAPES did you see in TOTAL?");
            easyQuestions.Add("How many RED SHAPES did you see?");
            easyQuestions.Add("How many GREEN SHAPES did you see?");
            easyQuestions.Add("How many BLUE SHAPES did you see?");
            easyQuestions.Add("How many CIRCLES did you see?");
            easyQuestions.Add("How many SQUARES did you see?");
            easyQuestions.Add("How many TRIANGLES did you see?");
            easyQuestions.Add("How many SMALL SHAPES did you see?");
            easyQuestions.Add("How many MEDIUM SIZED SHAPES did you see?");
            easyQuestions.Add("How many LARGE SHAPES did you see?");
        }
        public static String[] generateEasyQuestions()
        {
            String[] questions = new String[5];
            Random r = new Random();
            for(int i=0;i<5;i++)
            {
                string randomQuestion = easyQuestions[r.Next(0, easyQuestions.Count)];
                if(questions.Contains(randomQuestion))
                {
                    i--;
                    continue;
                }
                questions[i] = randomQuestion;
            }
            return questions;
        }
    }
}
