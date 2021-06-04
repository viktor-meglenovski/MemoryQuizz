using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    [Serializable]
    public class ScoreBoardStructure
    {
        public List<ScoreEntry> Scores { get; set; }
        public ScoreBoardStructure()
        {
            this.Scores = new List<ScoreEntry>();
            sort();
        }
        public void add(int points, string name)
        {
            Scores.Add(new ScoreEntry(points, name));
            sort();
        }
        public void sort()
        {
            Scores.Sort();
        }
    }
}
