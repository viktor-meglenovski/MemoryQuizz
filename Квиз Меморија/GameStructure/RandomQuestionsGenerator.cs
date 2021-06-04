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


            normalQuestions.Add("How many RED CIRCLES did you see?");
            normalQuestions.Add("How many RED SQUARES did you see?");
            normalQuestions.Add("How many RED TRIANGLES did you see?");
            normalQuestions.Add("How many BLUE CIRCLES did you see?");
            normalQuestions.Add("How many BLUE SQUARES did you see?");
            normalQuestions.Add("How many BLUE TRIANGLES did you see?");
            normalQuestions.Add("How many GREEN CIRCLES did you see?");
            normalQuestions.Add("How many GREEN SQUARES did you see?");
            normalQuestions.Add("How many GREEN TRIANGLES did you see?");

            normalQuestions.Add("How many SMALL RED SHAPES did you see?");
            normalQuestions.Add("How many MEDIUM SIZED RED SHAPES did you see?");
            normalQuestions.Add("How many LARGE RED SHAPES did you see?");
            normalQuestions.Add("How many SMALL BLUE SHAPES did you see?");
            normalQuestions.Add("How many MEDIUM SIZED BLUE SHAPES did you see?");
            normalQuestions.Add("How many LARGE BLUE SHAPES did you see?");
            normalQuestions.Add("How many SMALL GREEN SHAPES did you see?");
            normalQuestions.Add("How many MEDIUM SIZED GREEN SHAPES did you see?");
            normalQuestions.Add("How many LARGE GREEN SHAPES did you see?");

            normalQuestions.Add("How many SMALL TRIANGLES did you see?");
            normalQuestions.Add("How many MEDIUM SIZED TRIANGLES did you see?");
            normalQuestions.Add("How many LARGE TRIANGLES did you see?");
            normalQuestions.Add("How many SMALL SQUARES did you see?");
            normalQuestions.Add("How many MEDIUM SIZED SQUARES did you see?");
            normalQuestions.Add("How many LARGE SQUARES did you see?");
            normalQuestions.Add("How many SMALL CIRCLES did you see?");
            normalQuestions.Add("How many MEDIUM SIZED CIRCLES did you see?");
            normalQuestions.Add("How many LARGE CIRCLES did you see?");


            hardQuestions.Add("How many RED SMALL TRIANGLES did you see?");
            hardQuestions.Add("How many RED SMALL CIRCLES did you see?");
            hardQuestions.Add("How many RED SMALL SQUARES did you see?");
            hardQuestions.Add("How many RED MEDIUM SIZED TRIANGLES did you see?");
            hardQuestions.Add("How many RED MEDIUM SIZED CIRCLES did you see?");
            hardQuestions.Add("How many RED MEDIUM SIZED SQUARES did you see?");
            hardQuestions.Add("How many RED LARGE TRIANGLES did you see?");
            hardQuestions.Add("How many RED LARGE SIZED CIRCLES did you see?");
            hardQuestions.Add("How many RED LARGE SIZED SQUARES did you see?");

            hardQuestions.Add("How many BLUE SMALL TRIANGLES did you see?");
            hardQuestions.Add("How many BLUE SMALL CIRCLES did you see?");
            hardQuestions.Add("How many BLUE SMALL SQUARES did you see?");
            hardQuestions.Add("How many BLUE MEDIUM SIZED TRIANGLES did you see?");
            hardQuestions.Add("How many BLUE MEDIUM SIZED CIRCLES did you see?");
            hardQuestions.Add("How many BLUE MEDIUM SIZED SQUARES did you see?");
            hardQuestions.Add("How many BLUE LARGE TRIANGLES did you see?");
            hardQuestions.Add("How many BLUE LARGE SIZED CIRCLES did you see?");
            hardQuestions.Add("How many BLUE LARGE SIZED SQUARES did you see?");

            hardQuestions.Add("How many GREEN SMALL TRIANGLES did you see?");
            hardQuestions.Add("How many GREEN SMALL CIRCLES did you see?");
            hardQuestions.Add("How many GREEN SMALL SQUARES did you see?");
            hardQuestions.Add("How many GREEN MEDIUM SIZED TRIANGLES did you see?");
            hardQuestions.Add("How many GREEN MEDIUM SIZED CIRCLES did you see?");
            hardQuestions.Add("How many GREEN MEDIUM SIZED SQUARES did you see?");
            hardQuestions.Add("How many GREEN LARGE TRIANGLES did you see?");
            hardQuestions.Add("How many GREEN LARGE SIZED CIRCLES did you see?");
            hardQuestions.Add("How many GREEN LARGE SIZED SQUARES did you see?");



        }
        public static String[] generateQuestionsForGame(int n)
        {
            //n e difficulty level;
            String[] questions = new String[5];
            Random r = new Random();
            List<String> temp = new List<String>();
            if (n == 0)
                temp = easyQuestions;
            else if (n == 1)
                temp = normalQuestions;
            else
                temp = hardQuestions;

            for (int i=0;i<5;i++)
            {
                string randomQuestion = temp[r.Next(0, temp.Count)];
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
