using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квиз_Меморија.GameStructure
{
    [Serializable]
    public class ScoreEntry:IComparable
    {
        public int Points { get; set; }
        public string Name { get; set; }
        public ScoreEntry(int points, string name)
        {
            this.Points = points;
            this.Name = name;
        }
        public int CompareTo(object obj)
        {
            ScoreEntry a = obj as ScoreEntry;
            return a.Points.CompareTo(Points);
        }
    }
}
